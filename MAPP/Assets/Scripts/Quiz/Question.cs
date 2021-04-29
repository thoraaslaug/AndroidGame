using System.Collections;
using System.Collections.Generic;


public class Question
{
    private string questionText;

    private List<Answer> answers;

    public Question(string questText, List<Answer> s)
    {
        this.questionText = questText;
        answers = s;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public string getQuestionText()
    {
        return questionText;
    }
    public List<Answer> getAnswers()
    {

        return answers;
    }
}