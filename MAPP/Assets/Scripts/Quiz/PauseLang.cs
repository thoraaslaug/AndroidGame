using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseLang : MonoBehaviour
{
    public Text play;
    private DataBs_SV svenska;
    private DataBs_CN chinese;
    private DataBs_Eng english;
    private DataBs_FR franch;
    private DataBs_IS island;

    [SerializeField] private int curentLang;
    SetLanguage setLang;

    float n;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {   

        setLang = GameObject.FindObjectOfType<SetLanguage>();
        curentLang = setLang.currentLang;
        svenska = GameObject.FindObjectOfType<DataBs_SV>();
        chinese = GameObject.FindObjectOfType<DataBs_CN>();
        english = GameObject.FindObjectOfType<DataBs_Eng>();
        franch = GameObject.FindObjectOfType<DataBs_FR>();
        island = GameObject.FindObjectOfType<DataBs_IS>();


              if (curentLang == 0)
        {
            play = english.GetComponent<Text>();
            Debug.Log("en");
        }
        else if (curentLang == 1)
        {
            play = svenska.GetComponent<Text>();
            Debug.Log("sv");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
