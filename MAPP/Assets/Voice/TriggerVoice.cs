using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerVoice : MonoBehaviour
{

    public VoiceController voiceControll;
    private float listenTimer = 0;
    private float listenTime = 2.5f;
    private bool listening = false;
    // Update is called once per frame
    void Update()
    {
        if (listening == false)
        {

            voiceControll.StartListening();
            listening = true;
        }
        if (listening == true)
        {
            listenTimer += Time.deltaTime;
            if (listenTimer >= listenTime)
            {

                voiceControll.StopListening();
                listenTimer = 0;
                listening = false;
            }
        }
    }
}
