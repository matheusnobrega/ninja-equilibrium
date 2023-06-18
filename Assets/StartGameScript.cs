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

    public void OnCreditsButton()
    {
        SceneManager.LoadScene("Credits");
    }

    public void OnHowToPlayButton()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void OnQuitGameButton()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
}
