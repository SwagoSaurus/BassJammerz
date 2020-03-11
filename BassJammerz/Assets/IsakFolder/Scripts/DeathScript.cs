using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject ScoreScript;
    public GameObject MeterScript;
    ScoreScript Script;
    MeterScript meterScript;

    // Start is called before the first frame update
    void Start()
    {
        Script = ScoreScript.GetComponent<ScoreScript>();
        meterScript = MeterScript.GetComponent<MeterScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
       

        if (col.gameObject.tag == "Note")
        {
            Script.ResetCombo();
            Script.ResetStreak();
            meterScript.DecreaseRockMeter();
            Destroy(col.gameObject);
        }

        else if(col.gameObject.tag == "WinNote")
        {
            meterScript.Win();
        }
    }
}
