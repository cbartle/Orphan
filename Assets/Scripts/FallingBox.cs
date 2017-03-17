﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBox : MonoBehaviour {

	void OnEnable(){
		gameObject.transform.Rotate (0, 0, 180);
		gameObject.GetComponent<Rigidbody2D> ().gravityScale *= -1;
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnDisable () {

		gameObject.transform.Rotate (0, 0, -180);
		gameObject.GetComponent<Rigidbody2D> ().gravityScale *= -1;

	}
}
