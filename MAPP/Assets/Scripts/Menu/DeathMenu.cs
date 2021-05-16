using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject deathMenu;
    public GameObject player;
    public bool isPaused;
    public GameObject questionPanel;
    public GameObject quizCounter;
    public GameObject pauseButton;


    public void PauseGame()
    {
        deathMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        questionPanel.SetActive(false);
        quizCounter.SetActive(false);
        pauseButton.SetActive(false);


    }
    public void StartOver()
    {
        deathMenu.SetActive(false);
        questionPanel.SetActive(true);
        quizCounter.SetActive(true);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
        player.GetComponent<PlayerMovement>().keepRunning();

    }
    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");

    }

}
