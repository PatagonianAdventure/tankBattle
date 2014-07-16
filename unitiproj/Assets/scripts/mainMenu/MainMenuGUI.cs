using UnityEngine;
using System.Collections;

public class MainMenuGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("escape")) {
			Application.Quit();
		}
	}

	void OnGUI() {
		if (GUI.Button (new Rect (10, 10, 150, 100), "I am a button")) {
			print("You clicked the button!");
		}

		if (GUI.Button (new Rect (10, 110, 150, 100), "Exit!")) {
			Application.Quit();
		}

		
	}
}
