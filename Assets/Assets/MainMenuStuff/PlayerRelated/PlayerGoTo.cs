using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGoTo : MonoBehaviour
{
    public GameObject player;
    public GameObject pointA;
    public Rigidbody2D rb;
    public float speed = 0.5f;
    [SerializeField] private Behaviour playerGoTo;
    private bool isGoingTo = true;
     
    void Update()
    {
        if(isGoingTo)
        {
            MoveTowards();
        }
        
    }
    void MoveTowards()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
        if(player.transform.position.x >= -3.5f)
        {
            rb.velocity = new Vector2(0f, rb.velocity.y);
            isGoingTo = false;
        }
    }
}
