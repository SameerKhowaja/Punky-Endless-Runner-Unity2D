using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoringWhenEnemyCollide : MonoBehaviour
{
    public Text score;
    int scoreCount;
    int highScore;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("highscore22", 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            scoreCount += 1;
            score.text = scoreCount.ToString();

            if(highScore < scoreCount)
            {
                highScore = scoreCount;
                PlayerPrefs.SetInt("highscore22", highScore);
            }
        }
    }

}
