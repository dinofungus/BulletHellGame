using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShot : MonoBehaviour {

	public void Update()
    {
        if (transform.position.y > 6 || transform.position.y < -6)
        {
            DestroyObject(gameObject);
        }
    }
}
