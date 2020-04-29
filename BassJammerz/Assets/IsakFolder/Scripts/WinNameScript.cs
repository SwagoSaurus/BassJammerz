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
    public GameObject Bokstäver1;
    public GameObject Bokstäver2;
    public GameObject Bokstäver3;
    PickLetterScript bokstäver1;
    PickLetterScript bokstäver2;
    PickLetterScript bokstäver3;

    public string[] WhatLetter;
    // Start is called before the first frame update
    void Start()
    {
        meterScript = MeterScript.GetComponent<MeterScript>();
        scoreScript = ScoreScript.GetComponent<ScoreScript>();
        bloomtransfer1Script = BloomTransfer1.GetComponent<BloomTransferPlayer1>();
        letter1 = "A";
        letter2 = "A";
        letter3 = "A";
        bokstäver1 = Bokstäver1.GetComponent<PickLetterScript>();
        bokstäver2 = Bokstäver2.GetComponent<PickLetterScript>();
        bokstäver3 = Bokstäver3.GetComponent<PickLetterScript>();

        WhatLetter = new string[36];

        WhatLetter[0] = "A";
        WhatLetter[1] = "B";
        WhatLetter[2] = "C";
        WhatLetter[3] = "D";
        WhatLetter[4] = "E";
        WhatLetter[5] = "F";
        WhatLetter[6] = "G";
        WhatLetter[7] = "H";
        WhatLetter[8] = "I";
        WhatLetter[9] = "J";
        WhatLetter[10] = "K";
        WhatLetter[11] = "L";
        WhatLetter[12] = "M";
        WhatLetter[13] = "N";
        WhatLetter[14] = "O";
        WhatLetter[15] = "P";
        WhatLetter[16] = "Q";
        WhatLetter[17] = "R";
        WhatLetter[18] = "S";
        WhatLetter[19] = "T";
        WhatLetter[20] = "U";
        WhatLetter[21] = "V";
        WhatLetter[22] = "W";
        WhatLetter[23] = "X";
        WhatLetter[24] = "Y";
        WhatLetter[25] = "Z";
        WhatLetter[26] = "1";
        WhatLetter[27] = "2";
        WhatLetter[28] = "3";
        WhatLetter[29] = "4";
        WhatLetter[30] = "5";
        WhatLetter[31] = "6";
        WhatLetter[32] = "7";
        WhatLetter[33] = "8";
        WhatLetter[34] = "9";
        WhatLetter[35] = "0";
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

            letter1 = WhatLetter[bokstäver1.LetterPlace];
            letter2 = WhatLetter[bokstäver2.LetterPlace];
            letter3 = WhatLetter[bokstäver3.LetterPlace];

            WinName = letter1 + letter2 + letter3;
        }
    }

    //public void WhatLetter(int Place)
    //{
    //    if (bokstäver1.LetterPlace == 0)
    //    {
    //        letter1 = "A";
    //    }
    //}
}
