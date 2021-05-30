using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject settingsMenu;
    public GameObject menu;
    public GameObject player;
    private bool joy = false;

    public int index = 1;
    


    public int getIndex()
    {
        
        return index;
    }
    private void Start()
    {
        GameObject.DontDestroyOnLoad(transform.gameObject);
        PlayerPrefs.SetInt("c", index);
    }
    public void Settings()
    {
        settingsMenu.SetActive(true);
        menu.SetActive(false);
    }
    public void JoyStick()
    {
        joy = true;
        index = 1;
        PlayerPrefs.SetInt("c", index);
        settingsMenu.SetActive(false);
        menu.SetActive(true);
    }
    public void Swipe()
    {
        index = 0;
        joy = false;
        PlayerPrefs.SetInt("c", index);
        settingsMenu.SetActive(false);
        menu.SetActive(true);

    }


}
