using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * 8, Input.GetAxis("Vertical") * Time.deltaTime * 8);
        transform.Translate(input);
    }
}
