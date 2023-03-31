using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenuButton : MonoBehaviour
{

    public Animator transitionAnimator;


    public void SettingsMenu()
    {
        transitionAnimator.SetBool("Start", true);
    }
}
