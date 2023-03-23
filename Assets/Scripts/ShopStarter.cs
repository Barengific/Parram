using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopStarter : MonoBehaviour
{
    public TextMeshProUGUI points;
    public TextMeshProUGUI hs;
    // Start is called before the first frame update
    void Start()
    {
        string pointsC;
        string hsC;
        //points
        if (PlayerPrefs.HasKey("Score"))
        {
            pointsC = (PlayerPrefs.GetInt("Score")).ToString();
        }
        else
        {
            pointsC = (0).ToString();
        }
        points.text = pointsC;


        //highscore
        if (PlayerPrefs.HasKey("HighScore"))
        {
            hsC = (PlayerPrefs.GetInt("HighScore")).ToString();
        }
        else
        {
            hsC = (0).ToString();
        }
        hs.text = hsC;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
