using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public float Score;
    public float Combo = 1;
    public float ComboCounter = 0;
    public float Streak;
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
        if (ComboCounter == 8 && Combo < 4)
        {
            Combo += 1;
            ComboCounter = 0;
        }

        textMesh.text = Score.ToString();
    }
    public void IncreaseScore(float ScoreVoid, float Combo)
    {
        AddScore = ScoreVoid;
        Score += AddScore * Combo;
    }
    public void ResetCombo()
    {
        Combo = 1;
        ComboCounter = 0;
    }
    public void ResetStreak()
    {
        Streak = 0;
    }
    public void IncreaseStreak()
    {
        Streak += 1;
    }
    

    
}
