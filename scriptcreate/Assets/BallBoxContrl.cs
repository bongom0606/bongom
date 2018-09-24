using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallBoxContrl : MonoBehaviour {

    public GameObject ball;
    int n = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonUp("Jump"))
        {
            Debug.Log("Create ball");
            Instantiate(ball, transform.position, transform.rotation);
            n++;
            if ( n >= 10)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
	}
}
