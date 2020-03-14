using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatTester : MonoBehaviour
{
    public LevelConfigSO level;
    int currentBeat = 0;
    AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Vector3[] beatPostions = new Vector3[level.BeatTimes.Length];
        for(int i = 0; i < beatPostions.Length; i++)
        {
            beatPostions[i] = new Vector3(Random.Range(-5, 5), Random.Range(1, 5), 100);
        }
        level.BeatPositions = beatPostions;
    }
    void Update()
    {

        if (level.BeatTimes[currentBeat] * 60 / level.BeatRate + level.Offset< Time.time)
        {
            currentBeat++;
            audioSource.Play();
            print(Time.time);
        }
    }
}
