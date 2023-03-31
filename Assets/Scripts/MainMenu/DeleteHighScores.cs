using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DeleteHighScores : MonoBehaviour
{

    public TextMeshProUGUI highScoreNormal;
    public TextMeshProUGUI highScoreTimer;
    private int timesPressed;
    private float timer;
    private bool firstTimePressed;

    public TextMeshProUGUI areYou;

    private void Start()
    {
        timesPressed = 0;
    }
    public void DeleteScores()
    {
        timesPressed++;
        if (timesPressed == 1)
        {
            timer = 3;
            areYou.gameObject.SetActive(true);
            areYou.text = "Are you sure? Click again to delete.";
        }
        else if (timesPressed == 2)
        {
            timer = 3;
            areYou.gameObject.SetActive(true);
            float volume = PlayerPrefs.GetFloat("Volume");
            PlayerPrefs.DeleteAll();
            highScoreNormal.text = "High Score: " + PlayerPrefs.GetInt("HighScoreNormal");
            highScoreTimer.text = "High Score: " + PlayerPrefs.GetInt("HighScoreBeat");
            if (!PlayerPrefs.HasKey("Volume")) PlayerPrefs.SetFloat("Volume", volume);
            areYou.text = "Highscores deleted!";
            timesPressed = 0;
            Invoke("HideDelete", 2.0f);
        }
        else if(timesPressed >= 3)
        {
            timesPressed = 0;
            DeleteScores();
        }
   
    }

    void HideDelete()
    {
        areYou.text = "";
    }

    private void Update()
    {
        if (timesPressed == 0)
        {
            timer = 0;
        }
        else if (timesPressed >= 1)
        {
            timer -= Time.deltaTime;
        }

        if (timer < 0)
        {
            timesPressed = 0;
            areYou.gameObject.SetActive(false);
        }
    }
}
