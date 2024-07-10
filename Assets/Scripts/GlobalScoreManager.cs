using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScoreManager : MonoBehaviour
{
    private static GlobalScoreManager instance;
    public int globalScore = 0;
    public int globalHighScore = 0;

    public static int GlobalScore
    {
        get { return instance.globalScore; }
        private set { instance.globalScore = value; }
    }

    public static int GlobalHighScore
    {
        get { return instance.globalHighScore; }
        private set { instance.globalHighScore = value; }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(instance.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public static void AddPointToGlobalScore()
    {
        GlobalScore++;
    }

    public static int GetGlobalScore()
    {
        return GlobalScore;
    }

    public static void ResetScore()
    {
        GlobalScore = 0;
    }

    public static void SaveHighScore(int value)
    {
        PlayerPrefs.SetInt("HighScore", value);
        PlayerPrefs.Save();
    }

        public static void ResetHighScore()
    {
        PlayerPrefs.SetInt("HighScore", 0);
        PlayerPrefs.Save();
    }

        public static void LoadHighScore()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            instance.globalHighScore = PlayerPrefs.GetInt("HighScore");
        }
    }
}
