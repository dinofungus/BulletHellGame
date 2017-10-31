using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject endScreen;

    bool gameOver = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver)
        {
            if (Input.GetKey(KeyCode.R))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
	}
    public void GameOver()
    {
        gameOver = true;
        endScreen.SetActive(true);
        Time.timeScale = 0;
    }
    
}
