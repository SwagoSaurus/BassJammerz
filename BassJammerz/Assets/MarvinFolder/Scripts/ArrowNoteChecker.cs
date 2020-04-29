using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowNoteChecker : MonoBehaviour
{
	private ArcadeButton key;
	public int playerId;
	GameObject arrownote;
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

	Vector3 Childpos;
	Vector3 Checkpos;
	
	void Start()
    {
		Script = ScoreScript.GetComponent<ScoreScript>();
		meterScript = MeterScript.GetComponent<MeterScript>();
	}

    
    void Update()
    {
		if (CreateMode)
		{
			meterScript.Invincible = true;
			if (Arcade.GetKeyDown(playerId, key))
			{
				Instantiate(N, transform.position, Quaternion.identity);
			}
		}

		else if (!meterScript.Won && !meterScript.Lost)
		{
			if (Arcade.GetKeyDown(playerId, key) && active && !meterScript.Invincible)
			{
				Childpos = new Vector3(transform.position.x, 0.64f, transform.position.z);
				Checkpos = new Vector3(DistanceChild.position.x, 0.64f, DistanceChild.position.z);
				distance = Vector3.Distance(Childpos, Checkpos);


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
				Destroy(arrownote);
				active = false;

			}
			else if (Arcade.GetKeyDown(playerId, ArcadeButton.Right) || Arcade.GetKeyDown(playerId, ArcadeButton.Down) || Arcade.GetKeyDown(playerId, ArcadeButton.Left) || Arcade.GetKeyDown(playerId, ArcadeButton.Right) && !active)
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

		if (col.gameObject.tag == "LeftNote")
		{
			arrownote = col.gameObject;
			key = ArcadeButton.Left;

		}
		if (col.gameObject.tag == "RightNote")
		{
			arrownote = col.gameObject;
			key = ArcadeButton.Right;

		}
		if (col.gameObject.tag == "UpNote")
		{
			arrownote = col.gameObject;
			key = ArcadeButton.Up;

		}
		if (col.gameObject.tag == "DownNote")
		{
			arrownote = col.gameObject;
			key = ArcadeButton.Down;

		}
	}

	private void OnTriggerExit(Collider col)
	{
		active = false;
	}
}
