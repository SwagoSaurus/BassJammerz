using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunkyFunSaver3 : MonoBehaviour
{


    public GameObject MeterScript;
    MeterScript meterScript;
    public GameObject ScoreScript;
    ScoreScript scoreScript;
    public GameObject FunkyFunTransfer1;
    FunkyFunTransfer1 funkyfuntransfer1Script;
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
        funkyfuntransfer1Script = FunkyFunTransfer1.GetComponent<FunkyFunTransfer1>();
        winnameScript = WinName.GetComponent<WinNameScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (meterScript.Won == true)
        {
            PlayerWon = true;
            funkyfuntransfer1Script.NewScore = scoreScript.Score;
            funkyfuntransfer1Script.NewWinName = winnameScript.WinName;
        }

    }
}