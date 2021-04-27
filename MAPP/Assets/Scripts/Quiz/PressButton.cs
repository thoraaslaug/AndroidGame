using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButton : MonoBehaviour
{
    private List<string> objects = new List<string>();

    void Update()
    {

        objects.Add("Hej");
        Debug.Log(objects);
        
    }
    private void OnTriggerEnter(Collider other)
    {
       
    }
}
