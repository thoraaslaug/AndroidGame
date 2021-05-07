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


    public void PauseGame()
    {
        deathMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;



    }
    public void StartOver()
    {
        deathMenu.SetActive(false);
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
