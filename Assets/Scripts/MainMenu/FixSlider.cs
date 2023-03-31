using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FixSlider : MonoBehaviour
{
    public void ValueChanged()
    {
        AudioManager.instance.SetVolume();
    }

    private void Start()
    {
        if (!PlayerPrefs.HasKey("Volume")) PlayerPrefs.SetFloat("Volume", 0.3f);
        this.gameObject.GetComponent<Slider>().value = PlayerPrefs.GetInt("Volume");
    }
}
