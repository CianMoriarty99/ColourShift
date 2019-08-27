using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text highScore;

    public static int scoreInt;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    public void Update()
    {

        scoreText.text = scoreInt.ToString();

        if (scoreInt > PlayerPrefs.GetInt("HighScore", 0))
        {
        PlayerPrefs.SetInt("HighScore", scoreInt);
        highScore.text = scoreInt.ToString();
        }
    }
}
