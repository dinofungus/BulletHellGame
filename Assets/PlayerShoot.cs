using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public float fireRate;
	public GameObject shot;
	public Transform shotSpawn;

    private float nextShot = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        nextShot += Time.deltaTime;
        if (nextShot >= fireRate && Input.GetButton("Fire1"))
        {
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            nextShot = 0;
        }
	}
}
