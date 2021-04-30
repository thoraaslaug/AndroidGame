using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizUI : MonoBehaviour

{
    [SerializeField] GameObject quizCounter;
    [SerializeField] GameObject quizText;
    private PlayerState playerState;
    private Text textComponent;
    // Start is called before the first frame update
    void Start()
    {
        playerState = GameObject.Find("Player").GetComponent<PlayerState>();
        textComponent = quizText.GetComponent<Text>();
    }
    public void setPanelOaktiv()
    {
        gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        textComponent.text = playerState.getTotalRight() + "";
    }
    public void setAnswers()
    {

    }
    public void setCounter(int i)
    {
        string s = "" + i;
        quizText.GetComponent<Text>().text = s;
    }
}