﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowNoteChecker : MonoBehaviour
{
	private KeyCode key;
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
			if (Input.GetKeyDown(key))
			{
				Instantiate(N, transform.position, Quaternion.identity);
			}
		}

		else if (meterScript.Won == false && meterScript.Lost == false)
		{
			if (Input.GetKeyDown(key) && active && meterScript.Invincible == false)
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
			else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) && !active)
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
			key = KeyCode.LeftArrow;

		}
		if (col.gameObject.tag == "RightNote")
		{
			arrownote = col.gameObject;
			key = KeyCode.RightArrow;

		}
		if (col.gameObject.tag == "UpNote")
		{
			arrownote = col.gameObject;
			key = KeyCode.UpArrow;

		}
		if (col.gameObject.tag == "DownNote")
		{
			arrownote = col.gameObject;
			key = KeyCode.DownArrow;

		}
	}

	private void OnTriggerExit(Collider col)
	{
		active = false;
	}
}