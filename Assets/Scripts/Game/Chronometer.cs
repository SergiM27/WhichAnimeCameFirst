using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Chronometer : MonoBehaviour
{

    public float timeToAnswer;
    public float currentTime;
    public TextMeshProUGUI chronoText;
    public bool timerActive = false;
    public AnimeButtonPress abp;

    // Start is called before the first frame update
    void Start()
    {
        timerActive = false;
        currentTime = timeToAnswer;
        if (GameManager.currentMode == 1)
        {
            this.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive == true)
        {
            currentTime = currentTime - Time.deltaTime;


            if (currentTime <= 0)
            {
                abp.GameOver();
                timerActive = false;
            }
        }

        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        chronoText.text = time.Seconds.ToString();
    }

    public void StartTimer()
    {
        timerActive = true;
    }

    public void StopTimer()
    {
        timerActive = false;
    }
}
