using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Rigidbody>().AddForce(Vector3.forward * 0.3f, ForceMode.Impulse);
	}
}
