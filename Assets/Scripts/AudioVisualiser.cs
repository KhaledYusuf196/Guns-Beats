using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioVisualiser : MonoBehaviour
{
    static float[] audioSamples = new float[64];
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.GetSpectrumData(audioSamples, 0, FFTWindow.Blackman);
    }

    public static float[] getAudioData()
    {
        float[] audioVis = new float[3];
        for(int i = 0; i < 3; i++)
        {
            int j = i * 3;
            audioVis[i] = audioSamples[j] + audioSamples[j + 1] + audioSamples[j + 2];
            audioVis[i] /= 3;
        }
        return audioVis;
    }
}
