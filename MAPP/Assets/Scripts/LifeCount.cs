using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{
    public Image[] lives;
    public int livesRemaining;

 
    public void LoseLife()
    {
        
        if (livesRemaining == 0)
            return;
        
        livesRemaining--;
      
        lives[livesRemaining].enabled = false;

        //If we run out of lives we lose the game
        if (livesRemaining == 0)
        {
            FindObjectOfType<PlayerMovement>().Die();
        }
    }

    private void Update()
    {
        
    }

}