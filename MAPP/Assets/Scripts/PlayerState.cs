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
    [SerializeField] private string diffString;
    [SerializeField]private int diffAntal;
    [SerializeField] private int antalRight=0;
    [SerializeField] private GameObject quizAntalText;
    [SerializeField] private GameObject winMeny;
    
   
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Diff"))
        {
            diffString = PlayerPrefs.GetString("Diff");
        }
        switch (diffString)
        {
            case "Easy": diffAntal = 20; break;
            case "Normal": diffAntal = 40; break;
            case "Hard": diffAntal = 60; break;

        }

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
        if(antalRight == diffAntal)
        {
            Time.timeScale = 0f;
            winMeny.SetActive(true);
        }


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
    public void DoHarm(int doHarmByThisMuch)
    {
        print(healthPoints);
        healthPoints -= doHarmByThisMuch;
       

    }
    public void setHP() {
        healthPoints = initialHealthPoints;
    }

}
