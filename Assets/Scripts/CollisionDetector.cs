using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class CollisionDetector : MonoBehaviour
{

    public TextMeshProUGUI scoreText;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected!");

        //point setter
        if (PlayerPrefs.HasKey("Score"))
        {
            int scoreCarried = PlayerPrefs.GetInt("Score");
            PlayerPrefs.SetInt("Score", int.Parse(scoreText.text) + scoreCarried);
        }
        else
        {
            Debug.Log("Non Existing Key");
            PlayerPrefs.SetInt("Score", int.Parse(scoreText.text));
        }

        //highscore setter
        if (PlayerPrefs.HasKey("HighScore"))
        {
            int currentHighScore = PlayerPrefs.GetInt("HighScore");
            int newHighScore = int.Parse(scoreText.text);

            if (newHighScore > currentHighScore)
            {
                PlayerPrefs.SetInt("HighScore", newHighScore);
            }
            else
            {
                PlayerPrefs.SetInt("HighScore", currentHighScore);
            }
            
        }
        else
        {
            PlayerPrefs.SetInt("HighScore", int.Parse(scoreText.text));
        }




        Destroy(collision.gameObject);
        SceneManager.LoadScene("MenuScene");

    }
}
