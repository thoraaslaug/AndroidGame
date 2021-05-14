using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseLang : MonoBehaviour
{
    public PauseLangInfo[] languages;
    public Text Play;
    
    public Text Pause;
    public Text Right;
    public Text Exit;
    public int currentLang;

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
        Pause.text = languages[index].pause;
        Exit.text = languages[index].exit;
        Right.text = languages[index].right;
        PlayerPrefs.SetInt("lang", index);
        currentLang = index;


    }
}//end of class
