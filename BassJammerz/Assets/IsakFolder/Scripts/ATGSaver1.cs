using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATGSaver1 : MonoBehaviour
{


    public GameObject MeterScript;
    MeterScript meterScript;
    public GameObject ScoreScript;
    ScoreScript scoreScript;
    public GameObject ATGTransfer1;
    ATGTransferPlayer1 atgtransfer1Script;
    public GameObject WinName;
    WinNameScript winnameScript;
    public float NewScore;
    public bool PlayerWon;

    //public void Awake()
    //{
    //    DontDestroyOnLoad(this);
    //}

    // Start is called before the first frame update
    void Start()
    {
        meterScript = MeterScript.GetComponent<MeterScript>();
        scoreScript = ScoreScript.GetComponent<ScoreScript>();
        atgtransfer1Script = ATGTransfer1.GetComponent<ATGTransferPlayer1>();
        winnameScript = WinName.GetComponent<WinNameScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (meterScript.Won == true)
        {
            PlayerWon = true;
            atgtransfer1Script.NewScore = scoreScript.Score;
            atgtransfer1Script.NewWinName = winnameScript.WinName;
        }

    }
}
