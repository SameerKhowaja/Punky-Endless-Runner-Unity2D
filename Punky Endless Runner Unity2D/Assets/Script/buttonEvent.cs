using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonEvent : MonoBehaviour
{
    public Text HighScoreTXT;
    int score;
    private void Update()
    {
        score = PlayerPrefs.GetInt("highscore22", 0);
        HighScoreTXT.text = score.ToString();
    }

    public void PlayBTN()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
