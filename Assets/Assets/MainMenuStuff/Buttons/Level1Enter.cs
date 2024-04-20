using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Enter : MonoBehaviour
{
    public void EnterLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
}
