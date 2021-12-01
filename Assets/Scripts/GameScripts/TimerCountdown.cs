using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StarterAssets;

public class TimerCountdown : MonoBehaviour
{

    public float timeRemaining = 10f;
    public bool countdown = false;
    public bool hasFinished = false;

    public string timeReadout;

    public float minutes;
    public float seconds;

    [SerializeField] private GameObject endScreen;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject gameUI;

    [SerializeField] private GameObject GoldCount;


    public void StartCountdown()
    {
        countdown = true;
    }

    public void StopCountdown()
    {
        countdown = false;
    }

    void Update()
    {
        if (countdown)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                hasFinished = true;
                Debug.Log("Time is up");
                timeRemaining = 0;
                DisplayTime(timeRemaining);
            }
        }

        if (hasFinished)
        {
            countdown = false;
            GoldCount.SendMessage("Maintenance");
            Debug.Log("Taking maintenance fee");
            timeRemaining = 300;
            hasFinished = false;
            countdown = true;
        }

    }

    void DisplayTime(float timeToDisplay)
    {
        minutes = Mathf.FloorToInt(timeToDisplay / 60);
        seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeReadout = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
