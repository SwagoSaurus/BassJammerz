using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RestartTextScript : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public TextMeshProUGUI txtOG;
    public GameObject SceneManagerScript;
    SceneManagerScript scenemanagerscript;
    public bool RestartText;
    public bool MainScreenText;
    
    // Start is called before the first frame update
    void Start()
    {
        scenemanagerscript = SceneManagerScript.GetComponent<SceneManagerScript>();
        txtOG = txt;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (RestartText)
        {
            txt.text = "PRESS " + scenemanagerscript.RestartKey + " TO RESTART THE SONG";
        }
        else if(MainScreenText)
        {
            txt.text = "PRESS " + scenemanagerscript.MainScreenKey + " TO GO BACK TO THE MAIN MENU";
        }
        
    }
    public void TextSize(float size)
    {
        txt.fontSize = txtOG.fontSize * size;
    }
}
