using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HögtalarScript : MonoBehaviour
{
    //HENRIC SCRIPT :)
    // Start is called before the first frame update
    [SerializeField]
    private Transform TargetPos;
    [SerializeField]
    private Vector3 TargetScale;
    [SerializeField, Range(0, 1)]
    private float Xvalue;

    [SerializeField]
    private AnimationCurve myCurve;

    [SerializeField, Range(0, 1)]
    private float Yvalue;

    private Vector3 StartPos;
    private Quaternion StartRot;
    private Vector3 StartScale;

    private Vector3 FollowPos;
    private Vector3 FollowRot;
    private Vector3 FollowScale;

    //[RequireComponent(typeof(Loudness))]
    [SerializeField]
    private ParticleSystem _ParticleSystem;
    private ParticleSystem.EmissionModule EmmosionModulea;
    private Loudness LoudnessScript;
    private float loudness;
    [SerializeField]
    int BandNmbr;

    [SerializeField]
    float Scale;

    [SerializeField]
    float DivScale;

    void Start()
    {
        StartPos = transform.position;
        StartRot = transform.rotation;
        StartScale = transform.localScale;
        LoudnessScript = GetComponent<Loudness>();
        //EmmosionModulea = _ParticleSystem.emission;
    }

    // Update is called once per frame
    void Update()
    {
        //Stoppar in XVärdet och får ett Y Värde
        //loudness = LoudnessScript.clipLoudness;
        //if (loudness <= 0.15f)
        //{
        //    loudness = 0;
        //}
        loudness = (((LoudnessScript._BandBuffer[BandNmbr] + LoudnessScript._BandBuffer[0]) / 2) - Scale) / DivScale;
        Xvalue = Mathf.Lerp(Xvalue, loudness * 3, 0.05f);

        Yvalue = myCurve.Evaluate(Xvalue);
        //EmmosionModulea.rateOverTime = (LoudnessScript.clipLoudness * LoudnessScript.audioSource.volume) * 50;

        //Roterar Nuvarande Positionen till målets rotation
        //T = Y värdet för att får "50%" utav målets position t.ex 
        transform.rotation = Quaternion.Slerp(StartRot, TargetPos.rotation, Yvalue);

        FollowPos = (StartPos + ((TargetPos.position - StartPos) * Yvalue));
        FollowScale = (StartScale + ((TargetScale - StartScale) * Yvalue));
        transform.position = FollowPos;
        transform.localScale = FollowScale;


    }
}
