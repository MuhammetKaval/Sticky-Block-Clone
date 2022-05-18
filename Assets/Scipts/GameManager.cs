using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    //public bool isReachFinishLine;
    public int cubeCount;
    public bool isGameActive;
    public bool isGameOver;
    public bool isReachFinishLine;
    public GameObject startUIObjects;
    public GameObject gameOverUIObjects;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void Start()
    {
        isGameActive = false;
        isGameOver = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGameOver == false)
        {
            StartGame();
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGameOver)
        {
            StartNewGame();
        }
    }


    public void StartGame()
    {
        Time.timeScale = 1;
        startUIObjects.SetActive(false);
        isGameActive = true;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverUIObjects.SetActive(true);
        isGameOver = true;
        Debug.Log("Game Over");
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
