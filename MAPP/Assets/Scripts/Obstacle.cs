using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    PlayerMovement playerMovement;
    PlayerState playerState;
    [SerializeField] private GameObject objectToDestory;
    public int damage = 1;
    LifeCount lifecount;
    public cameraShake cameraShake;


    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
        playerState = GameObject.FindObjectOfType<PlayerState>();
        cameraShake = GameObject.FindObjectOfType<cameraShake>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Answers")
        {

            Destroy(objectToDestory);
        }

        if (collision.gameObject.CompareTag("Player") == true)
        {


            FindObjectOfType<LifeCount>().LoseLife();

            //collision.gameObject.GetComponent<PlayerState>().DoHarm(damage);
            //SoundManager.PlaySound("Bump");
            if (playerState.healthPoints == 0)
            {
                playerMovement.Die();

            }
            else
            {
                collision.gameObject.GetComponent<PlayerState>().DoHarm(damage);
                //lifecount.LoseLife();
                cameraShake.shouldShake = true;


                SoundManager.PlaySound("Bump");
            }


        }



    }

    void Update()
    {

    }
}