﻿using UnityEngine;
using System.Collections;

public class Level1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("escape")) {
			Application.LoadLevel("MainMenu"); 
			//Application.Quit();
		}
	}
}
