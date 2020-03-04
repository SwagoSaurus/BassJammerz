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
    ScoreScript Script;
    float score = 30;
    // Start is called before the first frame update
    void Start()
    {
        Script = ScoreScript.GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key) && active)
        {

            Script.IncreaseScore(score);
            Destroy(note);
        }
        DistanceChild = note.transform.GetChild(0).transform;
    }

    private void OnTriggerEnter(Collider col)
    {
        active = true;
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
