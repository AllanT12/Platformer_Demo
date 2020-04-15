using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public CharacterController2D controller;

    public Animator animator;

    float horizontalMovement = 0f;

    public float speedrun = 40f;

    bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement=Input.GetAxisRaw("Horizontal") * speedrun;

        animator.SetFloat("Speed",Mathf.Abs(horizontalMovement));

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping",true);
        }
        
    }
    public void OnLanding()
    {
        animator.SetBool("IsJumping",false);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMovement * Time.fixedDeltaTime,false,jump);
        jump = false;
    }
}
