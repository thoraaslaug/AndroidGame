using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButton : MonoBehaviour
{
    private GameObject button1;
    private GameObject button2;
    private GameObject button3;

    
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            //tryck ned specifik knapp 

        }
    }
}
