using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RandomDoorInGame : MonoBehaviour
{
    private int numberOfDoorTextures;

    public Image leftDoorGame;
    public Image rightDoorGame;
    public List<Sprite> doorTexturesL;
    public List<Sprite> doorTexturesR;

    private void Start()
    {
        switch (GameManager.randomDoorNumber)
        {
            case 0:
                leftDoorGame.sprite = doorTexturesL[0];
                rightDoorGame.sprite = doorTexturesR[0];
                Debug.Log("0");
                break;
            case 1:
                leftDoorGame.sprite = doorTexturesL[1];
                rightDoorGame.sprite = doorTexturesR[1];
                Debug.Log("1");
                break;
            case 2:
                leftDoorGame.sprite = doorTexturesL[2];
                rightDoorGame.sprite = doorTexturesR[2];
                Debug.Log("2");
                break;
            case 3:
                leftDoorGame.sprite = doorTexturesL[3];
                rightDoorGame.sprite = doorTexturesR[3];
                Debug.Log("3");
                break;
            case 4:
                leftDoorGame.sprite = doorTexturesL[4];
                rightDoorGame.sprite = doorTexturesR[4];
                Debug.Log("4");
                break;
            case 5:
                leftDoorGame.sprite = doorTexturesL[5];
                rightDoorGame.sprite = doorTexturesR[5];
                Debug.Log("5");
                break;
            case 6:
                leftDoorGame.sprite = doorTexturesL[6];
                rightDoorGame.sprite = doorTexturesR[6];
                Debug.Log("6");
                break;
            case 7:
                leftDoorGame.sprite = doorTexturesL[7];
                rightDoorGame.sprite = doorTexturesR[7];
                Debug.Log("7");
                break;
            case 8:
                leftDoorGame.sprite = doorTexturesL[8];
                rightDoorGame.sprite = doorTexturesR[8];
                Debug.Log("8");
                break;
            case 9:
                leftDoorGame.sprite = doorTexturesL[8];
                rightDoorGame.sprite = doorTexturesR[8];
                Debug.Log("9");
                break;
            default:
                print("Incorrect");
                break;
        }
    }
    public void RandomDoorTexture()
    {
        int i = Random.Range(0, doorTexturesL.Count);
        while (i == GameManager.randomDoorNumber)
        {
            i = Random.Range(0, doorTexturesL.Count);
        }
        GameManager.randomDoorNumber = i;
        switch (GameManager.randomDoorNumber)
        {
            case 0:
                leftDoorGame.sprite = doorTexturesL[0];
                rightDoorGame.sprite = doorTexturesR[0];
                Debug.Log("0");
                break;
            case 1:
                leftDoorGame.sprite = doorTexturesL[1];
                rightDoorGame.sprite = doorTexturesR[1];
                Debug.Log("1");
                break;
            case 2:
                leftDoorGame.sprite = doorTexturesL[2];
                rightDoorGame.sprite = doorTexturesR[2];
                Debug.Log("2");
                break;
            case 3:
                leftDoorGame.sprite = doorTexturesL[3];
                rightDoorGame.sprite = doorTexturesR[3];
                Debug.Log("3");
                break;
            case 4:
                leftDoorGame.sprite = doorTexturesL[4];
                rightDoorGame.sprite = doorTexturesR[4];
                Debug.Log("4");
                break;
            case 5:
                leftDoorGame.sprite = doorTexturesL[5];
                rightDoorGame.sprite = doorTexturesR[5];
                Debug.Log("5");
                break;
            case 6:
                leftDoorGame.sprite = doorTexturesL[6];
                rightDoorGame.sprite = doorTexturesR[6];
                Debug.Log("6");
                break;
            case 7:
                leftDoorGame.sprite = doorTexturesL[7];
                rightDoorGame.sprite = doorTexturesR[7];
                Debug.Log("7");
                break;
            case 8:
                leftDoorGame.sprite = doorTexturesL[8];
                rightDoorGame.sprite = doorTexturesR[8];
                Debug.Log("8");
                break;
            case 9:
                leftDoorGame.sprite = doorTexturesL[8];
                rightDoorGame.sprite = doorTexturesR[8];
                Debug.Log("9");
                break;
            default:
                print("Incorrect");
                break;
        }
    }
}
