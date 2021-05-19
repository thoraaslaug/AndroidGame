using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    [SerializeField] private Text textComponent; 
    void Start()
    {

        textComponent.text = "HighScore: " + PlayerPrefs.GetInt("AntalRight");
    }
    public static void SaveRightToMemory(int amount)
    {
        if(amount > PlayerPrefs.GetInt("AntalRight"))
        {
            PlayerPrefs.SetInt("AntalRight", amount);
            CloudOnceServices.instance.SubmitScoreToLeaderboard(amount);
        }
        else
        {
            return;
        }
        
        
    }

}
