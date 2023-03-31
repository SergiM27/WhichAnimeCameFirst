using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.currentMode == 1)
        {
            this.gameObject.GetComponent<TextMeshProUGUI>().text = "High Score: " + PlayerPrefs.GetInt("HighScoreNormal");
        }
        else if (GameManager.currentMode == 2)
        {
            this.gameObject.GetComponent<TextMeshProUGUI>().text = "High Score: " + PlayerPrefs.GetInt("HighScoreBeat");
        }
    }
}
