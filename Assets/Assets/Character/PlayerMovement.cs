using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public BackroundMover BackroundSpeed;
 
    public CharacterController2D controller;

    public Animator animator;

    public Rigidbody2D rb;

    public Transform player;

    public BoxCollider2D ceilingcheck;

    public WallCollider wallCollider;

    


    const float ceilingRadius = .2f;

    public float walkSpeed = 40f;

    float horizontalMove = 0f;
    
    public float runMultiplier = 2f;

    bool jump = false;

    public bool isRunning = false;
    
    public bool isGravityUp = true;

    private void OnTriggerEnter2D(Collider2D ceilingcheck)
    {
        if (ceilingcheck.CompareTag("Ground"))
        {
            animator.SetBool("Jump", false);

        }

    }


    public void Update()
    {
        
        
        isRunning = Input.GetButton("Run");

        if(!isGravityUp)
        {
            if(rb.velocity.y < -0.1)
            {
                animator.SetBool("Fall", true);
                animator.SetBool("Jump", false);
            }
            else
            {
                animator.SetBool("Fall", false);
            }
        }
        else
        {
            if(rb.velocity.y > 0.1)
            {
                animator.SetBool("Fall", true);
                animator.SetBool("Jump", false);
            }
            else
            {
                animator.SetBool("Fall", false);
            }

        }

        horizontalMove = Input.GetAxisRaw("Horizontal") * walkSpeed;  
        

        if(horizontalMove>0) BackroundSpeed.BackroundSpeed = 0.2f;
        else if(horizontalMove==0) BackroundSpeed.BackroundSpeed = 0.1f;
        else BackroundSpeed.BackroundSpeed = 0.05f;


        if (Input.GetButtonDown("Jump"))
        {

            jump = true ;

        }
        if (Input.GetButtonDown("Gravity"))
        {
            if(controller.m_Grounded)
            {
               ToggleGravity();
               Vector2 jumpForce = Vector2.up * (isGravityUp ? -controller.m_JumpForce : controller.m_JumpForce);
               rb.AddForce(-(jumpForce/2));
            }
        }

        if(!wallCollider.isTouchingWall)
        {
        animator.SetBool("Run", Input.GetButton("Run"));
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        }
        else
        {
        animator.SetBool("Run", false);
        animator.SetFloat("Speed", 0f);
        }
    }

    void FixedUpdate()
    {

       controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
       jump = false;
       
       
    }

    void ToggleGravity()
    {

        if(!isGravityUp)
        {
            rb.gravityScale = -1;
            transform.localScale = new Vector3 (player.localScale.x, -1, player.localScale.z );

        }
        else
        {
            rb.gravityScale = 1;
            transform.localScale = new Vector3 (player.localScale.x, 1, player.localScale.z );
        }
        
        isGravityUp = !isGravityUp;


    }

}
