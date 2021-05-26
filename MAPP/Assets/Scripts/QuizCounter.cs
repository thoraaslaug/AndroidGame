using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCounter : MonoBehaviour
{
    private float timer = 0f;
    [SerializeField] private float timeBeforeDeletion = 0.5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            timer += Time.deltaTime;
            if (timer >= timeBeforeDeletion)
            {
               collision.GetComponent<PlayerState>().getTotalRight();
            }
            

        }
    }
}

