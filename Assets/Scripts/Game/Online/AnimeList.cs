using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnimeList : MonoBehaviour
{
    public CSVReader csv;

    //Imagenes de anime de la escena
    public Image anime1On;
    public Image anime2On;

    //Objetos de texto de titulo de anime
    public TextMeshProUGUI animeName1Text;
    public TextMeshProUGUI animeName2Text;

    //Objetos de texto de año de anime
    public TextMeshProUGUI animeYear1Text;
    public TextMeshProUGUI animeYear2Text;

    //CurrentAnime variables
    public int currentAnime1;
    public int currentAnime2;
    public int currentAnime1Year;
    public int currentAnime2Year;

    public GameObject transition;
    public GameObject button1;
    public GameObject button2;

    void Start()
    {
        GameManager.score = 0;
        AssignNewAnimes();
        //InvokeRepeating("AssignNewAnimes", 0.1f, 0.1f);
    }

    void AssignAnimesToScene(int anime1, int anime2)
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            Invoke("TransitionPanelsOut", 1f);
            //Asignar año
            animeYear1Text.text = "?";
            animeYear2Text.text = "?";

            //animeYear2Text.text = csv.myAnimeList.animes[anime2].year.ToString();
            currentAnime1Year = csv.myAnimeList.animes[anime1].year;
            currentAnime2Year = csv.myAnimeList.animes[anime2].year;

            //Asignar nombre del anime
            animeName1Text.text = csv.myAnimeList.animes[anime1].name;
            animeName2Text.text = csv.myAnimeList.animes[anime2].name;

            //Asignar animes a variables
            currentAnime1 = csv.myAnimeList.animes[anime1].index;
            currentAnime2 = csv.myAnimeList.animes[anime2].index;

            anime1On.sprite = null;
            anime2On.sprite = null;
            return;
        }
        else
        {
            //AssignarSprites
            WebRequests.GetSprite1(csv.myAnimeList.animes[anime1].imageURL, csv.myAnimeList.animes[anime2].imageURL, (string error) =>
            {
                Debug.Log("Error: " + error);
            },
            (Texture2D texture2D) => {
                Sprite sprite1 = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f), 10);
                if (sprite1 != null)
                {
                    anime1On.sprite = sprite1;
                    
                }
                else
                {
                    AssignAnimesToScene(anime1, anime2);
                }
            });

            WebRequests.GetSprite2(csv.myAnimeList.animes[anime1].imageURL, csv.myAnimeList.animes[anime2].imageURL, (string error) =>
            {
                Debug.Log("Error: " + error);
            },
           (Texture2D texture2D) => {
               Sprite sprite2 = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f), 10);
               if (sprite2 != null)
               {
                   anime2On.sprite = sprite2;
                   Invoke("TransitionPanelsOut", 0.5f);
               }
               else
               {
                   AssignAnimesToScene(anime1, anime2);
               }

           });
        }

        //Asignar año
        animeYear1Text.text = "?";
        animeYear2Text.text = "?";

        //animeYear2Text.text = csv.myAnimeList.animes[anime2].year.ToString();
        currentAnime1Year = csv.myAnimeList.animes[anime1].year;
        currentAnime2Year = csv.myAnimeList.animes[anime2].year;

        //Asignar nombre del anime
        animeName1Text.text = csv.myAnimeList.animes[anime1].name;
        animeName2Text.text = csv.myAnimeList.animes[anime2].name;

        //Asignar animes a variables
        currentAnime1 = csv.myAnimeList.animes[anime1].index;
        currentAnime2 = csv.myAnimeList.animes[anime2].index;

    }

    public void AssignYearAnimes()
    {
        animeYear1Text.text = currentAnime1Year.ToString();
        animeYear2Text.text = currentAnime2Year.ToString();
    }

    public void AssignNewAnimes()
    {
      
        int newAnime = UnityEngine.Random.Range(0, csv.myAnimeList.animes.Length);
        int newAnime2 = UnityEngine.Random.Range(0, csv.myAnimeList.animes.Length);
        /*int newAnime = score;
        int newAnime2 = score+1;*/

        if (newAnime != newAnime2)
        {
            AssignAnimesToScene(newAnime, newAnime2);
           
        }
        else
        {
            AssignNewAnimes();
        }
    }

    void TransitionPanelsOut()
    {
        transition.GetComponent<Animator>().SetBool("Start", false);
        button1.gameObject.GetComponent<Button>().enabled = true;
        button2.gameObject.GetComponent<Button>().enabled = true;
    }

}
