using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDoneFalseCircle : MonoBehaviour
{
    public void SetDoneFalse()
    {
        this.gameObject.GetComponent<Animator>().SetBool("Done", false);
    }
    public void SetAnswerFalse()
    {
        this.gameObject.GetComponent<Animator>().SetBool("Answer", false);
    }
}
