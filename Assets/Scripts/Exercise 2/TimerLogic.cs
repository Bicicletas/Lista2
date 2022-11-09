using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerLogic : MonoBehaviour
{
    public float maxTime = 60.0f;
    public float timeRemaining = 60.0f;

    public Image timerBar;

    public TextMeshProUGUI timerText;

    private void Update()
    {
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            Timer();
            timerBar.fillAmount = timeRemaining / maxTime;
        }
        else
        {
            timeRemaining = 0;
        }
    }

    private void Timer()
    {
        float minutes = Mathf.FloorToInt(timeRemaining / 60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);

        timerText.text = $"{minutes} : {seconds}";
    }
}    
