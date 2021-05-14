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
    public Text easy;
    public Text normal;
    public Text hard;

    public GameObject menuPanel;
    public GameObject langPanel;
        

    public  int currentLang;

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
        easy.text = languages[index].easy;
        normal.text = languages[index].normal;
        hard.text = languages[index].hard;
        PlayerPrefs.SetInt("lang", index);
        currentLang = index;
    }


}//end of class
