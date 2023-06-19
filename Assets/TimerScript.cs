using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public float time = 0;
    public bool timerOn = false;


    public Text TimerTxt;

    private void Start()
    {
        timerOn = true;
    }
    void Update()
    {
        if (timerOn)
        {
            if (time < 180) 
            {
                time += Time.deltaTime;
                updateTimer(time);
            }
            else
            {
                WinSceneChange();
            }
            
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds); 
    }

    public void stopTimer()
    {
        timerOn = false;
    }

    public void WinSceneChange()
    {
        SceneManager.LoadScene("WinGame");
    }
}
