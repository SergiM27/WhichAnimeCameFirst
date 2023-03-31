using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AssignAnimesOnTransition : MonoBehaviour
{

    public AnimeList animeList;
    public GameObject button1;
    public GameObject button2;
    public Chronometer chrono;
    // Start is called before the first frame update
   public void TransitionDone()
    {
        animeList.AssignNewAnimes();
        GameObject.Find("MiddleCircleMask").GetComponent<Animator>().SetBool("Done", true);
    }

    public void ChronoOn()
    {
        chrono.timerActive = true;
    }
}
