using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpDetect : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;
    private float jumpforce = 8f;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
    }

    private void Update()
    {

        if (rb.velocity.y < -0.2f)
        {
            animator.SetBool("Fall", true);
            animator.SetBool("Jump", false);
        }
        else if (rb.velocity.y > 0.1f)
        {
            animator.SetBool("Fall", false);
            animator.SetBool("Jump", true);
        }
        else
        {
            animator.SetBool("Fall", false);
            animator.SetBool("Jump", false);
        }

    }



}
