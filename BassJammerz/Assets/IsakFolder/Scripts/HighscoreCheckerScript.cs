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
    public GameObject BloomTransfer2;
    public GameObject BloomTransfer3;
    public GameObject BloomTransfer4;
    BloomTransferPlayer1 bloomtransfer1Script;
    BloomTransferPlayer2 bloomtransfer2Script;
    BloomTransferPlayer3 bloomtransfer3Script;
    BloomTransferPlayer4 bloomtransfer4Script;
    public GameObject ATGTransfer1;
    public GameObject ATGTransfer2;
    public GameObject ATGTransfer3;
    public GameObject ATGTransfer4;
    ATGTransferPlayer1 atgtransfer1Script;
    ATGTransferPlayer2 atgtransfer2Script;
    ATGTransferPlayer3 atgtransfer3Script;
    ATGTransferPlayer4 atgtransfer4Script;
    public GameObject FunkyFunTransfer1;
    public GameObject FunkyFunTransfer2;
    public GameObject FunkyFunTransfer3;
    public GameObject FunkyFunTransfer4;
    FunkyFunTransfer1 funkyfunTransfer1Script;
    FunkyFunTransfer2 funkyfunTransfer2Script;
    FunkyFunTransfer3 funkyfunTransfer3Script;
    FunkyFunTransfer4 funkyfunTransfer4Script;
    public float NewScore;
    public string Name;
    public float CurrentLowestScore;
    public int PlayerNr;
    public bool ATG;
    public bool Bloom;
    public bool FunkyFun;
    

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
        atgtransfer1Script = ATGTransfer1.GetComponent<ATGTransferPlayer1>();
        atgtransfer2Script = ATGTransfer2.GetComponent<ATGTransferPlayer2>();
        atgtransfer3Script = ATGTransfer3.GetComponent<ATGTransferPlayer3>();
        atgtransfer4Script = ATGTransfer4.GetComponent<ATGTransferPlayer4>();
        funkyfunTransfer1Script = FunkyFunTransfer1.GetComponent<FunkyFunTransfer1>();
        funkyfunTransfer2Script = FunkyFunTransfer2.GetComponent<FunkyFunTransfer2>();
        funkyfunTransfer3Script = FunkyFunTransfer3.GetComponent<FunkyFunTransfer3>();
        funkyfunTransfer4Script = FunkyFunTransfer4.GetComponent<FunkyFunTransfer4>();


        if (Bloom)
        {
            if (PlayerNr == 1)
            {
                NewScore = bloomtransfer1Script.NewHighscore;
                Name = bloomtransfer1Script.NewHighname;
            }
            else if (PlayerNr == 2)
            {
                NewScore = bloomtransfer2Script.NewHighscore;
                Name = bloomtransfer2Script.NewHighname;
            }
            else if (PlayerNr == 3)
            {
                NewScore = bloomtransfer3Script.NewHighscore;
                Name = bloomtransfer3Script.NewHighname;
            }
            else if (PlayerNr == 4)
            {
                NewScore = bloomtransfer4Script.NewHighscore;
                Name = bloomtransfer4Script.NewHighname;
            }
        }

      if(ATG)
        {
            if (PlayerNr == 1)
            {
                NewScore = atgtransfer1Script.NewHighscore;
                Name = atgtransfer1Script.NewHighname;
            }
            else if (PlayerNr == 2)
            {
                NewScore = atgtransfer2Script.NewHighscore;
                Name = atgtransfer2Script.NewHighname;
            }
            else if (PlayerNr == 3)
            {
                NewScore = atgtransfer3Script.NewHighscore;
                Name = atgtransfer3Script.NewHighname;
            }
            else if (PlayerNr == 4)
            {
                NewScore = atgtransfer4Script.NewHighscore;
                Name = atgtransfer4Script.NewHighname;
            }
        }

      if(FunkyFun)
        {
            if (PlayerNr == 1)
            {
                NewScore = funkyfunTransfer1Script.NewHighscore;
                Name = funkyfunTransfer1Script.NewHighname;
            }
            else if (PlayerNr == 2)
            {
                NewScore = funkyfunTransfer2Script.NewHighscore;
                Name = funkyfunTransfer2Script.NewHighname;
            }
            else if (PlayerNr == 3)
            {
                NewScore = funkyfunTransfer3Script.NewHighscore;
                Name = funkyfunTransfer3Script.NewHighname;
            }
            else if (PlayerNr == 4)
            {
                NewScore = funkyfunTransfer4Script.NewHighscore;
                Name = funkyfunTransfer4Script.NewHighname;
            }
        }

        //Debug.Log(bloomtransfer1Script.NewHighscore);

        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "ChooseSongScene" )
        {
            CurrentLowestScore = highscoretablescript.CurrentHighscore;
            bloomtransfer1Script.CurrentScore = CurrentLowestScore;
            bloomtransfer2Script.CurrentScore = CurrentLowestScore;
            bloomtransfer3Script.CurrentScore = CurrentLowestScore;
            bloomtransfer4Script.CurrentScore = CurrentLowestScore;
            atgtransfer1Script.CurrentScore = CurrentLowestScore;
            atgtransfer2Script.CurrentScore = CurrentLowestScore;
            atgtransfer3Script.CurrentScore = CurrentLowestScore;
            atgtransfer4Script.CurrentScore = CurrentLowestScore;
            funkyfunTransfer1Script.CurrentScore = CurrentLowestScore;
            funkyfunTransfer2Script.CurrentScore = CurrentLowestScore;
            funkyfunTransfer3Script.CurrentScore = CurrentLowestScore;
            funkyfunTransfer4Script.CurrentScore = CurrentLowestScore;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
