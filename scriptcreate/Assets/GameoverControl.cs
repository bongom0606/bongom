using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameoverControl : MonoBehaviour {

    GUIStyle style;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 50), "Game Over");
    }

}
