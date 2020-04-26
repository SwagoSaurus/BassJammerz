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
    public GameObject WinName;
    WinNameScript winnameScript;
    public GameObject SameScript;
    UISizeScript sameScript;
    float TextIncrease;
    public float TextIncreaseHS;
    float TextIncreaseAll;
    public bool PrimaryText;
    public bool SecondaryText;
    public bool ThirdText;
    public bool DeathText;
    public bool WinText;
    public bool HighscoreText;
    public bool WinNameText;
    float HighscoreTimer;

    float hej;
    //public Texture2D RawImage2;
    // Start is called before the first frame update
    void Start()
    {
        playerscript = Playerscript.GetComponent<HowManyPlayersScript>();
        meterScript = MeterScript.GetComponent<MeterScript>();
        restarttextScript = RestartTextScript.GetComponent<RestartTextScript>();
        scenemanagerScript = SceneManagerScript.GetComponent<SceneManagerScript>();
        winnameScript = WinName.GetComponent<WinNameScript>();
        sameScript = SameScript.GetComponent<UISizeScript>();
        

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
        TextIncreaseHS = 0;
        HighscoreText = false;
        HighscoreTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //hej = hej + 10 ;
        //if (playerscript.Player1Playing == true)
        //    print("Hej");
        

        if( meterScript.Won == true && WinText == true)
        {
            if (HighscoreText == false && TextIncrease <=2)
            {
                TextIncrease += 0.01f;
            }
            else if (HighscoreText == true && HighscoreTimer >= 180)
            {
                TextIncrease -= 0.01f;
            }

            if (WinNameText == true)
            {
                if (HighscoreTimer >= 300)
                {
                    TextIncreaseHS += 0.01f;
                }
            }

            if (TextIncrease <= 1 && PrimaryText == true && TextIncrease >= 0)
            {
                objectRectTransform.localScale = new Vector3(TextIncrease, TextIncrease, TextIncrease);
            }
            else if (TextIncrease <= 2 && TextIncrease >= 1 && SecondaryText == true && TextIncrease >= 0)
            {
                objectRectTransform.localScale = new Vector3(TextIncrease - 1, TextIncrease - 1, TextIncrease - 1);
            }

            if(TextIncrease >= 1 && PrimaryText == true && winnameScript.NewNameHighscore == true)
            {
                HighscoreText = true;
            }
            else if (TextIncrease >= 2 && SecondaryText == true && winnameScript.NewNameHighscore == true)
            {
                HighscoreText = true;
            }
            else if (sameScript.TextIncrease >= 1 && sameScript.PrimaryText == true && winnameScript.NewNameHighscore == true)
            {
                HighscoreText = true;
            }

            if (TextIncreaseHS <= 1.2 && WinNameText == true && TextIncreaseHS >= 0)
            {
                objectRectTransform.localScale = new Vector3(TextIncreaseHS, TextIncreaseHS, TextIncreaseHS);
            }
            //En timer innan texten åker bort om man har highscore
            if(HighscoreText == true)
            {
                HighscoreTimer++;
            }
            
        }
        if (meterScript.Lost == true && DeathText == true)
        {
            TextIncrease += 0.02f;
            if (TextIncrease <= 1 && PrimaryText == true && ThirdText == false)
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
            if (TextIncreaseAll <= 3 && TextIncreaseAll >=2 && PrimaryText == false && SecondaryText == false && ThirdText == true)
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
