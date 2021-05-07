using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject settingsMenu;
    public GameObject menu;
    public GameObject player;

    private void Start()
    {
        GameObject.DontDestroyOnLoad(transform.gameObject);
    }
    public void Settings()
    {
        settingsMenu.SetActive(true);
        //menu.SetActive(false);
    }
    public void JoyStick()
    {
        settingsMenu.SetActive(false);
        player.GetComponent<PlayerMovement>().Joy();
        
    }
    public void Swipe()
    {
        settingsMenu.SetActive(false);
        player.GetComponent<PlayerMovement>().Swipe();
        
    }


}
