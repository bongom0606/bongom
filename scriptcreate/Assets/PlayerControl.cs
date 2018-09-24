using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    int x = 100;

	// Use this for initialization
	void Start () {
        Debug.Log("Start Player:x="+transform.position.x+ " y=" + transform.position.y+ " z=" + transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");
        transform.Translate(x * 0.2f, 0, 0);
        float z = Input.GetAxis("Vertical");
        transform.Translate(0, 0, 0.2f * z);
    }

    void OnCollisionEnter(Collision other) {
        if ( other.gameObject.name == "RightWall")
        {
            Debug.Log("RightWall Hit");
        }
        if (other.gameObject.name == "LeftWall")
        {
            Debug.Log("LeftWall Hit");
        }
    }
}
