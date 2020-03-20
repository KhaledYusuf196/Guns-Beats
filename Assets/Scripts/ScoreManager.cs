using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    static int Score;
    [SerializeField] Text ScoreText;

    private void Start()
    {
        Score = 0;
    }

    public void IncrementScore()
    {
        //TODO : implement score increment
        Score++;
        ScoreText.text = Score.ToString();
    }

}
