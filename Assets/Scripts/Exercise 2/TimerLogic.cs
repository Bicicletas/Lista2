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
        // If the time remaining isn't 0 the timer activates and makes an image start desappearing depending by the courrent time
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

    // Displays the timer in minutes and secons of the time remaining in a text
    private void Timer()
    {
        float minutes = Mathf.FloorToInt(timeRemaining / 60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);

        timerText.text = $"{minutes} : {seconds}";
    }
}    
