using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioControll : MonoBehaviour
{
    bool isAudioOn;
    [SerializeField] Text onText;
   
    string on = "Audio on";
    string of = "Audio off";
    // Start is called before the first frame update
    void Start()
    {
        isAudioOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        isAudioOn = !isAudioOn;
        if (isAudioOn)
        {
            onText.text = on;
            AudioListener.volume = 1f;
        }
        else
        {
            onText.text = of; ;
            AudioListener.volume = 0f;
        }
    }
}
