using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField ]float speed  = 5;
    [SerializeField] Rigidbody rb;
    float horizentalInput;
    [SerializeField] float horizontalMuliplier = 2f;

    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizentalInput * speed * Time.fixedDeltaTime*horizontalMuliplier;
        rb.MovePosition(rb.position + forwardMove+horizontalMove);
    }

    // Update is called once per frame
    void Update()
    {
        horizentalInput = Input.GetAxis("Horizontal");
    }
}
