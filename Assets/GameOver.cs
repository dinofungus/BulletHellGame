using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    public GameObject endScreen;
    private GameController controller;


	// Use this for initialization
	void Start () {
        GameObject gameController = GameObject.Find("GameController");
        controller = gameController.GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "rate")
        {
            controller.GameOver();
        }
    }
}
