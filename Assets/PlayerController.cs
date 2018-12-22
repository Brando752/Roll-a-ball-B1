using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody rb;

    Vector3 offset;

	// Use this for initialization
	void Start () {

        rb = this.GetComponent<Rigidbody>();
        





		offset = Camera.main.transform.position - this.transform.position 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
