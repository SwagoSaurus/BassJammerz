using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public float Score;
    public float Combo = 1;
    public float AddScore;
    private TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
        textMesh.text = Score.ToString();
    }
    public void IncreaseScore(float ScoreVoid)
    {
        AddScore = ScoreVoid;
        Score += AddScore * Combo;

    }
}
