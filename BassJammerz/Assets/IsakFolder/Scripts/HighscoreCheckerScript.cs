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
    public GameObject BloomTransfer2;
    public GameObject BloomTransfer3;
    public GameObject BloomTransfer4;
    BloomTransferPlayer2 bloomtransfer2Script;
    BloomTransferPlayer3 bloomtransfer3Script;
    BloomTransferPlayer4 bloomtransfer4Script;
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
        bloomtransfer2Script = BloomTransfer2.GetComponent<BloomTransferPlayer2>();
        bloomtransfer3Script = BloomTransfer3.GetComponent<BloomTransferPlayer3>();
        bloomtransfer4Script = BloomTransfer4.GetComponent<BloomTransferPlayer4>();



        NewScore = bloomtransfer1Script.NewHighscore;
        Name = bloomtransfer1Script.NewHighname;

        Debug.Log(bloomtransfer1Script.NewHighscore);

        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "ChooseSongScene" )
        {
            CurrentLowestScore = highscoretablescript.CurrentHighscore;
            bloomtransfer1Script.CurrentScore = CurrentLowestScore;
            bloomtransfer2Script.CurrentScore = CurrentLowestScore;
            bloomtransfer3Script.CurrentScore = CurrentLowestScore;
            bloomtransfer4Script.CurrentScore = CurrentLowestScore;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
