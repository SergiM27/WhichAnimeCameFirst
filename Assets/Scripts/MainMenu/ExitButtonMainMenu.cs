using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButtonMainMenu : MonoBehaviour
{

    public Animator transitionAnimator;


    public void ExitMenu()
    {
        transitionAnimator.SetBool("Start", true);
    }
}
