using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Linq;

public class HighscoreTableATGScript : MonoBehaviour
{
    //HighscoreTableScript script;
    //public GameObject EntryTemplate;
    private Transform entryContainer;
    private Transform entryTemplate;
    private List<HighscoreEntry> highscoreEntryList;
    private List<Transform> highscoreEntryTransformList;
    string jsonString;
    float Test;
    public float CurrentHighscore;
    public GameObject HighscoreChecker1;
    HighscoreCheckerScript highscorecheckerScript1;
    public GameObject HighscoreChecker2;
    HighscoreCheckerScript highscorecheckerScript2;
    public GameObject HighscoreChecker3;
    HighscoreCheckerScript highscorecheckerScript3;
    public GameObject HighscoreChecker4;
    HighscoreCheckerScript highscorecheckerScript4;
    public bool NewHS;
    public bool AddedNew;


    private void Start()
    {
        //script = GameObject.Find("BloomHighscore").GetComponent<HighscoreTableScript>();
        highscorecheckerScript1 = HighscoreChecker1.GetComponent<HighscoreCheckerScript>();
        highscorecheckerScript2 = HighscoreChecker2.GetComponent<HighscoreCheckerScript>();
        highscorecheckerScript3 = HighscoreChecker3.GetComponent<HighscoreCheckerScript>();
        highscorecheckerScript4 = HighscoreChecker4.GetComponent<HighscoreCheckerScript>();

        entryContainer = transform.Find("highscoreEntryContainer");
        entryTemplate = entryContainer.Find("highscoreEntryTemplate");

        entryTemplate.gameObject.SetActive(false);



        //AddHighscoreEntry(10000, "CMK");
        //AddHighscoreEntry(10000, "RMK");
        //AddHighscoreEntry(12000, "CNK");
        //AddHighscoreEntry(10300, "DMK");
        //AddHighscoreEntry(100400, "CAK");
        //AddHighscoreEntry(1337420, "EZY");

        //lägg till random highscores för test
        /* for (int i = 0; i < 5; i++)
         {
             int random = Random.Range(20000,40000);
             AddHighscoreEntry(random, "NEW");
         }*/

        //AddHighscoreEntry(1000, "AAA");

        jsonString = PlayerPrefs.GetString("highscoreTableATG");
        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);

        if (highscores == null)
        {
            // There's no stored table, initialize
            Debug.Log("Initializing table with default values...");
            AddHighscoreEntry(0, "AAA");
            AddHighscoreEntry(0, "AAA");
            AddHighscoreEntry(0, "AAA");
            AddHighscoreEntry(0, "AAA");
            AddHighscoreEntry(0, "AAA");
            AddHighscoreEntry(0, "AAA");
            AddHighscoreEntry(0, "AAA");
            AddHighscoreEntry(0, "AAA");
            AddHighscoreEntry(0, "AAA");
            AddHighscoreEntry(0, "AAA");
            // Reload
            jsonString = PlayerPrefs.GetString("highscoreTableATG");
            highscores = JsonUtility.FromJson<Highscores>(jsonString);
        }

        if (highscorecheckerScript1.NewScore > CurrentHighscore || highscores.highscoreEntryList.Count < 10)
        {
            AddHighscoreEntry(highscorecheckerScript1.NewScore, highscorecheckerScript1.Name);
            //AddedNew = true;
        }
        if (highscorecheckerScript2.NewScore > CurrentHighscore || highscores.highscoreEntryList.Count < 10)
        {
            AddHighscoreEntry(highscorecheckerScript2.NewScore, highscorecheckerScript2.Name);
            //AddedNew = true;
        }
        if (highscorecheckerScript3.NewScore > CurrentHighscore || highscores.highscoreEntryList.Count < 10)
        {
            AddHighscoreEntry(highscorecheckerScript3.NewScore, highscorecheckerScript3.Name);
            //AddedNew = true;
        }
        if (highscorecheckerScript4.NewScore > CurrentHighscore || highscores.highscoreEntryList.Count < 10)
        {
            AddHighscoreEntry(highscorecheckerScript4.NewScore, highscorecheckerScript4.Name);
            //AddedNew = true;
        }


        //sortera listan efter score
        highscores.highscoreEntryList.Sort((x, y) => y.Score.CompareTo(x.Score));






        //for (int i = 0; i < highscoreEntryList.Count; i++)
        //{
        //    for (int j = i + 1; j < highscoreEntryList.Count; j++)
        //    {
        //        if(highscoreEntryList[j].Score > highscoreEntryList[i].Score)
        //        {
        //            HighscoreEntry tmp = highscoreEntryList[i];
        //            highscoreEntryList[i] = highscoreEntryList[j];
        //            highscoreEntryList[j] = tmp;
        //        }
        //    }

        //}
        for (int i = 0; i < highscores.highscoreEntryList.Count; i++)
        {
            for (int j = 10; j < highscores.highscoreEntryList.Count; j++)
            {
                highscores.highscoreEntryList.RemoveAt(j);

            }
        }

        highscoreEntryTransformList = new List<Transform>();
        foreach (HighscoreEntry highscoreEntry in highscores.highscoreEntryList)
        {
            CreateHighscoreEntryTransform(highscoreEntry, entryContainer, highscoreEntryTransformList);
        }

        CurrentHighscore = highscores.highscoreEntryList.Last().Score;

        //PlayerPrefs.DeleteAll();

    }

    private void CreateHighscoreEntryTransform(HighscoreEntry highscoreEntry, Transform container, List<Transform> transformList)
    {
        float templateHeight = 24f;
        Transform entryTransform = Instantiate(entryTemplate, container);
        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
        entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);
        entryTransform.gameObject.SetActive(true);

        int rank = transformList.Count + 1;
        string rankString;
        switch (rank)
        {
            default:
                rankString = rank + "TH"; break;

            case 1: rankString = "1ST"; break;
            case 2: rankString = "2ND"; break;
            case 3: rankString = "3RD"; break;
        }

        entryTransform.Find("posText").GetComponent<TextMeshProUGUI>().text = rankString;

        float score = highscoreEntry.Score;

        entryTransform.Find("scoreText").GetComponent<TextMeshProUGUI>().text = score.ToString();

        string name = highscoreEntry.Name;
        entryTransform.Find("nameText").GetComponent<TextMeshProUGUI>().text = name;

        entryTransform.Find("TextBackground").gameObject.SetActive(rank % 2 == 1);
        transformList.Add(entryTransform);
    }

    private void AddHighscoreEntry(float Score, string Name)
    {
        //Create HighscoreEntry
        HighscoreEntry highscoreEntry = new HighscoreEntry { Score = Score, Name = Name };

        //Load saved Highscores
        jsonString = PlayerPrefs.GetString("highscoreTableATG");
        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);

        if (highscores == null)
        {
            // There's no stored table, initialize
            highscores = new Highscores()
            {
                highscoreEntryList = new List<HighscoreEntry>()
            };
        }

        //Add new entry to Highscores
        highscores.highscoreEntryList.Add(highscoreEntry);

        //Save updated Highscores
        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("highscoreTableATG", json);
        PlayerPrefs.Save();
    }

    private void Update()
    {
        //if (AddedNew)
        //{
        //    NewHS = true;
        //}

        //if (NewHS)
        //{
        //    NewHS = false;
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //}
    }



    [System.Serializable]
    public class Highscores
    {
        public List<HighscoreEntry> highscoreEntryList;
    }

    //representerar en highscore entry
    [System.Serializable]
    public class HighscoreEntry
    {
        public float Score;
        public string Name;
    }
}
