using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteChecker : MonoBehaviour
{
    public KeyCode key;
    GameObject note;
    [SerializeField]
    Transform DistanceChild;
    bool active = false;
    public GameObject ScoreScript;
    public GameObject MeterScript;
    ScoreScript Script;
    MeterScript meterScript;
    [SerializeField]
    float score;
    [SerializeField]
    float combo = 1;

    public bool CreateMode;
    public GameObject N;
   
    [SerializeField]
    float distance;
    // Start is called before the first frame update
    void Start()
    {
        Script = ScoreScript.GetComponent<ScoreScript>();
        meterScript = MeterScript.GetComponent<MeterScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CreateMode)
        {
            meterScript.Invincible = true;
            if(Input.GetKeyDown(key))
            {
                Instantiate(N, transform.position, Quaternion.identity);
            }
        }

        else
        {
            if (Input.GetKeyDown(key) && active && meterScript.Invincible == false)
            {
                distance = Vector3.Distance(DistanceChild.position, transform.position);

                if (distance >= 0.5)
                {
                    score = 30;
                }
                else if (distance < 0.5 && distance >= 0.25)
                {
                    score = 60;
                }
                else if (distance < 0.25)
                {
                    score = 90;
                }

                Script.ComboCounter += 1;
                combo = Script.Combo;
                Script.IncreaseScore(score, combo);
                Script.IncreaseStreak();
                meterScript.IncreaseRockMeter();
                Destroy(note);
                active = false;

            }
            else if(Input.GetKeyDown(key) && !active)
            {
                Script.ResetCombo();
                Script.ResetStreak();
                meterScript.DecreaseRockMeter();
            }
        }
       
        
    }

    private void OnTriggerEnter(Collider col)
    {
        active = true;
        DistanceChild = col.transform.GetChild(0).transform;
        
        if (col.gameObject.tag == "Note")
        {
            note = col.gameObject;
            
        }
    }

    private void OnTriggerExit(Collider col)
    {
        active = false;
    }

    
}
