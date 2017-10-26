using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatShoot : MonoBehaviour {

    public float fireRate;
    public GameObject shot;
    public Transform shotSpawn;

    private float nextShot = 0;

    // Update is called once per frame
    void Update () {
        nextShot += Time.deltaTime;
        if (nextShot >= fireRate)
        {
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            nextShot = 0;
        }
    }
}
