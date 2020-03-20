using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class BeatSpawner : MonoBehaviour
{
    public LevelConfigSO level;
    float offsetTime = 0;
    int currentBeat = 0;
    public GameObject beat;
    public GameObject ActiveBeats;
    [SerializeField] PlayableDirector music;

    // Start is called before the first frame update
    public void StartBeat()
    {
        offsetTime = Time.time;
        gameObject.SetActive(true);
        currentBeat = 0;
    }

    // Update is called once per frame
    void Update()
    {
        print(music.time);
        if (music.time >= level.BeatTimes[currentBeat] * 60 / level.BeatRate + level.Offset)
        {
            SpawnBeat(level.BeatPositions[currentBeat]);
            currentBeat++;
            if (currentBeat >= level.BeatTimes.Length)
            {
                gameObject.SetActive(false);
            }
        }
    }

    void SpawnBeat(Vector3 position)
    {
        GameObject spawnedBeat = Instantiate(beat);
        spawnedBeat.transform.position = position;
        spawnedBeat.transform.parent = ActiveBeats.transform;
    }
}
