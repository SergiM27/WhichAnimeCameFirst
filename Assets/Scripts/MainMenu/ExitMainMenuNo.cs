using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMainMenuNo : MonoBehaviour
{

    public Animator exitMenu;
    public void NoExit()
    {
        exitMenu.SetBool("Start", false);
    }
}
