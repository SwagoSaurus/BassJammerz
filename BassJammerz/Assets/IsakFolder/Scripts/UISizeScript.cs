using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISizeScript : MonoBehaviour
{

    public Camera Camera;
    //public GameObject RawImage1;
    public RectTransform objectRectTransform;
    public GameObject Playerscript;
    HowManyPlayersScript playerscript;
    public GameObject Winscript;
    WinScript winscript;
    public GameObject MeterScript;
    MeterScript meterScript;
    public GameObject RestartTextScript;
    RestartTextScript restarttextScript;
    public GameObject SceneManagerScript;
    SceneManagerScript scenemanagerScript;
    float TextIncrease;
    float TextIncreaseAll;
    public bool SecondaryText;
    public bool ThirdText;
    public bool DeathText;
    public bool WinText;

    float hej;
    //public Texture2D RawImage2;
    // Start is called before the first frame update
    void Start()
    {
        playerscript = Playerscript.GetComponent<HowManyPlayersScript>();
        meterScript = MeterScript.GetComponent<MeterScript>();
        restarttextScript = RestartTextScript.GetComponent<RestartTextScript>();
        scenemanagerScript = SceneManagerScript.GetComponent<SceneManagerScript>();

        if (playerscript.Player1Playing == true && playerscript.Player2Playing == true)
        {
            ChangeTextSize(0.5f);
            restarttextScript.TextSize(0.9f);
        }
        else if (playerscript.Player1Playing == true && playerscript.Player3Playing == true)
        {
            ChangeTextSize(0.5f);
            restarttextScript.TextSize(0.5f);
        }
        else if (playerscript.Player1Playing == true && playerscript.Player4Playing == true)
        {
            ChangeTextSize(0.5f);
            restarttextScript.TextSize(0.5f);
        }
        else if (playerscript.Player2Playing == true && playerscript.Player3Playing == true)
        {
            ChangeTextSize(0.5f);
            restarttextScript.TextSize(0.5f);
        }
        else if (playerscript.Player2Playing == true && playerscript.Player4Playing == true)
        {
            ChangeTextSize(0.5f);
            restarttextScript.TextSize(0.5f);
        }
        else if (playerscript.Player3Playing == true && playerscript.Player4Playing == true)
        {
            ChangeTextSize(0.5f);
            restarttextScript.TextSize(0.5f);
        }
        else
        {
            ChangeTextSize(1);
            restarttextScript.TextSize(1);
        }

       

        objectRectTransform.localScale = new Vector3(0, 0, 0);
        TextIncrease = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //hej = hej + 10 ;
        //if (playerscript.Player1Playing == true)
        //    print("Hej");
        if( meterScript.Won == true && WinText == true)
        {
            TextIncrease += 0.01f;
            if (TextIncrease <= 1 && SecondaryText == false)
            {
                objectRectTransform.localScale = new Vector3(TextIncrease, TextIncrease, TextIncrease);
            }
            else if (TextIncrease <= 2 && TextIncrease >= 1 & SecondaryText == true)
            {
                objectRectTransform.localScale = new Vector3(TextIncrease - 1, TextIncrease - 1, TextIncrease - 1);
            }
        }
        if(meterScript.Lost == true && DeathText == true)
        {
            TextIncrease += 0.02f;
            if (TextIncrease <= 1 && SecondaryText == false && ThirdText == false)
            {
                objectRectTransform.localScale = new Vector3(TextIncrease, TextIncrease, TextIncrease);
            }
            else if (TextIncrease <= 2 && TextIncrease >= 1 && SecondaryText == true && ThirdText == false)
            {
                objectRectTransform.localScale = new Vector3(TextIncrease - 1, TextIncrease - 1, TextIncrease - 1);
            }
            
        }
        if(scenemanagerScript.Player1Dead == true && scenemanagerScript.Player2Dead == true && scenemanagerScript.Player3Dead == true && scenemanagerScript.Player4Dead == true && DeathText == true && ThirdText == true)
        {
            TextIncreaseAll += 0.02f;
            if (TextIncreaseAll <= 3 && TextIncreaseAll >=2 && SecondaryText == false && ThirdText == true)
            {
                objectRectTransform.localScale = new Vector3(TextIncreaseAll-2, TextIncreaseAll-2, TextIncreaseAll-2);
            }
        }
    }

    public void ChangeTextSize(float size)
    {
        objectRectTransform.sizeDelta = new Vector2(objectRectTransform.sizeDelta.x * size, objectRectTransform.sizeDelta.y * size);
        objectRectTransform.anchoredPosition = new Vector2(objectRectTransform.anchoredPosition.x, objectRectTransform.anchoredPosition.y * size);
    }
}
