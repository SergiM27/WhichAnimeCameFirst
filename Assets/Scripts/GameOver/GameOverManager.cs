using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverManager : MonoBehaviour
{

    public GameObject score;
    public GameObject newHighScore;


    void Start()
    {
        if (GameManager.SetHighScore())
        {
            newHighScore.SetActive(true);
        }
        else
        {
            newHighScore.SetActive(false);
        }

        score.GetComponent<TextMeshProUGUI>().text = GameManager.score.ToString();
    }
}
