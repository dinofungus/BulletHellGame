﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatDie : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnColliderEnter2D(Collider2D other)
    {        
        Destroy(gameObject);
    }
}
