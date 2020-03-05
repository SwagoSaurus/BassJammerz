using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StreakScript : MonoBehaviour
{

    public GameObject ScoreScript;
    ScoreScript Script;
    [SerializeField]
    float Streak;
    private TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
        Script = ScoreScript.GetComponent<ScoreScript>();
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Streak = Script.Streak;

        textMesh.text = Streak.ToString();
    }
}
