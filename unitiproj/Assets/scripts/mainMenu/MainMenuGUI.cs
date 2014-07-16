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
		if (GUI.Button (new Rect (10, 10, 150, 50), "Play")) {
			Application.LoadLevel("Level1");
		}

		if (GUI.Button (new Rect (10, 60, 150, 50), "Exit!")) {
			Application.Quit();
		}
	}
}
