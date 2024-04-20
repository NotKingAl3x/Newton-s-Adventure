using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMover : MonoBehaviour
{
    private float speed = -3f;
    private float mover;

    void Update()
    {    
        mover += (Time.deltaTime * speed);
        transform.position = new Vector2 (mover, 0);
        
    }
}
