using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText1;
    public Text scoreText2;

    public Text highScore;

    public static int scoreInt;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        scoreInt = 0;
    }
    public void Update()
    {

        scoreText1.text = scoreInt.ToString();
        scoreText2.text = scoreInt.ToString();

        if (scoreInt > PlayerPrefs.GetInt("HighScore", 0))
        {
        PlayerPrefs.SetInt("HighScore", scoreInt);
        highScore.text = scoreInt.ToString();

        }
    }
}
