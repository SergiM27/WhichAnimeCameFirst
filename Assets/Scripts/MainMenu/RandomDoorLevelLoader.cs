using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RandomDoorLevelLoader : MonoBehaviour
{
    private int numberOfDoorTextures;

    public Image leftDoorLevelLoader;
    public Image rightDoorLevelLoader;
    public List<Sprite> doorTexturesL;
    public List<Sprite> doorTexturesR;

    private void Start()
    {
        switch (GameManager.randomDoorNumber)
        {
            case 0:
                leftDoorLevelLoader.sprite = doorTexturesL[0];
                rightDoorLevelLoader.sprite = doorTexturesR[0];
                break;
            case 1:
                leftDoorLevelLoader.sprite = doorTexturesL[1];
                rightDoorLevelLoader.sprite = doorTexturesR[1];
                break;
            case 2:
                leftDoorLevelLoader.sprite = doorTexturesL[2];
                rightDoorLevelLoader.sprite = doorTexturesR[2];
                break;
            case 3:
                leftDoorLevelLoader.sprite = doorTexturesL[3];
                rightDoorLevelLoader.sprite = doorTexturesR[3];
                break;
            case 4:
                leftDoorLevelLoader.sprite = doorTexturesL[4];
                rightDoorLevelLoader.sprite = doorTexturesR[4];
                break;
            case 5:
                leftDoorLevelLoader.sprite = doorTexturesL[5];
                rightDoorLevelLoader.sprite = doorTexturesR[5];
                break;
            case 6:
                leftDoorLevelLoader.sprite = doorTexturesL[6];
                rightDoorLevelLoader.sprite = doorTexturesR[6];
                break;
            case 7:
                leftDoorLevelLoader.sprite = doorTexturesL[7];
                rightDoorLevelLoader.sprite = doorTexturesR[7];
                break;
            case 8:
                leftDoorLevelLoader.sprite = doorTexturesL[8];
                rightDoorLevelLoader.sprite = doorTexturesR[8];
                break;
            case 9:
                leftDoorLevelLoader.sprite = doorTexturesL[8];
                rightDoorLevelLoader.sprite = doorTexturesR[8];
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
                leftDoorLevelLoader.sprite = doorTexturesL[0];
                rightDoorLevelLoader.sprite = doorTexturesR[0];
                break;
            case 1:
                leftDoorLevelLoader.sprite = doorTexturesL[1];
                rightDoorLevelLoader.sprite = doorTexturesR[1];
                break;
            case 2:
                leftDoorLevelLoader.sprite = doorTexturesL[2];
                rightDoorLevelLoader.sprite = doorTexturesR[2];
                break;
            case 3:
                leftDoorLevelLoader.sprite = doorTexturesL[3];
                rightDoorLevelLoader.sprite = doorTexturesR[3];
                break;
            case 4:
                leftDoorLevelLoader.sprite = doorTexturesL[4];
                rightDoorLevelLoader.sprite = doorTexturesR[4];
                break;
            case 5:
                leftDoorLevelLoader.sprite = doorTexturesL[5];
                rightDoorLevelLoader.sprite = doorTexturesR[5];
                break;
            case 6:
                leftDoorLevelLoader.sprite = doorTexturesL[6];
                rightDoorLevelLoader.sprite = doorTexturesR[6];
                break;
            case 7:
                leftDoorLevelLoader.sprite = doorTexturesL[7];
                rightDoorLevelLoader.sprite = doorTexturesR[7];
                break;
            case 8:
                leftDoorLevelLoader.sprite = doorTexturesL[8];
                rightDoorLevelLoader.sprite = doorTexturesR[8];
                break;
            case 9:
                leftDoorLevelLoader.sprite = doorTexturesL[8];
                rightDoorLevelLoader.sprite = doorTexturesR[8];
                break;
            default:
                print("Incorrect");
                break;
        }
    }
}
