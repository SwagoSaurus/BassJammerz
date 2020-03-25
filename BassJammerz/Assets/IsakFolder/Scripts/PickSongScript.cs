﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickSongScript : MonoBehaviour
{
    public KeyCode Up;
    public KeyCode Down;
    public KeyCode Play;
    public bool Bloom;
    public bool ATG;
    public bool Test1;
    public bool Test2;
    public string SceneName;
    public RectTransform textTransform;
    public RectTransform Test1Transform;
    public RectTransform Test2Transform;
    public RectTransform BloomTransform;
    public int NumberOfSongsOverMid;
    public int NumberOfSongsUnderMid;
    Vector3 earlyPos;
    Vector3 latePos;
    Vector3 startPos;
    Vector3 PressPos;
    Vector3 PressEndPos;
    public GameObject HighscoreTable;
    HighscoreTableScript highscoretableScript;
    float lerpTime;
    public int PositionNr;
    public GameObject BloomPickSongMusicScript;
    PickSongMusicScript picksongmusicScriptBloom;
    public GameObject ATGPickSongMusicScript;
    PickSongMusicScript picksongmusicScriptATG;
    // Start is called before the first frame update
    void Awake()
    {
        if(Bloom == true)
        {
            SceneName = "Bloom";
        }
        else if(Test1 == true)
        {
            SceneName = "Test1";
        }
        else if(Test2 == true)
        {
            SceneName = "Test2";
        }

    }
    void Start()
    {
        highscoretableScript = HighscoreTable.GetComponent<HighscoreTableScript>();
        picksongmusicScriptBloom = BloomPickSongMusicScript.GetComponent<PickSongMusicScript>();
        picksongmusicScriptATG = ATGPickSongMusicScript.GetComponent<PickSongMusicScript>();

        startPos = textTransform.anchoredPosition;
        earlyPos = startPos;
        latePos = startPos;
        PressPos = startPos;
        PressEndPos = startPos;
        lerpTime = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        {

            if (PositionNr < NumberOfSongsOverMid)
            {
            if (Input.GetKeyDown(Up))
            {
                PositionNr += 1;
                PressPos = textTransform.anchoredPosition;
                //PressEndPos = new Vector3(PressPos.x, PressPos.y - 150, PressPos.z);
                lerpTime = 0;
                
            }
            }
            if (PositionNr > -NumberOfSongsUnderMid)
            {
            if (Input.GetKeyDown(Down))
            {
                PositionNr -= 1;
                PressPos = textTransform.anchoredPosition;
                //PressEndPos = new Vector3(PressPos.x, PressPos.y + 150, PressPos.z);
                lerpTime = 0;
                
            }
            }
        }

        PressEndPos = new Vector3(startPos.x, startPos.y + 100 * PositionNr, startPos.z);

        if (textTransform.anchoredPosition.y == 0)
        {
            if (Input.GetKeyDown(Play))
            {
                SceneManager.LoadScene(SceneName);
            }
        }


        earlyPos = new Vector3(startPos.x, PressPos.y, startPos.z);
        latePos = new Vector3(startPos.x, PressEndPos.y, startPos.z);
        lerpTime += Time.deltaTime * 3f;
        textTransform.anchoredPosition = Vector3.Lerp(earlyPos, latePos, lerpTime);

        
        //textTransform.anchoredPosition = latePos;

        if(textTransform.anchoredPosition.y == 0)
        {
            HighscoreTable.gameObject.SetActive(true);

            if (Bloom)
                picksongmusicScriptBloom.BloomPlay = true;

            if (ATG)
                picksongmusicScriptBloom.ATGPlay = true;

        }
        else
        {
            HighscoreTable.gameObject.SetActive(false);
            if (Bloom)
                picksongmusicScriptATG.BloomPlay = false;

            if (ATG)
                picksongmusicScriptATG.ATGPlay = false;
        }
        //Debug.Log(TopText.anchoredPosition.y);
        //Debug.Log(BottomText.anchoredPosition.y);
    }
}