using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnimeButtonPress : MonoBehaviour
{
    public CSVReader csv;
    public AnimeList animeList;
    public GameObject transition;

    public GameObject button1;
    public GameObject button2;

    public GameObject wrongAnswerCircle;
    public GameObject rightAnswerCircle;
    public GameObject middleCircleMask;

    public GameObject levelLoader;
    public Canvas levelLoaderCanvas;
    public Chronometer chrono;

    public TextMeshProUGUI scoreText;

    private AdManager admanager;


    void Awake()
    {
        transition.GetComponent<Animator>().SetBool("Start", true);
    }
    public void Start()
    {
        admanager = GameObject.Find("AdManager").GetComponent<AdManager>();
        levelLoaderCanvas.sortingOrder = 1;
    }
    public void Button1Pressed()
    {
        button1.gameObject.GetComponent<Button>().enabled = false;
        button2.gameObject.GetComponent<Button>().enabled = false;
        chrono.timerActive = false;
        if (animeList.currentAnime1Year > animeList.currentAnime2Year)
        {
            StartCoroutine(WrongCoroutine());
        }
        else
        {
            StartCoroutine(RightCoroutine());
        }
    }

    public void Button2Pressed()
    {
        button1.gameObject.GetComponent<Button>().enabled = false;
        button2.gameObject.GetComponent<Button>().enabled = false;
        chrono.timerActive = false;
        if (animeList.currentAnime2Year > animeList.currentAnime1Year)
        {
            StartCoroutine(WrongCoroutine());
        }
        else
        {
            StartCoroutine(RightCoroutine());
        }

    }

    public void GameOver()
    {
        StartCoroutine(WrongCoroutine());
    }

    public IEnumerator RightCoroutine()
    {
        wrongAnswerCircle.gameObject.SetActive(false);
        rightAnswerCircle.gameObject.SetActive(true);
        middleCircleMask.GetComponent<Animator>().SetBool("Answer", true);
        animeList.AssignYearAnimes();
        chrono.timerActive = false;
        AudioManager.instance.PlaySFX2("Correct");

        yield return new WaitForSeconds(1.5f);
        
        middleCircleMask.GetComponent<Animator>().SetBool("Done", true);
        middleCircleMask.GetComponent<Animator>().SetBool("Answer", false);
        middleCircleMask.GetComponent<RectMask2D>().padding = new Vector4 (0,100,0,0);
        wrongAnswerCircle.gameObject.SetActive(false);
        rightAnswerCircle.gameObject.SetActive(false);

        transition.GetComponent<Animator>().SetBool("Start", true);

        //Score;
        GameManager.score++;
        scoreText.text = "Score: " + GameManager.score.ToString();
        chrono.currentTime = chrono.timeToAnswer;

    }

    public IEnumerator WrongCoroutine()
    {
        wrongAnswerCircle.gameObject.SetActive(true);
        rightAnswerCircle.gameObject.SetActive(false);
        middleCircleMask.GetComponent<Animator>().SetBool("Answer", true);
        animeList.AssignYearAnimes();
        AudioManager.instance.PlaySFX2("Wrong");

        if (GameManager.adNumber == 0)
        {
            GameManager.adNumber++;
        }
        else if (GameManager.adNumber == 1)
        {
            yield return new WaitForSeconds(2.5f);
            admanager.LoadInerstitialAd();
            GameManager.adNumber = 0;
        }
        yield return new WaitForSeconds(1f);
        levelLoaderCanvas.sortingOrder = 3;
        levelLoader.GetComponent<LevelLoader>().GameOver();
    }



}
