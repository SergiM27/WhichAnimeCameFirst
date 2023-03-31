using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMainMenuNo : MonoBehaviour
{

    public Animator settingsMenu;
    public void SettingsExit()
    {
        settingsMenu.SetBool("Start", false);
    }
}
