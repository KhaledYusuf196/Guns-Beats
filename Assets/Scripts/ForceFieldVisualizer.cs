using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceFieldVisualizer : MonoBehaviour
{
    float[] audioData;
    Material material;

    void Start()
    {
        material = GetComponent<MeshRenderer>().sharedMaterial;
    }

    void Update()
    {
        audioData = AudioVisualiser.getAudioData();
        material.SetFloat("_Border", 1 - audioData[0]);
        material.SetFloat("_BorderX", 0.25f - audioData[1]);
        material.SetFloat("_BorderY", 0.25f - audioData[2]);

    }
}
