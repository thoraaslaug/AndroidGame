using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICoin : MonoBehaviour
{


    private Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = PlayerPrefs.GetInt("CoinAmount") + "";
    }
}
