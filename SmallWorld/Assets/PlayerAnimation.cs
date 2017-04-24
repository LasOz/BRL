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
        //JUMP ANIMATIONS
        if (Input.GetButton("Jump"))
        {
      
            //JUMP RIGHT
            if (Input.GetAxis("Horizontal") > 0)
            {
                anim.Play("Jump3");
            }
            else
            {
                //JUMP LEFT
                if (Input.GetAxis("Horizontal") < 0)
                {
                    anim.Play("Jump2");
                }
                else
                {
                    //JUMP DOWN
                    if (Input.GetAxis("Vertical") < 0)
                    {
                        anim.Play("Jump1");
                    }
                    else
                    {
                        //JUMP UP
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
            //WALK ANIMATIONS
            //WALK RIGHT
            if (Input.GetAxis("Horizontal") > 0)
            {
                anim.Play("Walk3");
            }
            else
            {
                //WALK LEFT
                if (Input.GetAxis("Horizontal") < 0)
                {
                    anim.Play("Walk4");
                }
                else
                {
                    //WALK DOWN
                    if (Input.GetAxis("Vertical") < 0)
                    {
                        anim.Play("Walk1");
                    }
                    else
                    {
                        //WALK RIGHT
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
