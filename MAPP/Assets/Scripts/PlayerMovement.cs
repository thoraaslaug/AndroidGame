using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    bool alive = true;

    [SerializeField ]float speed  = 5;
    [SerializeField] Rigidbody rb;
    float horizentalInput;
    [SerializeField] float horizontalMuliplier = 2f;
    public int laneNum = 2;
    public float horizVel = 0;
    public string controlLocked = "n";
    bool toggle = false;
    private Vector3 move;
    public float forwardSpeed;
    public float maxSpeed;

    private void FixedUpdate()
    {
        if (!alive) return;

        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;

        if (Input.GetAxis("Horizontal") > 0 && (laneNum < 3) && (controlLocked == "n")) {
            horizVel = 7;
            StartCoroutine(stopSlide());
            laneNum += 1;
            controlLocked = "y";
        }
        if (Input.GetAxis("Horizontal") < 0 && (laneNum > 1) && (controlLocked == "n")) {
            horizVel = -7;
            StartCoroutine(stopSlide());
            laneNum -= 1;
            controlLocked = "y";
        }
        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, 0, 4);

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


    // Update is called once per frame
    void Update()
    {
       

    horizentalInput = Input.GetAxis("Horizontal");

        if (transform.position.y < -5)
        {
            Die();
        }


    }

    public void Die()
    {
        alive = false;

        // Restart the game with a 2 second delay
        Invoke("Restart", 2);

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    IEnumerator stopSlide() {
        yield return new WaitForSeconds(.5f);
        horizVel = 0;
        controlLocked = "n";
    }

}
