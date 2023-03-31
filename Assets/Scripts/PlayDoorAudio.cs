using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDoorAudio : MonoBehaviour
{
    public void DoorAudioPlay()
    {

        AudioManager.instance.PlaySFX("Door");

    }
}
