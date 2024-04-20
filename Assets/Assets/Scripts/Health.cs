using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    
    public int health;
    public Image[] hearts;

    public Sprite normalHeart;
    public Sprite goldenHeart;
    public Sprite emptyHeart;

    private bool isDead;

    public GameOverScreen gameOver;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Awake()
    {
        health = 3;
    }

    void Update()
    {
        foreach (Image img in hearts)
        {
            img.sprite = emptyHeart;
        }

        if(health <= 3)
        {
            for (int i = 0 ; i < health; i++)
            {
                hearts[i].sprite = normalHeart;
            }
        }
    
        if(health > 3)
        {
            for (int i = 0 ; i < 3; i++)
            {
                hearts[i].sprite = normalHeart;
            }
            for(int j = 0; j < health - 3; j++)
            {
                hearts[j].sprite = goldenHeart;
            }
        }

        if(health <= 0 && !isDead)
        {
            isDead = true;
            gameOver.GameOver();
        }
    }

}
