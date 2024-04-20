using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Void : MonoBehaviour
{
    public GameOverScreen gameOver;
    [SerializeField] private Collider2D voidCollider; 

     private void OnTriggerEnter2D(Collider2D voidCollider) //If the player reaches the void(out of the map)
     {
        gameOver.GameOver(); // GameOver runs (You Died)
     }
}
