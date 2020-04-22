using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinNameScript : MonoBehaviour
{

    public GameObject MeterScript;
    MeterScript meterScript;
    public GameObject BloomTransfer1;
    BloomTransferPlayer1 bloomtransfer1Script;
    public GameObject ScoreScript;
    ScoreScript scoreScript;
    public string WinName;
    public bool NewNameHighscore;
    string letter1;
    string letter2;
    string letter3;
    // Start is called before the first frame update
    void Start()
    {
        meterScript = MeterScript.GetComponent<MeterScript>();
        scoreScript = ScoreScript.GetComponent<ScoreScript>();
        bloomtransfer1Script = BloomTransfer1.GetComponent<BloomTransferPlayer1>();
        letter1 = "A";
        letter2 = "A";
        letter3 = "A";
    }

    // Update is called once per frame
    void Update()
    {
        if (meterScript.Won == true)
        {
            if(bloomtransfer1Script.CurrentScore < scoreScript.Score)
            {
                NewNameHighscore = true;
            }
            else
            {
                NewNameHighscore = false;
            }


            WinName = letter1 + letter2 + letter3;
        }
    }
}
