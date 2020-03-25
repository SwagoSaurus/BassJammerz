using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickSongMusicScript : MonoBehaviour
{
    public AudioSource Bloom;
    public AudioSource ATG;
    public bool BloomPlay;
    public bool ATGPlay;

    void Start()
    {
        Bloom = GetComponent<AudioSource>();
        ATG = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (ATGPlay)
        {
            //ATG.timeSamples = 120;
            ATG.Play();
        }
        else if(!ATGPlay)
        {
            ATG.Stop();
        }

        if (BloomPlay)
        {
           // Bloom.timeSamples = 120;
            Bloom.Play();
        }
        else if(!BloomPlay)
        {
            Bloom.Stop();
        }
    }
}