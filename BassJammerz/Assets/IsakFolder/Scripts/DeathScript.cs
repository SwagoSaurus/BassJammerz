using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject ScoreScript;
    ScoreScript Script;

    // Start is called before the first frame update
    void Start()
    {
        Script = ScoreScript.GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
       

        if (col.gameObject.tag == "Note")
        {
            Script.Combo = 1; 
            Destroy(col.gameObject);
        }
    }
}
