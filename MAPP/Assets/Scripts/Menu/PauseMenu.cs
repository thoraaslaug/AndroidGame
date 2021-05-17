using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused;
    // Start is called before the first frame update
    public GameObject questionPanel;
    public GameObject quizCounter;
    public GameObject pauseButton;

    // Update is called once per frame

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        questionPanel.SetActive(false);
        quizCounter.SetActive(false);
        pauseButton.SetActive(false);

    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        questionPanel.SetActive(true);
        quizCounter.SetActive(true);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;

    }
    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");

    }

    public void quitGame()
    {
        Application.Quit();
    }

}
