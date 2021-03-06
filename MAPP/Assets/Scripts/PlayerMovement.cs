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


    [SerializeField] float horizontalMuliplier = 2f;
    public int laneNum = 2;
    public int QuizAmount = 0;
    private float time = 0;
    private float timer = 0.5f;

    [SerializeField] int levelToLoad;
    public float horizVel = 0;
    public float verticalMove = 0;
    public string controlLocked = "n";
    public string jumpLocked = "n";
    bool toggle = false;
    private Vector3 move;
    public float forwardSpeed;
    public float maxSpeed;
    private bool jumping;
    [SerializeField] int control = 0;

    public Teacher teacher;
    private Vector2 startTouchPosition, endTouchPosition;
    public bool isGrounded;
    public Vector3 jump;
    [SerializeField] float jumpForce = 400f;

    [SerializeField] LayerMask groundLayerMask;

    [SerializeField] Animator animator;
    [SerializeField] Joystick joystick;
    SettingsMenu settingsMenu;

    [SerializeField] private ParticleSystem particles;

    void Start()
    {
        audioSource.clip = musicClip;
        audioSource.loop = true;
        audioSource.Play();
        animator = gameObject.GetComponent<Animator>();
        animator.SetBool("Dead", false);
        settingsMenu = GameObject.FindObjectOfType<SettingsMenu>();
       // control = settingsMenu.getIndex();
        control = PlayerPrefs.GetInt("c");


    }

    //private void FixedUpdate()
    //{
    //    if (!alive) return;


    //    Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
    //    SoundManager.PlaySound("Run");

    //    if (control == 1)
    //    {


    //        JoyStick
    //        if (joystick.Horizontal > 0.5 && (laneNum < 3) && (controlLocked == "n"))
    //        {
    //            horizVel = 10;
    //            StartCoroutine(stopSlide());
    //            laneNum += 1;
    //            controlLocked = "y";
    //        }

    //        if (joystick.Horizontal < -0.5 && (laneNum > 1) && (controlLocked == "n"))
    //        {
    //            horizVel = -10;
    //            StartCoroutine(stopSlide());
    //            laneNum -= 1;
    //            controlLocked = "y";
    //        }
    //    }
    //    if (control == 0)
    //    {
    //        controller.SetActive(false);
    //        Touch Controll
    //        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
    //        {
    //            startTouchPosition = Input.GetTouch(0).position;
    //        }

    //        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
    //        {
    //            endTouchPosition = Input.GetTouch(0).position;

    //            if ((endTouchPosition.x < startTouchPosition.x) && transform.position.x > -1.75f)
    //            {
    //                horizVel = 10;
    //                StartCoroutine(stopSlide());
    //                laneNum += 1;
    //                controlLocked = "y";
    //            }


    //            if ((endTouchPosition.x > startTouchPosition.x) && transform.position.x < 1.75f)
    //            {
    //                horizVel = -10;
    //                StartCoroutine(stopSlide());
    //                laneNum -= 1;
    //                controlLocked = "y";
    //            }
    //        }
    //    }

    //    GetComponent<Rigidbody>().velocity = new Vector3(horizVel, GetComponent<Rigidbody>().velocity.y, 4);

    //    float horizentalInput = joystick.Horizontal;




    //    if (transform.position.y < -5)
    //    {
    //        Die();
    //    }

    //    rb.MovePosition(rb.position + forwardMove);

    //    if (toggle)
    //    {
    //        toggle = false;
    //        if (forwardSpeed < maxSpeed)
    //            forwardSpeed += 0.2f * Time.fixedDeltaTime;
    //    }
    //    else
    //    {
    //        toggle = true;
    //        if (Time.timeScale < 2f)
    //            Time.timeScale += 0.01f * Time.fixedDeltaTime;
    //    }

    //}
    private void FixedUpdate()
    {
        if (!alive) return;


        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;


        if (control == 1)
        {


            //JoyStick
            if (joystick.Horizontal > 0.5 && (laneNum < 3) && (controlLocked == "n"))
            {
                horizVel = 9;
                StartCoroutine(stopSlide());
                laneNum += 1;
                controlLocked = "y";
            }

            if (joystick.Horizontal < -0.5 && (laneNum > 1) && (controlLocked == "n"))
            {
                horizVel = -9;
                StartCoroutine(stopSlide());
                laneNum -= 1;
                controlLocked = "y";
            }
        }
        //if (control == 0)
        //{
        //    controller.SetActive(false);
        //    //Touch Controll
        //    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        //    {
        //        startTouchPosition = Input.GetTouch(0).position;
        //    }

        //    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        //    {
        //        endTouchPosition = Input.GetTouch(0).position;

        //        if ((endTouchPosition.x < startTouchPosition.x+25) && transform.position.x > -1f)
        //        {
        //            horizVel = -10;

        //            StartCoroutine(stopSlide());
        //            laneNum -= 1;
        //            controlLocked = "y";
        //            jumpLocked = "y";
        //        }


        //        if ((endTouchPosition.x > startTouchPosition.x+25) && transform.position.x < 1f)
        //        {

        //           horizVel = 10;
        //            StartCoroutine(stopSlide());
        //            laneNum += 1;
        //            controlLocked = "y";
        //            jumpLocked = "y";
        //        }

                



        //    }
        //}



            
        




        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, GetComponent<Rigidbody>().velocity.y, 4);
      
        float horizentalInput = joystick.Horizontal;
        verticalMove = joystick.Vertical;



        if (transform.position.y < -5)
        {
            Die();
        }
        if (gameObject.transform.position.x < -3.3f)
        {
            gameObject.transform.position = new Vector3(-3.3f, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (gameObject.transform.position.x > 3.3f)
        {
            gameObject.transform.position = new Vector3(3.3f, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        
        
    rb.MovePosition(rb.position + forwardMove);

        if (toggle)
        {
            toggle = false;
            if (forwardSpeed < maxSpeed)
                forwardSpeed += 0.1f * Time.fixedDeltaTime;
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
        verticalMove = joystick.Vertical;
        bool a = false;
        time = 0.5f;
       
        if (joystick.Vertical > 0.5)
        {
            a = true;
            jumping = true;
        }

        if (control == 0)
        {
            controller.SetActive(false);
            //Touch Controll
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                startTouchPosition = Input.GetTouch(0).position;
            }

            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                endTouchPosition = Input.GetTouch(0).position;


                if ((endTouchPosition.y > startTouchPosition.y) && transform.position.y < 0.3f)
                {
                    jumping = true;
                }
                if ((endTouchPosition.x < startTouchPosition.x + 250) && transform.position.x > -1f)
                {
                    horizVel = -10;

                    StartCoroutine(stopSlide());
                    laneNum -= 1;
                    controlLocked = "y";
                    jumpLocked = "y";
                }


                if ((endTouchPosition.x > startTouchPosition.x + 250) && transform.position.x < 1f)
                {

                    horizVel = 10;
                    StartCoroutine(stopSlide());
                    laneNum += 1;
                    controlLocked = "y";
                    jumpLocked = "y";
                }


            }
        }


        if (jumping)
        {
            jumping = false;
            float height = GetComponent<Collider>().bounds.size.y;

            bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (height / 2) + 0.1f, groundLayerMask);

            if (isGrounded && jumpLocked == "n") 
            {
                jumping = false;
                print("jump");
                jumpLocked = "y";
                rb.AddForce(Vector3.up * jumpForce);
                particles.Play();
                SoundManager.PlaySound("Jump");
                StartCoroutine(stopJump());

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


        if (alive == false)
        {
            SoundManager.PlaySound("Bells");
        }



    }


    void Restart()
    {
        deathMenu.GetComponent<DeathMenu>().PauseGame();
        gameObject.SetActive(true);
        gameObject.GetComponent<PlayerState>().setHP();

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
        jumpLocked = "n";

    }

    IEnumerator stopJump() {
        yield return new WaitForSeconds(.7f);
        jumpLocked = "n";
    }

    /*void Jump()
    {
        float height = GetComponent<Collider>().bounds.size.y;

        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (height / 2) + 0.1f, groundLayerMask);

        if (isGrounded) 
        {
            rb.AddForce(Vector3.up * jumpForce);
            particles.Play();
            SoundManager.PlaySound("Jump");
        }

    }*/

    //quiz******************
    public Transform pauseGame()
    {

        Debug.Log("I am pausing");
        return gameObject.transform;
    }
    //*****************


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Teacher") == true)
        {
            gameObject.SetActive(false);

        }
    }


}