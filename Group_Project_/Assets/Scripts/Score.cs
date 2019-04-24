﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private float score = 0.0f;
    public Text textScore;
    public int levelDifficulty = 1;
    private int levelDifficultyMax = 10;
    private int scoreToNextLevel = 10;

    // Update is called once per frame
    void Update()
    {
        if(score >= scoreToNextLevel)
        {
            LevelUp();
        }
        score += Time.deltaTime;
        textScore.text = ((int)score).ToString();
    }

    private void LevelUp()
    {
        if(levelDifficulty == levelDifficultyMax)
        {
            return;
        }
        scoreToNextLevel *= 2;
        levelDifficulty++;
    }
}
