using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{

    private int scoreNormal;
    private int scoreBeat;
    public GameObject mainMenuNormalHighScore;
    public GameObject mainMenuBeatHighScore;
    Slider volume;

    void Start()
    {
        scoreNormal = PlayerPrefs.GetInt("HighScoreNormal");
        scoreBeat = PlayerPrefs.GetInt("HighScoreBeat");
        mainMenuNormalHighScore.GetComponent<TextMeshProUGUI>().text = "Highscore: " + scoreNormal;
        mainMenuBeatHighScore.GetComponent<TextMeshProUGUI>().text = "Highscore: " + scoreBeat;
        volume = GameObject.Find("VolumeSlider").GetComponent<Slider>();
        volume.value = PlayerPrefs.GetFloat("Volume");
        AudioManager.instance.SetVolume();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
