using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBs_Eng : MonoBehaviour
{
    private List<Question> questions;
    private void Awake()
    {
        questions = new List<Question>();
    }
    void addQuest(Answer a1, Answer a2, Answer a3, string s)
    {
        List<Answer> answers = new List<Answer>();
        answers.Add(a1); answers.Add(a2); answers.Add(a3);
        questions.Add(new Question(s, answers));
    }

    void dataBs()
    {
    }

        public List<Question> allQues()
    {
        dataBs();
        return questions;
    }
}
