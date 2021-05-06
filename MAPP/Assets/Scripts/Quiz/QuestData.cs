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
   

    float n;
    private GameObject player;


    private void Start()
    {
        player = GameObject.Find("Player");
        svenska = GameObject.FindObjectOfType<DataBs_SV>();
        questions = svenska.allQues();
        questPanel.SetActive(false);
        InvokeRepeating("randomQuest", 2f, 20f);

        Debug.Log(questions.Count);
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