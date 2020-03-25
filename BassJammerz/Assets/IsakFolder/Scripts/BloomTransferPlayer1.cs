﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BloomTransferPlayer1 : MonoBehaviour
{
    static public float NewScoreValue;
    public float NewScore;
    static public string NewName;
    public string NewHighname;
    public float NewHighscore;
    string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        if (sceneName == "Bloom")
        {
            NewScoreValue = 0;
            NewName = "AAA";
        }
        if(sceneName == "ChooseSongScene")
        {
            NewHighscore = NewScoreValue;
            NewHighname = NewName;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneName == "Bloom")
        {
            NewScoreValue = NewScore;
        }

        

        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log(NewScoreValue);
        }
    }
}