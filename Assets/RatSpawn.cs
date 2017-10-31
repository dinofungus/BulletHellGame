using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatSpawn : MonoBehaviour {
    public float spawnRate;
    public GameObject rat;

    private float elapsed = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        elapsed += Time.deltaTime;
        Vector3 position = new Vector3(transform.position.x + Random.Range(-6, 6), transform.position.y);
        if (elapsed > spawnRate)
        {
            Instantiate(rat, position, transform.rotation);
            elapsed -= spawnRate;
            spawnRate = spawnRate * 0.95f;
        }
	}

}
