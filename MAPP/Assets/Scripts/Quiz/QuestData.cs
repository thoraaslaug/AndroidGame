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


    float n;
    private GameObject player;
 


    private void Start()
    {
        questions = new List<Question>();
        curentLang = PlayerPrefs.GetInt("lang");

        svenska = GameObject.FindObjectOfType<DataBs_SV>();
        chinese = GameObject.FindObjectOfType<DataBs_CN>();
        english = GameObject.FindObjectOfType<DataBs_Eng>();
        franch = GameObject.FindObjectOfType<DataBs_FR>();
        island = GameObject.FindObjectOfType<DataBs_IS>();
        player = GameObject.Find("Player");
     
        Debug.Log(curentLang);

        switch (curentLang)
        {
            case 0: questions = english.allQues(); break;
            case 1: questions = svenska.allQues(); break;
            case 2: questions = chinese.allQues(); break;
            case 3: questions = island.allQues(); break;
            case 4: questions = franch.allQues(); break;
            default:
                questions = svenska.allQues(); break;


        }
        Debug.Log(questions.Count);

        // questions = svenska.allQues();
        questPanel.SetActive(false);
        InvokeRepeating("randomQuest", 2f, 20f);

        
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
        List<Answer> ansList = new List<Answer>();
        //random answers text
        int countNum = q.getAnswers().Count;//should be 3
        
        while (ansList.Count < countNum)
        {
            int index = Random.Range(0, q.getAnswers().Count );                 
            if (!ansList.Contains(q.getAnswers()[index]))
            {
                ansList.Add(q.getAnswers()[index]);
                q.getAnswers().Remove(q.getAnswers()[index]);
            }
                  
        }
  
        //**
        
        questionText.GetComponent<Text>().text = q.getQuestionText();
  
        
        
        //set right answer index on player

        answer1.GetComponent<Text>().text = ansList[0].getText();
        answer2.GetComponent<Text>().text = ansList[1].getText();
        answer3.GetComponent<Text>().text = ansList[2].getText();
        for (int i = 0; i < ansList.Count; i++)
        {
            if (ansList[i].isAnswerRight())
            {
                player.GetComponent<PlayerState>().setCurrentAnswerIndex(i);
            }
        }
        //remove question after viewing 
     
        questions.Remove(q);       
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