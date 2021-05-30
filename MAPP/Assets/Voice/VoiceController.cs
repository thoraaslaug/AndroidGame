using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TextSpeech;
using UnityEngine.Android;

public class VoiceController : MonoBehaviour
{
    [SerializeField] Text uiText;
    [SerializeField] Text uiText2;
    private float listenTimer = 0;
    private float listenTime = 2.5f;
    private bool listening = false;
    private GameObject dialog = null;
    private bool test = false;

    void Start()
    {

        Setup("en-US");
        //SpeechToText.instance.onPartialResultsCallback = OnPartialSpeechResult;
        SpeechToText.instance.onResultCallback = OnFinaleSpeechResult;
        TextToSpeech.instance.onStartCallBack = OnSpeakStart;
        TextToSpeech.instance.onDoneCallback = OnSpeakStop;
        if (!Permission.HasUserAuthorizedPermission(Permission.Microphone))
        {
            Permission.RequestUserPermission(Permission.Microphone);
            
            CheckPremmision();
        }
       


    }
    void Update()
    {
        foreach (var device in Microphone.devices)
        {
            uiText2.GetComponent<Text>().text = ("name: " + device);
        }


        //if (listening == false)
        //{
        //    listening = true;
        //    StartListening();
            
        //}
        //if (listening == true)
        //{
        //    uiText2.text = "true ";
        //    listenTimer += Time.deltaTime;
        //    if (listenTimer >= listenTime)
        //    {
        //        uiText2.text = "name: ";
        //        StopListening();
        //        //listenTimer = 0;
        //        //listening = false;
        //    }
        //}
    }
    public void change()
    {
        test = !test;
    }
    void CheckPremmision()
    {
        if (!Permission.HasUserAuthorizedPermission(Permission.Microphone))
        {
            dialog.AddComponent<PermissionsRationaleDialog>();
        }
        else if (dialog != null)
        {
            Destroy(dialog);
        }
    }
    
    public void startspeaking(string message)
    {
        TextToSpeech.instance.StartSpeak(message);
    }
    public void stopspeaking()
    {
        TextToSpeech.instance.StopSpeak();
    }

    void OnSpeakStart()
    {
        Debug.Log("Talking started.. ");
    }
    void OnSpeakStop()
    {
        Debug.Log("stopped");
    }
    public void StartListening()
    {
        uiText.text = "Listening...";
        SpeechToText.instance.StartRecording();
        
    }
    public void StopListening()
    {
        uiText.text = "Done";
        SpeechToText.instance.StopRecording();
        

    }
    void OnFinaleSpeechResult(string result)
    {
        uiText.text = "test klart";

        if (result.Contains("right"))
        {
            Debug.Log("right");
        }
        else if (result.Contains("left"))
        {
            Debug.Log("left");
        }
        else if (result.Contains("jump"))
        {
            Debug.Log("jump");
        }

    }
    //void OnPartialSpeechResult(string result)
    //{
    //    uiText.GetComponent<Text>().text = result;
    //}

    void Setup(string code)
    {
        TextToSpeech.instance.Setting(code, 1, 1);
        SpeechToText.instance.Setting(code);
    }
}
