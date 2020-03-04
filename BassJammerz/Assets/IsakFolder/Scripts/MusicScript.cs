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

    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Play == TimeToPlay)
        audioData.Play(0);
        Play++;
    }
}
