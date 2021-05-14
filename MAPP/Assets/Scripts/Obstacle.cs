using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    PlayerMovement playerMovement;
    PlayerState playerState;
    [SerializeField] private GameObject objectToDestory;
    public int damage = 1;


    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
    }

    private void OnCollisionEnter(Collision collision)
   {
       //  Kill the player
       //if (collision.gameObject.name == "Player")
       // {
       //     playerMovement.Die();
       // }
        if(collision.gameObject.tag == "Answers")
        {
            Destroy(objectToDestory);
        } 
        if (collision.gameObject.CompareTag("Player") == true)
            collision.gameObject.GetComponent<PlayerState>().DoHarm(damage);
       
            SoundManager.PlaySound("Bump");
        
        {

        }

    }




    void Update()
    {
        
    }
}
