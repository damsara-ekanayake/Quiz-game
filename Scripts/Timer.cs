using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToAnswerQuestion = 30f;
    [SerializeField] float timeToDisplayAnswer = 10f;
    float timerValue;

    public bool isAnswering = false;
    public float fillFraction;
    public bool loadNextQuestion;

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (isAnswering) 
        {
            if (timerValue > 0) 
            { 
                fillFraction = timerValue / timeToAnswerQuestion;
            }
            else
            {
                isAnswering = false;
                timerValue = timeToDisplayAnswer;
            }
        }
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToDisplayAnswer;
            }
            if ( timerValue <= 0)
            {
                isAnswering = true;
                timerValue = timeToAnswerQuestion;
                loadNextQuestion = true;
            }
        }
    }

    public void CancleTimer()
    {
        timerValue = 0;
    }
}
