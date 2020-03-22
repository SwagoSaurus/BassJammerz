using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;


public class HighscoreCheckerScript : MonoBehaviour
{
    public GameObject HighscoreTableScript;
    HighscoreTableScript highscoretablescript;
    public GameObject BloomTransfer1;
    BloomTransferPlayer1 bloomtransfer1Script;
    public float NewScore;
    public string Name;
    public float CurrentLowestScore;
    public int PlayerNr;

    //public void Awake()
    //{
    //    DontDestroyOnLoad(this);
    //}

    // Start is called before the first frame update
    void Start()
    {
        highscoretablescript = HighscoreTableScript.GetComponent<HighscoreTableScript>();
        bloomtransfer1Script = BloomTransfer1.GetComponent<BloomTransferPlayer1>();


        
        NewScore = bloomtransfer1Script.NewHighscore;
        Name = bloomtransfer1Script.NewHighname;

        Debug.Log(bloomtransfer1Script.NewHighscore);

        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "ChooseSongScene" )
        {
            CurrentLowestScore = highscoretablescript.CurrentHighscore;

        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
