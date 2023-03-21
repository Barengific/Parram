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

    void Start()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            scoreCarried = PlayerPrefs.GetInt("Score");
        }
        else
        {
            Debug.Log("Non Existing Key");
            scoreCarried = 0;
        }

        Debug.Log("!!!!!: " + scoreReal.text + " 111111111");

        int tempScoreInt = scoreCarried + int.Parse(scoreReal.text);
        string tempScoreStr = tempScoreInt.ToString();
        scoreReal.text = tempScoreStr;



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
