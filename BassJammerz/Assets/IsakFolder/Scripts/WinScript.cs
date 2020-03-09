using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
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
        if(meterScript.Won == true)
        {

        }

    }

}
