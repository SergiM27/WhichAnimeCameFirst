using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
public class CSVReader : MonoBehaviour
{
    // Start is called before the first frame updateç

    public TextAsset textAssetData;

    [System.Serializable]
    public class Anime
    {
        public string name;
        public int index;
        public int year;
        public string imageURL;
    }

    [System.Serializable]
    public class AnimeList
    {
        public Anime[] animes;
    }

    public AnimeList myAnimeList = new AnimeList();
    void Awake()
    {
        ReadCSV();
    }


    void ReadCSV()
    {
        string[] data = textAssetData.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);

        int tableSize = data.Length / 4 - 1;

        myAnimeList.animes = new Anime[tableSize];

        for (int i=0; i < tableSize; i++)
        {
            myAnimeList.animes[i] = new Anime();
            myAnimeList.animes[i].index = int.Parse(data[4 * (i+1)]);
            myAnimeList.animes[i].name = (data[4 * (i + 1) + 1]);
            myAnimeList.animes[i].year = int.Parse(data[4 * (i + 1) + 2]);
            myAnimeList.animes[i].imageURL = data[4 * (i + 1) + 3];
        }
    }

}
