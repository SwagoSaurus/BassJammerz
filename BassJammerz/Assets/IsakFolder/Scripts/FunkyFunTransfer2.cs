﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FunkyFunTransfer2 : MonoBehaviour
{
    static public float NewScoreValue;
    static public float NewScoreChecker;
    public float NewScore;
    public string NewWinName;
    static public string NewName;
    static public string NewNameChecker;
    public string NewHighname;
    public float NewHighscore;
    string sceneName;
    public float CurrentScore;
    public bool Restart;

    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        if (sceneName == "FunkyFun")
        {
            NewScoreValue = 0;
            NewName = "AAA";
            NewNameChecker = "ÅÅÅ";
            NewScoreValue = -100;
            Restart = false;
        }
        if (sceneName == "ChooseSongScene")
        {
            if (NewScoreChecker == NewScoreValue && NewNameChecker == NewName)
            {
                NewScoreValue = 0;
                NewName = "AAA";
            }

            NewHighscore = NewScoreValue;
            NewHighname = NewName;
            NewScoreChecker = NewScoreValue;
            NewNameChecker = NewName;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneName == "FunkyFun")
        {
            NewScoreValue = NewScore;
            NewName = NewWinName;
        }



        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log(NewScoreValue);
        }
    }
}