using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
	public void HitTarget(Vector3 hitForce, Vector3 hitPoint) {
        GetComponent<Rigidbody>().AddForceAtPosition(hitForce, hitPoint);
		Destroy(gameObject, 5);
	}
}
