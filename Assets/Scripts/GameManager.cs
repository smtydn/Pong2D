using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text playerScore;
    public Text enemyScore; 

    private static GameManager _instance;
    public static GameManager instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(_instance);
        }
    }

    public void IncrementEnemyScore()
    {
        int score = int.Parse(enemyScore.text) + 1;
        enemyScore.text = score.ToString();
    }

    public void IncrementPlayerScore()
    {
        int score = int.Parse(playerScore.text) + 1;
        playerScore.text = score.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
