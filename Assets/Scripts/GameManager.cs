using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GameManager : MonoBehaviour
{
    [SerializeField] BeatSpawner beatSpawner;
    [SerializeField] PlayableDirector playBackDirector;
    // Start is called before the first frame update
    void Start()
    {
        playBackDirector.Play();
        beatSpawner.StartBeat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
