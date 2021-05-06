using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetLanguage : MonoBehaviour
{
    public Language[] languages;
    public Text Play;
    public Text Settings;
    public Text Exit;
    //public Text lang;

    private void Start()
    {
        if (PlayerPrefs.HasKey("lang"))
        {
            int index = PlayerPrefs.GetInt("lang");
            CurrentLanguage(index);
        }

    }

    public void CurrentLanguage(int index)
    {
        Play.text = languages[index].play;
        Settings.text = languages[index].settings;
        Exit.text = languages[index].exit;
        PlayerPrefs.SetInt("lang", index);

    }

}
