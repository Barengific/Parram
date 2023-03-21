using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuSceneInstantiate : MonoBehaviour
{
    // Start is called before the first frame update
    private int scoreCarried = 0;
    private int highscoreCarried = 0;

    public TextMeshProUGUI scoreReal;
    public TextMeshProUGUI highscoreReal;

    void Start()
    {
        //points
        if (PlayerPrefs.HasKey("Score"))
        {
            scoreCarried = PlayerPrefs.GetInt("Score");
        }
        else
        {
            Debug.Log("Non Existing Key");
            scoreCarried = 0;
        }

        //highscore
        if (PlayerPrefs.HasKey("HighScore"))
        {
            int score = PlayerPrefs.GetInt("HighScore");
            string scoreStr = score.ToString();
            highscoreReal.text = scoreStr;
        }
        else
        {
            int score = 0;
            string scoreStr = score.ToString();
            highscoreReal.text = scoreStr;
        }

        int tempScoreInt = scoreCarried + int.Parse(scoreReal.text);
        string tempScoreStr = tempScoreInt.ToString();
        scoreReal.text = tempScoreStr;



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
