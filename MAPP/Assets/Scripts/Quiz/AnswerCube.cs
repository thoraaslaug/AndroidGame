using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerCube : MonoBehaviour
{
    [SerializeField] private int representNumb;

    [SerializeField] private GameObject parent;
    private Answer a;
    QuizUI quizUI;
    // Start is called before the first frame update
    void Start()
    {
        quizUI = GameObject.FindObjectOfType<QuizUI>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void setOption(Answer answer)
    {
        a = answer;
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            if (coll.GetComponent<PlayerMovement>().getCurrentAnserIndex() == representNumb)
            {
                Debug.Log("lol");
                quizUI.setPanelOaktiv();
                coll.GetComponent<PlayerState>().quizCounter();
                coll.GetComponent<PlayerState>().setCounter();
                Destroy(parent, 1f);
                Destroy(gameObject);
            }
            else
            {
                coll.GetComponent<PlayerMovement>().Die();
            }


        }
   

    }

}