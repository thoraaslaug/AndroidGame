using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour
{
    public int healthPoints = 2;
    public int initialHealthPoints = 2;
    private GameObject respawnPosition;
    [SerializeField] private GameObject startPosition;
    [SerializeField] private bool useStartPosition = true;
    [SerializeField] private int antalQuizSteg1 = 20;
    [SerializeField] private int antalQuizSteg2 = 40;
    [SerializeField] private int antalQuizSteg3 = 60;
    [SerializeField] private int antalRight=0;
    [SerializeField] private GameObject quizAntalText;
  
   
    // Start is called before the first frame update
    void Start()
    {

        
        healthPoints = initialHealthPoints;
        if (useStartPosition == true)
        {
            gameObject.transform.position = startPosition.transform.position;
        }
        respawnPosition = startPosition;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public int getTotalRight()
    {
        return antalRight;
    }
    public void quizCounter()
    {
        antalRight++;
    }
    public void setCounter()
    {
        quizAntalText.GetComponent<Text>().text = "" + antalRight;
    }


}
