using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{
    public Button quit;
    public GameObject text;
    public GameObject play;
    public GameObject options;
    public GameObject title;
    
 
    public void QuitGame()
    {
        title.SetActive(false);
        options.SetActive(false);
        play.SetActive(false);
        quit.interactable = false;
        StartCoroutine(QuitApp());
    }
    IEnumerator QuitApp()
    {
        yield return new WaitForSeconds(1);
        text.SetActive(false);
        yield return new WaitForSeconds(1);
        Application.Quit();
    }
}
