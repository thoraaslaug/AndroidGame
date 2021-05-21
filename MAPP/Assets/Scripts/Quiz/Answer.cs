public class Answer
{
    private string answerText;
    private bool isRight;
    private int rightNumb;
    public Answer(string s, bool b, int rightNum)
    {
        this.answerText = s;
        this.isRight = b;
        this.rightNumb = rightNum;
    }
    // Start is called before the first frame update

    public string getText()
    {
        return answerText;
    }
    public bool isAnswerRight()
    {
        return isRight;
    }
    public int getRightIndex()
    {
        return rightNumb;
    }
}