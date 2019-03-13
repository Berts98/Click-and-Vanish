using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public int scoreValue;
    public Text Points;

	// Use this for initialization
	void Start ()
    {
        scoreValue = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
		Points.text = "Score:" + scoreValue;
	}
}
