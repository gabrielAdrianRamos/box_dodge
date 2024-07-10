using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUpdater : MonoBehaviour
{

    private TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = GlobalScoreManager.GlobalScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScoreText();
    }
}
