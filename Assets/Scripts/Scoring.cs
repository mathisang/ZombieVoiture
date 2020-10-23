using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    private float Score = 0;

    private float ScoreMultiplicator = 0;
    public float IntervalMultiplicator = 0.5f;
    //private float ScorePoints = ScoreMultiplicator * Time.deltaTime;
    public Text ScoreText;

        void Start() {
            ScoreText.text = "Score : " + Score;
        }

    // Update is called once per frame
    void Update()
    {
        ScoreMultiplicator += IntervalMultiplicator;
        Score += Time.deltaTime * ScoreMultiplicator;
        ScoreText.text = "Score : " +  (int)Score;
    }
}
