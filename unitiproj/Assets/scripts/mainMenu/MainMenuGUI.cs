using UnityEngine;
using System.Collections;

public class MainMenuGUI : MonoBehaviour {

	long start = 0;

	// Use this for initialization
	void Start () {
		start = System.DateTime.Now.Ticks;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("escape")) {
			Application.Quit();
		}
	}

	void OnGUI() {
		// Build area of entire screen
		// mucho codigo...es un layout flexible...pufff
		GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));

		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		
		if (GUILayout.Button("Play")) {
			Application.LoadLevel("Level1");
		}

		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();

		if (GUILayout.Button("Exit!")) {
			Application.Quit();
		}
		
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.EndArea();
	}
}
