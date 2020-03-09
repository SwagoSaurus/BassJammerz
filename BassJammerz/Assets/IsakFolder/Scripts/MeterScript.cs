using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeterScript : MonoBehaviour
{
    public GameObject ScoreScript;
    ScoreScript Script;
    public float RockMeter;
    public bool Invincible = false;
    public GameObject needle;
    Vector3 earlyPos;
    Vector3 latePos;
    Vector3 startPos;
    public bool Won = false;
    public bool Lost = false;
    
   
    // Start is called before the first frame update
    void Start()
    {
        Script = ScoreScript.GetComponent<ScoreScript>();
        RockMeter = 0;
        startPos = needle.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (RockMeter < -45)
            RockMeter = -45;
       
        earlyPos = new Vector3(needle.transform.localPosition.x, needle.transform.localPosition.y, needle.transform.localPosition.z);
        latePos = new Vector3(RockMeter - 5, startPos.y, startPos.z);
        
            
        needle.transform.localPosition = Vector3.Lerp(earlyPos, latePos, 20f * Time.deltaTime);
        
    }

    public void IncreaseRockMeter()
    {
        if (Invincible == false)
        {
            if (RockMeter < 45)
            {
                RockMeter += 2;
            }
        }
    }
    public void DecreaseRockMeter()
    {
        if (Invincible == false)
        {
            if (RockMeter > -45)
            {
                RockMeter -= 4;
            }
            if (RockMeter <= -45)
            {
                Lose();
            }
        }
    }
    public void Lose()
    {
        Lost = true;
    }

    public void Win()
    {
        Won = true;
    }
}
