using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
	
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
        	rb.AddForce (new Vector3 (0, 500, 0));
        }
		if (Input.GetKeyDown(KeyCode.W))
        {
        	rb.AddForce (new Vector3 (0, 0, 300));
			//transform.Translate( 0, 0, 1);
        }
		if (Input.GetKeyDown(KeyCode.S))
        {
			rb.AddForce (new Vector3 (0, 0, -300));
        }
		
		if (Input.GetKeyDown(KeyCode.D))
        {
			rb.AddForce (new Vector3 (300, 0, 0));
        }
		if (Input.GetKeyDown(KeyCode.A))
        {
			rb.AddForce (new Vector3 (-300, 0, 0));
		}
	}
}
