﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    // Use this for initialization
    public float speed;
    void Start () {
		
	}
    
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, 1 * speed * Time.deltaTime));
	}
}
