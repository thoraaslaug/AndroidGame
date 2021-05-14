using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu_StartGame : MonoBehaviour


    
{


    [SerializeField] GameObject menyPanel;
    [SerializeField] GameObject langPanel;
    [SerializeField] GameObject difficultPanel;
    string difficult;

    public void StartGame()
    {
        menyPanel.SetActive(false);
        langPanel.SetActive(false);
        difficultPanel.SetActive(true);
        
    }
    public void setDifficulty(string s)
    {
        difficult = s;
        PlayerPrefs.SetString("Diff", difficult);

        SceneManager.LoadScene(1);
    }
}

