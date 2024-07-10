using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreToText : MonoBehaviour
{

    private TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        if (PlayerPrefs.HasKey("score"))
        {
            int score = PlayerPrefs.GetInt("score");
            scoreText.text = "Score: " + score.ToString();
        } else
        {
            scoreText.text = "Score: N/A";
        }
    }

}
