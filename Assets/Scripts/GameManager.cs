using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject failPanel, completePanel;
    public GameObject[] Levels;

    public static int levelNum = 0;

    public static GameManager instance;

    private void Awake()
    {
        Time.timeScale = 1.0f;
        instance = this;
    }

    private void Start()
    {
        Levels[levelNum].SetActive(true);
    }

    public void GameFail()
    {
        failPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void GameComplete()
    {
        completePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Next()
    {
        levelNum++;
        if (levelNum >= Levels.Length)
        {
            levelNum = 0;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
