using System;
using UnityEngine;
using UnityEngine.UI;

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
            time += Time.deltaTime;
            updateTimer(time);
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
}
