using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseScript : MonoBehaviour
{
    public GameObject options;
    public GameObject quit;
    public GameObject title;
    public GameObject levelSelector;
    public GameObject play;
    public GameObject textclose;
    public GameObject textlevelselector;
    public GameObject text1;
    public GameObject text2;
    public Animator animator;
    public GameObject playText;
    public Button close;
    public Button b1;
    public Button b2;
    public Button playButton;
    public Button quitButton;
    public Button optionsButton;
    public Animator playAnimator;




    public void CloseMenu()
    {
        StartCoroutine(CloseLevels());
        close.interactable = false;
        b1.interactable = false;
        b2.interactable = false;
        textclose.SetActive(false);
        textlevelselector.SetActive(false);
        text1.SetActive(false);
        text2.SetActive(false);
        animator.SetTrigger("ClosedMenu");
    }

    IEnumerator CloseLevels()
    {
        yield return new WaitForSeconds(1.5f);
        playText.SetActive(true);
        levelSelector.SetActive(false);
        play.SetActive(true);
        title.SetActive(true);
        quit.SetActive(true);
        options.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        playButton.interactable = true;
        quitButton.interactable = true;
        optionsButton.interactable = true;


    }


}
