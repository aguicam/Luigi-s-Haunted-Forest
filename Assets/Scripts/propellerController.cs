﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propellerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(20*(new Vector3(0.0f,1.0f,0.0f)));
	}
}