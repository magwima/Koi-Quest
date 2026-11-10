using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [Header("References")]
    public GameObject pauseMenuPanel;

    [Header("Settings")]
    public string mainMenuSceneName = "MainMenu";
    public bool lockCursorDuringGameplay = false;

    public static bool IsPaused { get; private set; }

    void Start()
    {
        Resume();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused) Resume();
            else Pause();
        }
    }

    public void Pause()
    {
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0f;
        AudioListener.pause = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        IsPaused = true;
    }

    public void Resume()
    {
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1f;
        AudioListener.pause = false;
        if (lockCursorDuringGameplay)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        IsPaused = false;
    }

    public void RestartLevel()
    {
        ResetBeforeSceneChange();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMainMenu()
    {
        ResetBeforeSceneChange();
        SceneManager.LoadScene(mainMenuSceneName);
    }

    public void QuitGame()
    {
        Debug.Log("Quit pressed (only works in a built game)");
        Application.Quit();
    }

    void ResetBeforeSceneChange()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        IsPaused = false;
    }
}