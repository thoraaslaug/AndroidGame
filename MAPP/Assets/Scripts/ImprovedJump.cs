using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImprovedJump : MonoBehaviour
{

    [SerializeField] private float fallMultiplier = 2.5f;
    [SerializeField] private float lowJump = 2f;

    [SerializeField] private Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        //SoundManager.PlaySound("Jump");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rigidbody.velocity.y <= 0)
        {
            rigidbody.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.fixedDeltaTime;
            
        }
    }
}
