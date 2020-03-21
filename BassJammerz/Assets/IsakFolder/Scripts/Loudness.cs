using UnityEngine;
[RequireComponent(typeof(AudioSource))]
//HENRIC SCRIPT
public class Loudness : MonoBehaviour
{

    public AudioSource audioSource;
    public float updateStep = 0.1f;
    public int sampleDataLength = 1024;

    private float currentUpdateTime = 0f;

    public float clipLoudness;
    private float[] clipSampleData;
    [SerializeField]
    private float[] _Samples = new float[512];
    public float[] _FreqBand = new float[8];
    public float[] _BandBuffer = new float[8];
    private float[] _BufferDecrease = new float[8];
    // Use this for initialization
    void Awake()
    {

        if (!audioSource)
        {
            Debug.LogError(GetType() + ".Awake: there was no audioSource set.");
        }
        clipSampleData = new float[sampleDataLength];

    }

    // Update is called once per frame
    void Update()
    {

        currentUpdateTime += Time.deltaTime;
        if (currentUpdateTime >= updateStep)
        {
            currentUpdateTime = 0f;
            audioSource.clip.GetData(clipSampleData, audioSource.timeSamples); //I read 1024 samples, which is about 80 ms on a 44khz stereo clip, beginning at the current sample position of the clip.
            clipLoudness = 0f;
            foreach (var sample in clipSampleData)
            {
                clipLoudness += Mathf.Abs(sample);
            }
            clipLoudness /= sampleDataLength; //clipLoudness is what you are looking for
        }


        GetSpectrumAudioSource();
        MakeFreqband();
        BandBuffer();
    }
    void GetSpectrumAudioSource()
    {
        audioSource.GetSpectrumData(_Samples, 0, FFTWindow.Blackman);

    }
    void MakeFreqband()
    {
        //22050 hz / 512 Samples = 43hz per sample
        int count = 0;
        for (int i = 0; i < 8; i++)
        {
            float avarage = 0;
            int SampleCount = (int)Mathf.Pow(2, 1) * 2;

            if (i == 7)
            {
                SampleCount += 2;
            }

            for (int j = 0; j < SampleCount; j++)
            {
                avarage += _Samples[count] * count + 1;
                ++count;
            }
            avarage /= count;
            _FreqBand[i] = avarage * 10;
        }

    }
    void BandBuffer()
    {

        for (int g = 0; g < 8; g++)
        {
            if (_FreqBand[g] > _BandBuffer[g])
            {
                _BandBuffer[g] = _FreqBand[g];
                _BufferDecrease[g] = 0.005f;
            }
            if (_FreqBand[g] < _BandBuffer[g])
            {
                _BandBuffer[g] -= _BufferDecrease[g];
                _BufferDecrease[g] *= 1.2f;
            }
        }
    }

}