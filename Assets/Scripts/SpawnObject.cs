using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObject : MonoBehaviour {
    [SerializeField] private Camera _camera;
    [SerializeField] private int _fireRate = 2;
    [SerializeField] private float _objectScale = 1f;
    [SerializeField] private SelectMaterial selectMaterial;
    [SerializeField] private Rigidbody TargetCube;
    [SerializeField] private Text SizeText;

    private float _timeToNextShoot;

    // Use this for initialization
    void Start()
    {
        _timeToNextShoot = 0;
        SizeText.text = "Size: " + _objectScale.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Fire
        if (Input.GetButton("Fire2") && Time.time > _timeToNextShoot)
        {
            spawnCube();
        }
        
        // Increase/Decrease spawned object size
       _objectScale += Input.mouseScrollDelta.y / 20;
 
        SizeText.text = "Size: " + _objectScale.ToString();
    }

    void spawnCube()
    {
        _timeToNextShoot = Time.time + 1f / _fireRate;
        Vector3 cubePosition = _camera.transform.position + _camera.transform.forward * (1 + _objectScale); // In front of the player, no matter the scale
        Quaternion cubeRotation = _camera.transform.rotation;
        Rigidbody cube = (Rigidbody)Instantiate(TargetCube, cubePosition, cubeRotation);
        cube.GetComponent<MeshRenderer>().material.color = selectMaterial.selected.color;
        cube.transform.localScale = new Vector3(_objectScale, _objectScale, _objectScale);
        cube.mass = selectMaterial.selected.density * Mathf.Pow(_objectScale, 3); // This formula only applies for cubes. Find a way to calculate for other shapes
        cube.collisionDetectionMode = CollisionDetectionMode.Continuous;
        cube.useGravity = false;

    }
}
