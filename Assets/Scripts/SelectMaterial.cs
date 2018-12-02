using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectMaterial : MonoBehaviour {
    public Image crosshair;
    public Material selected;

    // Use this for initialization
    void Start () {
        selected = new Earth();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selected = new Earth();
        } else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selected = new Grass();
        } else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            selected = new Sticky();
        }

        crosshair.color = selected.color;
    }
}
