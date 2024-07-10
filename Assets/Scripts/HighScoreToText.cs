using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreToText : MonoBehaviour
{

    private TMP_Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        highScoreText = GetComponent<TMP_Text>();

        if (PlayerPrefs.GetInt("HighScore") < PlayerPrefs.GetInt("score"))
        {
            GlobalScoreManager.SaveHighScore(PlayerPrefs.GetInt("score"));
        }

        int highScore = PlayerPrefs.GetInt("HighScore");

        highScoreText.text = "HighScore: " + highScore.ToString();
    }

}
