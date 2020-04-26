using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickLetterScript : MonoBehaviour
{
    private ArcadeButton key;
    public int playerId;

    public RectTransform objectRectTransform;
    public bool FirstLetter;
    public bool SecondLetter;
    public bool ThirdLetter;
    public int WhatLetter;
    public int LetterPlace;
    bool PlaceHolder;
    public GameObject UIScript;
    UISizeScript uiScript;
    // Start is called before the first frame update
    void Start()
    {
        uiScript = UIScript.GetComponent<UISizeScript>();
        WhatLetter = 1;
        LetterPlace = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (uiScript.TextIncreaseHS >= 1.15)
        {
            if (Arcade.GetKeyDown(playerId, ArcadeButton.Right) && WhatLetter < 3)
            {
                WhatLetter += 1;
            }
            if (Arcade.GetKeyDown(playerId, ArcadeButton.Left) && WhatLetter > 1)
            {
                WhatLetter -= 1;
            }
        }

        if(WhatLetter == 1 && FirstLetter)
        {
            

            if(Arcade.GetKeyDown(playerId, ArcadeButton.Down) && LetterPlace < 35)
            {
                LetterPlace += 1;
            }
            if(Arcade.GetKeyDown(playerId, ArcadeButton.Up) && LetterPlace > 0)
            {
                LetterPlace -= 1;
            }

        }

        if (WhatLetter == 2 && SecondLetter)
        {


            if (Arcade.GetKeyDown(playerId, ArcadeButton.Down) && LetterPlace < 35)
            {
                LetterPlace += 1;
            }
            if (Arcade.GetKeyDown(playerId, ArcadeButton.Up) && LetterPlace > 0)
            {
                LetterPlace -= 1;
            }

        }

        if (WhatLetter == 3 && ThirdLetter)
        {


            if (Arcade.GetKeyDown(playerId, ArcadeButton.Down) && LetterPlace < 35)
            {
                LetterPlace += 1;
            }
            if (Arcade.GetKeyDown(playerId, ArcadeButton.Up) && LetterPlace > 0)
            {
                LetterPlace -= 1;
            }

        }

    }
}
