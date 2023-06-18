using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
    public void OnPlayButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnPlayReturnButton()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void OnHowToPlayButton()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}
