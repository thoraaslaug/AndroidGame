using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject settingsMenu;
    public GameObject menu;
    public GameObject player;

    public int index = 1;

    private void Start()
    {
        GameObject.DontDestroyOnLoad(transform.gameObject);
    }
    public void Settings()
    {
        settingsMenu.SetActive(true);
        menu.SetActive(false);
    }
    public void JoyStick()
    {
        settingsMenu.SetActive(false);
        index = 1;
        menu.SetActive(true);
    }
    public void Swipe()
    {
        settingsMenu.SetActive(false);
        index = 0;
        menu.SetActive(true);

    }


}
