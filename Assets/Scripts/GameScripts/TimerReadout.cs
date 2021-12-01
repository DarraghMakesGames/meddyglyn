using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerReadout : MonoBehaviour
{

    [SerializeField] private GameObject gameManager;
    private string currentTime;
    private TMP_Text timeRead;

    private void Start()
    {
        timeRead = GetComponent<TMP_Text>();
        currentTime = gameManager.GetComponent<TimerCountdown>().timeReadout;
    }

    private void Update()
    {
        currentTime = gameManager.GetComponent<TimerCountdown>().timeReadout;
        timeRead.text = currentTime;
    }

}
