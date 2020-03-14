using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatGetter : MonoBehaviour
{
    List<float> beats;
    public LevelConfigSO level;

    private void Start()
    {
        beats = new List<float>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            beats.Add(Time.time);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            level.BeatTimes = beats.ToArray();
        }
    }
}
