using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceFieldVisualizer : MonoBehaviour
{
    float[] audioData;
    Material material;
    [SerializeField] float CornerBorderOffset = 0.5f;
    [SerializeField] float SideBorderOffset = 0.5f;
    [SerializeField] float IntensityOffset = 0.5f;
    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    void Update()
    {
        audioData = AudioVisualiser.getAudioData();
        material.SetFloat("_Intensity", IntensityOffset + audioData[1]);
        material.SetFloat("_Border", CornerBorderOffset + audioData[0]);
        material.SetFloat("_BorderX", SideBorderOffset + audioData[2]);
        material.SetFloat("_BorderY", SideBorderOffset + audioData[2]);

    }
}
