using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButtonScript : MonoBehaviour
{
    public GameObject text;
    public GameObject options;
    public GameObject quit;
    public Button play;
    public GameObject title;
    public GameObject levelSelector;
    public GameObject playButton;
    public GameObject textclose;
    public GameObject textlevelselector;
    public GameObject text1;
    public GameObject text2;
    public Button close;
    public Button b1;
    public Button b2;

    public void Play()
    {
        StartCoroutine(PlayText());
        title.SetActive(false);
        options.SetActive(false);
        quit.SetActive(false);
        play.interactable = false;
    }
    IEnumerator PlayText()
    {
        if (text != null && playButton != null && levelSelector != null && 
            close != null && b1 != null && b2 != null && 
            text1 != null && text2 != null && 
            textclose != null && textlevelselector != null)
        {
            yield return new WaitForSeconds(0.5f);
            text.SetActive(false);
            yield return new WaitForSeconds(1.0f);
            playButton.SetActive(false);
            levelSelector.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            close.interactable = true;
            b1.interactable = true;
            b2.interactable = true;
            text1.SetActive(true);
            text2.SetActive(true);
            textclose.SetActive(true);
            textlevelselector.SetActive(true);
        }
        else
        {
            Debug.LogError("One or more references are null.");
        }
    }
}