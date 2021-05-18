using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject deathMenu;
    [SerializeField] GameObject controller;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip musicClip;

    bool alive = true;

    [SerializeField] float speed = 5;
    [SerializeField] Rigidbody rb;

    private bool isGrounded;
    [SerializeField] private LayerMask whatisground;
    public GameObject groundcheck;
    [SerializeField] float horizontalMuliplier = 2f;
    public int laneNum = 2;
    public int QuizAmount = 0;
    [SerializeField] private int amountToCollect = 20;
    [SerializeField] int levelToLoad;
    public float horizVel = 0;
    public float verticalMove = 0;
    public string controlLocked = "n";
    bool toggle = false;
    private Vector3 move;
    public float forwardSpeed;
    public float maxSpeed;
    private float yVelocity = 0.0f;

    [SerializeField] int control = 0;


    private Vector2 startTouchPosition, endTouchPosition;


    [SerializeField] float jumpForce = 400f;

    [SerializeField] LayerMask groundLayerMask;

    //*********quiz
    [SerializeField] Animator animator;
    [SerializeField] Joystick joystick;
    [SerializeField] int currentRightAnswer;
    SettingsMenu settingsMenu;
    private float time = 0.5f;
    private float timer = 0;
    [SerializeField] private ParticleSystem particles;
   
    void Start()
    {
        audioSource.clip = musicClip;
        audioSource.loop = true;
        audioSource.Play();
        animator = gameObject.GetComponent<Animator>();
        animator.SetBool("Dead", false);
        settingsMenu = GameObject.FindObjectOfType<SettingsMenu>();
        control = settingsMenu.index;
    }

    private void FixedUpdate()
    {
        if (!alive) return;


        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;


        if (control == 1)
        {

       
        //JoyStick
        if (joystick.Horizontal > 0.5 && (laneNum < 3) && (controlLocked == "n"))
        {
            horizVel = 12;
            StartCoroutine(stopSlide());
            laneNum += 1;
            controlLocked = "y";
        }

        if (joystick.Horizontal < -0.5 && (laneNum > 1) && (controlLocked == "n"))
        {
            horizVel = -12;
            StartCoroutine(stopSlide());
            laneNum -= 1;
            controlLocked = "y";
        }
        }
        if (control == 0)
        {
            controller.SetActive(false);
            //Touch Controll
            if (Input.touchCount> 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
            startTouchPosition = Input.GetTouch(0).position;
            }

            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
            endTouchPosition = Input.GetTouch(0).position;

            if ((endTouchPosition.x < startTouchPosition.x) && transform.position.x > -1.75f) {
                horizVel = 12;
                StartCoroutine(stopSlide());
                laneNum += 1;
                controlLocked = "y"; 
            }
                

            if ((endTouchPosition.x > startTouchPosition.x) && transform.position.x < 1.75f)
            {
                horizVel = -12;
                StartCoroutine(stopSlide());
                laneNum -= 1;
                controlLocked = "y";
            }
        }
        }
            
        

            
        

            GetComponent<Rigidbody>().velocity = new Vector3(horizVel, GetComponent<Rigidbody>().velocity.y, 4);

        float horizentalInput = joystick.Horizontal;
        verticalMove = joystick.Vertical;



        if (transform.position.y < -5)
        {
            Die();
        }

        rb.MovePosition(rb.position + forwardMove);

        if (toggle)
        {
            toggle = false;
            if (forwardSpeed < maxSpeed)
                forwardSpeed += 0.2f * Time.fixedDeltaTime;
        }
        else
        {
            toggle = true;
            if (Time.timeScale < 2f)
                Time.timeScale += 0.01f * Time.fixedDeltaTime;
        }

    }

    void Update()
    {
<<<<<<< Updated upstream
        
        if (joystick.Vertical >= 0.5)
=======
        bool a = false;
        bool jump = false;
        verticalMove = joystick.Vertical;

        //Collider2D[] Colliders = Physics2D.OverlapCircleAll(groundcheck.transform.position, 5f, whatisground); // kollar om våran colider kolliderar med något 
        //isGrounded = false;

        //for (int i = 0; i < Colliders.Length; i++) // om den gör det så är detta sant
        //{
        //    if (Colliders[i].gameObject != gameObject) // förutom om den rör vid spelaren 
        //    {
        //        isGrounded = true;
        //    }
        //}
        if(a = true)
        {
            timer += Time.deltaTime;
            a = false;
        }

        if (joystick.Vertical > 0.5f && timer > time )
>>>>>>> Stashed changes
        {
            a = true;
            jump = true;
        }

        if (jump)
        {
            
            float height = GetComponent<Collider>().bounds.size.y;

            bool IsGrounded = Physics.Raycast(transform.position, Vector3.down, (height / 2) -0.5f, groundLayerMask);
            if (IsGrounded)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0, 10, 3);
                //rb.AddForce(Vector3.up * jumpForce);
                particles.Play();
                
            }
        }
                
       

    }

    public void Die()
    {
        alive = false;
        QuizAmount = 0;
        // Restart the game with a 2 second delay
        animator.SetBool("Dead", true);
        audioSource.loop = false;
        Invoke("Restart", 2);
        
        

    }
    

    void Restart()
    {
        deathMenu.GetComponent<DeathMenu>().PauseGame();

        
    }
    public void keepRunning()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(.3f);
        horizVel = 0;
        controlLocked = "n";
    }

    //void Jump()
    //{
    //    float height = GetComponent<Collider>().bounds.size.y;

    //    bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (height / 2), groundLayerMask);

    //    if (isGrounded) rb.AddForce(Vector3.up * jumpForce);
    //    particles.Play();
    //}

    //quiz
    public Transform pauseGame()
    {

        Debug.Log("I am pausing");
        return gameObject.transform;
    }

    public void setCurrentAnswerIndex(int i)
    {
        currentRightAnswer = i;
    }
    public int getCurrentAnserIndex()
    {
        return currentRightAnswer;
    }
    //*****************

    public void QuizCounter()
    {
        QuizAmount++;
    }

}
