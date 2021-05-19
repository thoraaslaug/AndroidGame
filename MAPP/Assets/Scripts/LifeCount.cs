using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{
    public Image Life, Life1;
    public int livesRemaining;
    public Obstacle obs;


    public void Start()
    {
        livesRemaining = 2;
        Life.gameObject.SetActive(true);
        Life1.gameObject.SetActive(true);


        void Update()
        {
            if (livesRemaining > 2)

                livesRemaining = 2;

            switch (livesRemaining)
            {
                case 2:
                    Life.gameObject.SetActive(true);
                    Life1.gameObject.SetActive(true);
                    break;

                case 1:
                    Life.gameObject.SetActive(true);
                    Life.gameObject.SetActive(false);
                    break;

                case 0:
                    Life.gameObject.SetActive(false);
                    Life.gameObject.SetActive(false);
                    FindObjectOfType<PlayerMovement>().Die();
                    break;
            }

        }
    }
}



    
