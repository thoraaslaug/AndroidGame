using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestData : MonoBehaviour
{


    private List<Question> questions;
    [SerializeField] private float spawnTime;
    [SerializeField] GameObject questPanel;
    [SerializeField] public GameObject questionText;
    [SerializeField] GameObject answer1;
    [SerializeField] GameObject answer2;
    [SerializeField] GameObject answer3;
    [SerializeField] GameObject hinder;
    private DataBs_SV svenska;
    private DataBs_CN chinese;
    private DataBs_Eng english;
    private DataBs_FR franch;
    private DataBs_IS island;

    [SerializeField] private int curentLang;
    SetLanguage setLang;

    float n;
    private GameObject player;
 


    private void Start()
    {
        questions = new List<Question>();
        setLang = GameObject.FindObjectOfType<SetLanguage>();
        curentLang = setLang.currentLang;
        svenska = GameObject.FindObjectOfType<DataBs_SV>();
        chinese = GameObject.FindObjectOfType<DataBs_CN>();
        english = GameObject.FindObjectOfType<DataBs_Eng>();
        franch = GameObject.FindObjectOfType<DataBs_FR>();
        island = GameObject.FindObjectOfType<DataBs_IS>();
        player = GameObject.Find("Player");
     
        Debug.Log(curentLang);


        if (curentLang == 0)
        {
            questions = english.allQues();
            Debug.Log("en");
        }
        else if(curentLang == 1){
            questions = svenska.allQues();
            Debug.Log("sv");
        }
       else if(curentLang == 2)
        {
            questions = chinese.allQues();
            Debug.Log("cn");
        }
        else if(curentLang == 3)
        {
            questions = island.allQues();
            Debug.Log("il");
        }
        else
        {
            questions = franch.allQues();
                 Debug.Log("fr"); 
        }

       // questions = svenska.allQues();
        questPanel.SetActive(false);
        InvokeRepeating("randomQuest", 2f, 20f);

        Debug.Log(questions.Count);
    }
    private void Awake()
    {
        
    }

    public void randomQuest()
    {
        //set hinder position
        Transform t = player.GetComponent<PlayerMovement>().pauseGame();
        n = t.position.z + 10f;

        //random choose a question
        Question q = questions[Random.Range(0, questions.Count)];

        questionText.GetComponent<Text>().text = q.getQuestionText();
        answer1.GetComponent<Text>().text = q.getAnswers()[0].getText();
        answer2.GetComponent<Text>().text = q.getAnswers()[1].getText();
        answer3.GetComponent<Text>().text = q.getAnswers()[2].getText();
        //set right answer index on player
        for (int i = 0; i < q.getAnswers().Count; i++)
        {
            if (q.getAnswers()[i].isAnswerRight())
            {
                player.GetComponent<PlayerMovement>().setCurrentAnswerIndex(q.getAnswers()[i].getRightIndex());
            }
        }

        //set question UI to visible 
        questPanel.SetActive(true);
        //creat answer cube after 10s
        Invoke("setHinder", 5f);
        //restart the game 

    }
    private void setHinder()
    {

        Vector3 pos = new Vector3(0f, 0f, n + 56f);
        Instantiate(hinder, pos, Quaternion.identity, null);

    }
    public List<Question> allQuestions()
    {
        return questions;
    }



}