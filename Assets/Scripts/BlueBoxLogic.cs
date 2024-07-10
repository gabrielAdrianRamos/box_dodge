using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlueBoxLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6f)
        {
            GlobalScoreManager.AddPointToGlobalScore();
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Gameover");

            PlayerPrefs.SetInt("score", GlobalScoreManager.GetGlobalScore());
        }
    }
}
