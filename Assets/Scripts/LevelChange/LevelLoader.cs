using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    public void QuitGame()
    {
        Application.Quit();
    }
    public void PlayPress()
    {
        StartCoroutine(LoadLevel_NormalTransition(1));
    }
    public void NormalMode()
    {
        GameManager.currentMode = 1;
        StartCoroutine(LoadLevel_NormalTransition(1));
    }

    public void BeatTheClock()
    {
        GameManager.currentMode = 2;
        StartCoroutine(LoadLevel_NormalTransition(1));
    }

    public void BackToMenuPress()
    {
        StartCoroutine(LoadLevel_NormalTransition(0));
    }

    public void GameOver()
    {
        StartCoroutine(LoadLevel_NormalTransition(2));
    }

    IEnumerator LoadLevel_NormalTransition(int levelIndex)
    {
        transition.SetBool("Start",true);

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
