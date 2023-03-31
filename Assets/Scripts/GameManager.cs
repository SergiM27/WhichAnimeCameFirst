using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score = 0;
    public static int currentMode = 0;
    public static int adNumber = 0;
    public static int randomDoorNumber;
    // Start is called before the first frame update
    void Start()
    {
        randomDoorNumber = 0;
        score = 0;
        if (!PlayerPrefs.HasKey("HighScoreNormal")) PlayerPrefs.SetInt("HighScoreNormal", 0);
        if (!PlayerPrefs.HasKey("HighScoreBeat")) PlayerPrefs.SetInt("HighScoreBeat", 0);
    }

    public static bool SetHighScore()
    {
        if (currentMode == 1)
        {
            if (PlayerPrefs.GetInt("HighScoreNormal") < score)
            {
                PlayerPrefs.SetInt("HighScoreNormal", score);
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (currentMode == 2)
        {
            if (PlayerPrefs.GetInt("HighScoreBeat") < score)
            {
                PlayerPrefs.SetInt("HighScoreBeat", score);
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}
