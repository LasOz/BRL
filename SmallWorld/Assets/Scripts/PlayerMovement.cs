using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float HThrust;
    public float VThrust;
    float JumpForce = 4f;
    float maxSpeed = 5;
    float ray = 0.1f;
    Rigidbody rb;
    


    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        
	}

    // Update is called once per frame
    void Update ()
    {
        
        HThrust = Input.GetAxis("Horizontal") * Time.deltaTime * 1024.0f;
        VThrust = Input.GetAxis("Vertical") * Time.deltaTime * 1024.0f;
        rb.AddForce(transform.right * HThrust);
        rb.AddForce(transform.forward * VThrust);
        if (Input.GetButton("Jump") && Physics.Raycast(transform.position, -Vector3.up, ray))
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
        
    }
}
