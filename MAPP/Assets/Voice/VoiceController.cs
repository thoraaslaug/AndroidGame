using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TextSpeech;
using UnityEngine.Android;

public class VoiceController : MonoBehaviour
{
    const string LANG_CODE = "en—US";
    [SerializeField] Text uiText;
    private float timer = 0;
    private float time = 2.5f;
    private bool listening = false;

    private void Start()
    {
        
        Setup(LANG_CODE);
        SpeechToText.instance.onPartialResultsCallback = OnPartialSpeechResult;
        SpeechToText.instance.onResultCallback = OnFinaleSpeechResult;
        TextToSpeech.instance.onStartCallBack = OnSpeakStart;
        TextToSpeech.instance.onDoneCallback = OnSpeakStop;
        CheckPremmision();

    }
    private void Update()
    {
       
        if (!listening)
        {
            listening = true;
            StartListening();
        }
        if (listening)
        {
            float listenTimer = 0;
            float listenTime = 2;
            listenTimer += Time.deltaTime;
            if (listenTimer >= listenTime)
            {
                listening = false;
                StopListening();
                listenTimer = 0;
            }
        }
    }
    void CheckPremmision()
    {
        if (!Permission.HasUserAuthorizedPermission(Permission.Microphone))
        {
            Permission.RequestUserPermission(Permission.Microphone);
        }
    }
    public void StartSpeaking(string message)
    {
        TextToSpeech.instance.StartSpeak(message);
    }
    public void StopSpeaking()
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
        SpeechToText.instance.StartRecording();
    }
    public void StopListening()
    {
        listening = false;
        SpeechToText.instance.StopRecording();
    }
    void OnFinaleSpeechResult(string result)
    {
        uiText.text = result;
        if(result.Contains("right")) 
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
    void OnPartialSpeechResult(string result)
    {
        uiText.text = result;
    }

    void Setup(string code)
    {
        TextToSpeech.instance.Setting(code, 1, 1);
        SpeechToText.instance.Setting(code);
    }
}
