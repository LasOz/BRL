using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour {

    public float HThrust;
    public float VThrust;
    float JumpForce = 7f;
    float maxSpeed = 4;
    float ray = 0.1f;
    Rigidbody rb;
    public bool InAir;
    


    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();  
	}
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Untagged" && InAir == true)
        {
            InAir = false;
        }
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Untagged" && InAir == true)
        {
            InAir = false;
        }
    }

    void OnCollisionExit(Collision other)
    {
        InAir = true;
    }

    // Update is called once per frame
    void Update ()
    {

        if (Input.GetKeyDown("z")) { 
        HThrust = Input.GetAxis("Horizontal") * Time.deltaTime * 2724.0f;
        VThrust = Input.GetAxis("Vertical") * Time.deltaTime * 2724.0f;
        maxSpeed = 15;
            rb.AddForce(transform.right * HThrust);
            rb.AddForce(transform.forward * VThrust);
        }
        else
        {
            HThrust = Input.GetAxis("Horizontal") * Time.deltaTime * 324.0f;
            VThrust = Input.GetAxis("Vertical") * Time.deltaTime * 324.0f;
        maxSpeed = 4;
            rb.AddForce(transform.right * HThrust);
            rb.AddForce(transform.forward * VThrust);
        }
        rb.AddForce(transform.right * HThrust);
        rb.AddForce(transform.forward * VThrust);
        if (Input.GetButtonDown("Jump") && InAir == false)
            {
                rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            }     
        }
    }

