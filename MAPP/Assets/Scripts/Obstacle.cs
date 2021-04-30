using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    PlayerMovement playerMovement;
    [SerializeField] private GameObject objectToDestory;

    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
    }

    private void OnCollisionEnter(Collision collision)
   {
       //  Kill the player
       if (collision.gameObject.name == "Player")
        {
           playerMovement.Die();
        }
        if(collision.gameObject.tag == "Answers")
        {
            Destroy(objectToDestory);
        }
    }


    void Update()
    {
        
    }
}
