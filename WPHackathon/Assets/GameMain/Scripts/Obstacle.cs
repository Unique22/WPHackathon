﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    transform.position += new Vector3(0,0,1);
	}

    private void OnCollisionEnter(Collision other)
    {
        //other.transform.GetComponent<きたい>();
        //heightの減少、または増加
        //

    }
}
