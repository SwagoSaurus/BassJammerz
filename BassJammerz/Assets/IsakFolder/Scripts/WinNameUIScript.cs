using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinNameUIScript : MonoBehaviour
{
    public Camera Camera;
    public RectTransform objectRectTransform;
    public GameObject Playerscript;
    HowManyPlayersScript playerscript;

    // Start is called before the first frame update
    void Start()
    {
        playerscript = Playerscript.GetComponent<HowManyPlayersScript>();

        if (playerscript.Player1Playing == true && playerscript.Player2Playing == true)
        {
            ChangeHighscoreTextSize(0.5f);
            
        }
        else if (playerscript.Player1Playing == true && playerscript.Player3Playing == true)
        {
            ChangeHighscoreTextSize(0.5f);
            
        }
        else if (playerscript.Player1Playing == true && playerscript.Player4Playing == true)
        {
            ChangeHighscoreTextSize(0.5f);
            
        }
        else if (playerscript.Player2Playing == true && playerscript.Player3Playing == true)
        {
            ChangeHighscoreTextSize(0.5f);
            
        }
        else if (playerscript.Player2Playing == true && playerscript.Player4Playing == true)
        {
            ChangeHighscoreTextSize(0.5f);
            
        }
        else if (playerscript.Player3Playing == true && playerscript.Player4Playing == true)
        {
            ChangeHighscoreTextSize(0.5f);
            
        }
        else
        {
            ChangeHighscoreTextSize(1);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeHighscoreTextSize(float size)
    {
        objectRectTransform.sizeDelta = new Vector2(objectRectTransform.sizeDelta.x * size, objectRectTransform.sizeDelta.y * size);
        objectRectTransform.anchoredPosition = new Vector2(objectRectTransform.anchoredPosition.x, objectRectTransform.anchoredPosition.y * size);
    }
}
