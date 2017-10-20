using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShot : MonoBehaviour {

	void OnColliderEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
