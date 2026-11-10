using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene"); // put your game scene's exact name here
    }

    public void QuitGame()
    {
        Debug.Log("Quit pressed");
        Application.Quit();
    }
}