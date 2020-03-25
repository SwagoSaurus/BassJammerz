using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    AudioSource audioData;
    [SerializeField]
    int Play = 0;
    [SerializeField]
    int TimeToPlay;
    public GameObject SceneManagerScript;
    SceneManagerScript scenemanagerScript;
   

    void Start()
    {
        audioData = GetComponent<AudioSource>();
        scenemanagerScript = SceneManagerScript.GetComponent<SceneManagerScript>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if(Play == TimeToPlay)
        audioData.Play(0);
        Play++;

        audioData.pitch = scenemanagerScript.SlowMo;
    }
}
