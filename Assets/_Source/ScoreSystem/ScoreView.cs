using System;
using System.Collections;
using System.Collections.Generic;
using ScoreSystem;
using TMPro;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    private Score _score;
    public void Construct(Score score)
    {
        _score = score;
    }
    private void OnEnable()
    {
        _score.OnScoreChanged += RefreshText;
    }
    private void RefreshText(int newScore)
    {
        scoreText.text = $"Score: {newScore}";
    }

    private void OnDisable()
    {
        _score.OnScoreChanged -= RefreshText;
    }
}
