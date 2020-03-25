using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickSongScript : MonoBehaviour
{
    public KeyCode Up;
    public KeyCode Down;
    public KeyCode Play;
    public bool Bloom;
    public bool Test1;
    public bool Test2;
    public string SceneName;
    public RectTransform textTransform;
    public RectTransform TopText;
    public RectTransform BottomText;
    Vector3 earlyPos;
    Vector3 latePos;
    Vector3 startPos;
    Vector3 PressPos;
    Vector3 PressEndPos;
    public GameObject HighscoreTable;
    HighscoreTableScript highscoretableScript;
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


        startPos = textTransform.anchoredPosition;
        earlyPos = startPos;
        latePos = startPos;
        PressPos = startPos;
        PressEndPos = startPos;
    }

    // Update is called once per frame
    void Update()
    {


        //if (TopText.anchoredPosition.y > 0)
        //{
            if (Input.GetKeyDown(Up))
            {
                PressPos = textTransform.anchoredPosition;
                PressEndPos = new Vector3(PressPos.x, PressPos.y - 150, PressPos.z);
            }
        //}
        //if (BottomText.anchoredPosition.y < 0)
        //{
            if (Input.GetKeyDown(Down))
            {
                PressPos = textTransform.anchoredPosition;
                PressEndPos = new Vector3(PressPos.x, PressPos.y + 150, PressPos.z);
            }
        //}
        

        if (textTransform.anchoredPosition.y == 0)
        {
            if (Input.GetKeyDown(Play))
            {
                SceneManager.LoadScene(SceneName);
            }
        }


        earlyPos = new Vector3(startPos.x, PressPos.y, startPos.z);
        latePos = new Vector3(startPos.x, PressEndPos.y, startPos.z);
        //textTransform.anchoredPosition = Vector3.Lerp(earlyPos, latePos, 1 * Time.deltaTime);

        
        textTransform.anchoredPosition = latePos;

        if(textTransform.anchoredPosition.y == 0)
        {
            HighscoreTable.gameObject.SetActive(true);
        }
        else
        {
            HighscoreTable.gameObject.SetActive(false);
        }
        //Debug.Log(TopText.anchoredPosition.y);
        //Debug.Log(BottomText.anchoredPosition.y);
    }
}
