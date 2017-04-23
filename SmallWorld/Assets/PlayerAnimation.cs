using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

    
    Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Jump"))
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                anim.Play("Jump3");
            }
            else
            {

                if (Input.GetAxis("Horizontal") < 0)
                {
                    anim.Play("Jump2");
                }
                else
                {
                    if (Input.GetAxis("Vertical") < 0)
                    {
                        anim.Play("Jump1");
                    }
                    else
                    {
                        if (Input.GetAxis("Vertical") > 0)
                        {
                            anim.Play("Jump4");
                        }
                    }
                }
            }
        }
        else
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                anim.Play("Walk3");
            }
            else
            {

                if (Input.GetAxis("Horizontal") < 0)
                {
                    anim.Play("Walk4");
                }
                else
                {
                    if (Input.GetAxis("Vertical") < 0)
                    {
                        anim.Play("Walk1");
                    }
                    else
                    {
                        if (Input.GetAxis("Vertical") > 0)
                        {
                            anim.Play("Walk2");
                        }
                    }
                }
            }
        }
    }
}
