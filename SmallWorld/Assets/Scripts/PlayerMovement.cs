using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    float thrustx;
    public float thrusty = 1;
    float thrustz;
    Rigidbody rb;
    

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        thrustx = Input.GetAxis("Horizontal") * Time.deltaTime * 1024.0f;
        thrustz = Input.GetAxis("Vertical") * Time.deltaTime * 1024.0f;
        
        //transform.Translate(x, 0, z);
        rb.AddForce(transform.right * thrustx);
        rb.AddForce(transform.up * thrusty);
        rb.AddForce(transform.forward * thrustz);
        if (Input.GetButton("Jump"))
        {
            rb.AddForce(transform.up * thrusty, ForceMode.Impulse);
        }
    }
}
