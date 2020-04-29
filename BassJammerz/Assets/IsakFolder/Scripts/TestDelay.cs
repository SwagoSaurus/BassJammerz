using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDelay : MonoBehaviour
{
    AudioSource song;
    // Start is called before the first frame update
    void Start()
    {
        song = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        song.PlayDelayed(1000f);
    }
}
