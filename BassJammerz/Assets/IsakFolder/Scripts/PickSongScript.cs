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
    public bool ATG;
    public bool FunkyFun;
    //public bool Test2;
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
    public GameObject PickSongMusicScript;
    PickSongMusicScript picksongmusicScript;

    
    // Start is called before the first frame update
    void Awake()
    {
        
        if(Bloom == true)
        {
            SceneName = "Bloom";
        }
        else if(ATG == true)
        {
            SceneName = "ATG";
        }
        //else if(Test2 == true)
        //{
        //    SceneName = "Test2";
        //}

    }
    void Start()
    {
        highscoretableScript = HighscoreTable.GetComponent<HighscoreTableScript>();
        picksongmusicScript = PickSongMusicScript.GetComponent<PickSongMusicScript>();
        

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
            if (Input.GetKeyDown(Down))
            {
                PositionNr += 1;
                PressPos = textTransform.anchoredPosition;
                //PressEndPos = new Vector3(PressPos.x, PressPos.y - 150, PressPos.z);
                lerpTime = 0;
                
            }
            }
            if (PositionNr > -NumberOfSongsUnderMid)
            {
            if (Input.GetKeyDown(Up))
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
                picksongmusicScript.BloomPlay = true;

            if (ATG)
                picksongmusicScript.ATGPlay = true;

            if (FunkyFun)
                picksongmusicScript.FunkyPlay = true;

        }
        else
        {
            HighscoreTable.gameObject.SetActive(false);
            if (Bloom)
                picksongmusicScript.BloomPlay = false;

            if (ATG)
                picksongmusicScript.ATGPlay = false;

            if (FunkyFun)
                picksongmusicScript.FunkyPlay = false;
        }
        //Debug.Log(TopText.anchoredPosition.y);
        //Debug.Log(BottomText.anchoredPosition.y);
    }
}
