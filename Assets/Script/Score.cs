using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;

    public static int score;
    public static int highScore;

    private string highScoreKey = "highScore";

    private void Awake()
    {
        if (!LevelManager.isStart)
        {
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        score = 0;
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
    }

    public void AddPoint (int point)
    {
        score += point;

        Debug.Log(score);

        if (highScore < score)
        {
            highScore = score;
            Debug.Log(highScore);
        }
        DisplayScores();
    }

    private void DisplayScores()
    {
        scoreText.text = score.ToString();
        highScoreText.text = highScore.ToString();
    }

    public void Save()
    {
        PlayerPrefs.SetInt(highScoreKey, highScore);
        PlayerPrefs.Save();
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
