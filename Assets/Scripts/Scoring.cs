using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    private float Score = 0;

    private float ScoreMultiplicator = 0;
    public float IntervalMultiplicator = 0.5f;
    public Text ScoreText;

        void Start() {
            ScoreText.text = "Score : " + Score;
        }

        public void AddZombiePoints() {
                Score += 10 * ScoreMultiplicator;

            }

    // Update is called once per frame
    void Update()
    {
        ScoreMultiplicator += IntervalMultiplicator;
        Score += Time.deltaTime * ScoreMultiplicator;
        ScoreText.text = "Score : " +  (int)Score;
    }
}
