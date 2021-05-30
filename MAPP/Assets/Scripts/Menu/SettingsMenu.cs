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

    [System.NonSerialized] public int index = 0;


    public int getIndex()
    {
        if (joy)
        {
            return 1;
        }
        else
        {
            return 0;
        }
        return index;
    }
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
        joy = true;
        index = 1;
        settingsMenu.SetActive(false);
        menu.SetActive(true);
    }
    public void Swipe()
    {
        joy = false;
        index = 0;
        settingsMenu.SetActive(false);
        menu.SetActive(true);

    }


}
