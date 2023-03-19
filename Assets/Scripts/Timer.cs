using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public TextMeshProUGUI timerText;
    private float totalPlayTime = 0.0f;

    public TextMeshProUGUI scoreText;
    private int score = 0;
    private Coroutine scoreCoroutine;

    // Update is called once per frame
    void Update()
    {
        totalPlayTime += Time.deltaTime;
        timerText.text = FormatTime(totalPlayTime);

        //StartCoroutine(IncrementScoreCoroutine());
    }

    private string FormatTime(float timeInSeconds)
    {
        int minutes = Mathf.FloorToInt(timeInSeconds / 60);
        int seconds = Mathf.FloorToInt(timeInSeconds % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    // Start is called before the first frame update
    void Start()
    {
        // Start the coroutine that increments the score every 5 seconds
        scoreCoroutine = StartCoroutine(IncrementScoreCoroutine());
    }

    private IEnumerator IncrementScoreCoroutine()
    {
        while (true)
        {
            // Wait for 5 seconds
            yield return new WaitForSeconds(5f);

            // Increment the score and update the text
            score++;
            scoreText.text = "Score: " + score.ToString();
        }
    }

    private void OnDisable()
    {
        // Stop the coroutine when the script is disabled
        StopCoroutine(scoreCoroutine);
    }

    private void OnDestroy()
    {
        // Stop the coroutine when the script is destroyed
        StopCoroutine(scoreCoroutine);
    }
}

