using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//I'm going to fucking kill you Star

public class CharacterAnimations2 : MonoBehaviour {

    private Animator animator;
    private PlayerMovement playerMovement;

    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {

        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        //DIRECTIONS HAPPEN HERE
        if (playerMovement.InAir)
        {
            //Setting state back to idle
            Debug.Log("Jumped\n");
            animator.SetInteger("States", 3);
        }
        else if (vertical > 0)
        {
            animator.SetInteger("Direction", 3);
            animator.SetInteger("States", 2);
        }
        else if (vertical < 0)
        {
            animator.SetInteger("Direction", 0);
            animator.SetInteger("States", 2);
        }
        else if (horizontal > 0)
        {
            animator.SetInteger("Direction", 2);
            animator.SetInteger("States", 2);
        }
        else if (horizontal < 0)
        {
            animator.SetInteger("Direction", 1);
            animator.SetInteger("States", 2);
        }
        else { 
            animator.SetInteger("States", 0);
        }

    }

}