using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RestartTextScript : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public GameObject SceneManagerScript;
    SceneManagerScript scenemanagerscript;
    
    // Start is called before the first frame update
    void Start()
    {
        scenemanagerscript = SceneManagerScript.GetComponent<SceneManagerScript>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Press " + scenemanagerscript.RestartKey + " to restart the song";
        
    }
    public void TextSize(float size)
    {
        txt.fontSize = txt.fontSize * size;
    }
}
