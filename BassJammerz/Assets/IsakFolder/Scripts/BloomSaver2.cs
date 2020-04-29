using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloomSaver2 : MonoBehaviour
{


    public GameObject MeterScript;
    MeterScript meterScript;
    public GameObject ScoreScript;
    ScoreScript scoreScript;
    public GameObject BloomTransfer2;
    BloomTransferPlayer2 bloomtransfer2Script;
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
        bloomtransfer2Script = BloomTransfer2.GetComponent<BloomTransferPlayer2>();
        winnameScript = WinName.GetComponent<WinNameScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (meterScript.Won == true)
        {
            PlayerWon = true;
            bloomtransfer2Script.NewScore = scoreScript.Score;
            bloomtransfer2Script.NewWinName = winnameScript.WinName;
        }

    }
}
