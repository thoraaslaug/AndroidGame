using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TextSpeech;
using UnityEngine.Android;

public class VoiceController : MonoBehaviour
{
    [SerializeField] Text uiText;
    private float listenTimer = 0;
    private float listenTime = 2.5f;
    private bool listening = false;

    void Start()
    {

        Setup("en-US");
        SpeechToText.instance.onPartialResultsCallback = OnPartialSpeechResult;
        SpeechToText.instance.onResultCallback = OnFinaleSpeechResult;
        //TextToSpeech.instance.onStartCallBack = OnSpeakStart;
        //TextToSpeech.instance.onDoneCallback = OnSpeakStop;
        CheckPremmision();

    }
    void Update()
    {
        //Setup(LANG_CODE);
        //SpeechToText.instance.onPartialResultsCallback = OnPartialSpeechResult;
        //SpeechToText.instance.onResultCallback = OnFinaleSpeechResult;
        //TextToSpeech.instance.onStartCallBack = OnSpeakStart;
        //TextToSpeech.instance.onDoneCallback = OnSpeakStop;
        //CheckPremmision();

        //if (listening == false)
        //{
            
        //    StartListening();
        //    listening = true;
        //}
        //if (listening == true)
        //{
        //    listenTimer += Time.deltaTime;
        //    if (listenTimer >= listenTime)
        //    {
                
        //        StopListening();
        //        listenTimer = 0;
        //        listening = false;
        //    }
        //}
    }
    void CheckPremmision()
    {
        if (!Permission.HasUserAuthorizedPermission(Permission.Microphone))
        {
            Permission.RequestUserPermission(Permission.Microphone);
        }
    }
    //public void StartSpeaking(string message)
    //{
    //    TextToSpeech.instance.StartSpeak(message);
    //}
    //public void StopSpeaking()
    //{
    //    TextToSpeech.instance.StopSpeak();
    //}

    //void OnSpeakStart()
    //{
    //    Debug.Log("Talking started.. ");
    //}
    //void OnSpeakStop()
    //{
    //    Debug.Log("stopped");
    //}
    public void StartListening()
    {
        SpeechToText.instance.StartRecording(speak any);
    }
    public void StopListening()
    {

        SpeechToText.instance.StopRecording();
        
    }
    void OnFinaleSpeechResult(string result)
    {
        uiText.GetComponent<Text>().text = result;
        //if (result.Contains("right")) 
        //{
        //    Debug.Log("right");
        //}
        //else if (result.Contains("left"))
        //{
        //    Debug.Log("left");
        //}
        //else if (result.Contains("jump"))
        //{
        //    Debug.Log("jump");
        //}

    }
    void OnPartialSpeechResult(string result)
    {
        uiText.GetComponent<Text>().text = result;
    }

    void Setup(string code)
    {
        TextToSpeech.instance.Setting(code, 1, 1);
        SpeechToText.instance.Setting(code);
    }
}
