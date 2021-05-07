using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerCube : MonoBehaviour
{
    [SerializeField] private int representNumb;

    [SerializeField] private GameObject parent;
    private Answer a;
    QuizUI quizUI;

    private bool removeGameObject = false;
    [SerializeField] private ParticleSystem particles;
    private float timer;
    [SerializeField] private float timeBeforeDeletion = 1f;

    // Start is called before the first frame update
    void Start()
    {
        quizUI = GameObject.FindObjectOfType<QuizUI>();
        Invoke("changeColliderSize", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (removeGameObject == true)
        {
            timer += Time.deltaTime;
            if (timer >= timeBeforeDeletion)
            {
                Destroy(parent, 1f);
                Destroy(gameObject);
            }
        }
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
                particles.Play();
                removeGameObject = true;
                //här var destory först
            }
            else
            {
                coll.GetComponent<PlayerMovement>().Die();
            }


        }
        if(coll.gameObject.tag == "Obstacle")
        {
            Destroy(coll.gameObject);
        }
   

    }
    private void changeColliderSize()
    {
        gameObject.GetComponent<BoxCollider>().size = new Vector3(2f, 1, 1);
    }

}