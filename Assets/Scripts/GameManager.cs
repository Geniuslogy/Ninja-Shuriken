using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    bool IsDead = false;

    int score = 0;

    public Text ScoreText;

    public GameObject GameOverPanel;


    public void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        IsDead = true;

        GameObject.Find("ShurikenSpawner").GetComponent<ShurikenSpawner>().StopSpawning();

        GameOverPanel.SetActive(true);
    }

    public void IncrementScore()
    {
        
        if (!IsDead)
        {
            score++;

            ScoreText.text = score.ToString();
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
