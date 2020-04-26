using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloomSaver3 : MonoBehaviour
{


    public GameObject MeterScript;
    MeterScript meterScript;
    public GameObject ScoreScript;
    ScoreScript scoreScript;
    public GameObject BloomTransfer1;
    BloomTransferPlayer1 bloomtransfer1Script;
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
        bloomtransfer1Script = BloomTransfer1.GetComponent<BloomTransferPlayer1>();
        winnameScript = WinName.GetComponent<WinNameScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (meterScript.Won == true)
        {
            PlayerWon = true;
            bloomtransfer1Script.NewScore = scoreScript.Score;
            bloomtransfer1Script.NewWinName = winnameScript.WinName;
        }

    }
}
