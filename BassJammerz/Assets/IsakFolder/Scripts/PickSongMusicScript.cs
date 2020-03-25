using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickSongMusicScript : MonoBehaviour
{
    public AudioClip Song;
    public bool BloomPlay;
    public bool ATGPlay;
    //public GameObject OtherSong1;
    //PickSongMusicScript otherSong1;
    float SongPlayCount;
    float Volume;
    float VolumeIncrease;
    float VolumeEndTime;

    private AudioSource source;

    void Start()
    {
        //otherSong1 = OtherSong1.GetComponent<PickSongMusicScript>();
        source = GetComponent<AudioSource>();
        source.clip = Song;
        source.playOnAwake = false;
        VolumeIncrease = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (ATGPlay)
        {
            PlaySoundInterval(78f, 128f, 0);
        }
        if (BloomPlay)
        {
            PlaySoundInterval(87f, 137f, 0);
           
            //PlaySoundInterval(5220, 8160);
        }

        if(!ATGPlay && !BloomPlay)
        {
            source.Stop();
            //SongPlayCount = 0;
            VolumeIncrease = 0;
            VolumeEndTime = 0;
        }
    }

    void PlaySoundInterval(float fromSeconds, float toSeconds, float BeginVolume)
    {
        if (!source.isPlaying)
        {
            Volume = BeginVolume;
            VolumeIncrease = 0;
            VolumeEndTime = 0;
            source.time = fromSeconds;
            source.Play();
            source.SetScheduledEndTime(AudioSettings.dspTime + (toSeconds - fromSeconds));
        }

        VolumeEndTime++;

        if (Volume < 0.5 && VolumeEndTime < 2520)
        {
            VolumeIncrease++;
            Volume = VolumeIncrease * 0.001f;
        }

        if(VolumeEndTime >= 11500)
        {
            VolumeIncrease--;
            Volume = VolumeIncrease * 0.001f;
        }

        source.volume = Volume;
    }
}