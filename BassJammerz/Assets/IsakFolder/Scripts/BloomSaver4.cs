using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloomSaver4 : MonoBehaviour
{


    public GameObject MeterScript;
    MeterScript meterScript;
    public GameObject ScoreScript;
    ScoreScript scoreScript;
    public GameObject BloomTransfer4;
    BloomTransferPlayer4 bloomtransfer4Script;
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
        bloomtransfer4Script = BloomTransfer4.GetComponent<BloomTransferPlayer4>();
        winnameScript = WinName.GetComponent<WinNameScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (meterScript.Won == true)
        {
            PlayerWon = true;
            bloomtransfer4Script.NewScore = scoreScript.Score;
            bloomtransfer4Script.NewWinName = winnameScript.WinName;
        }

    }
}
