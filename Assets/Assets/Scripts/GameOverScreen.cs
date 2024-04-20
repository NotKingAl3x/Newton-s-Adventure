using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private GameObject gameOverGUI;
    [SerializeField] private GameObject player; 
    [SerializeField] private TMP_Text appleScore;
    [SerializeField] private Behaviour playerMovement;
    [SerializeField] private AppleManager appleManager;
    [SerializeField] private Animator animator;
    [SerializeField] private Rigidbody2D rb;


    public void GameOver()
    {
        gameOverGUI.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        appleScore.text = appleManager.apples.ToString();
        playerMovement.enabled = false;
        StartCoroutine(Dying());
    }
    IEnumerator Dying()
    {
        rb.velocity = new Vector2 (0, 0);
        animator.SetTrigger("isDead");
        yield return new WaitForSeconds(2);
        player.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
