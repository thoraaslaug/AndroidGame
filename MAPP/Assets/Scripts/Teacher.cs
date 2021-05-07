using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher : MonoBehaviour
{
    public float speed;


    public Transform player;

    private Animator animator;
    private bool left = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
                transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            
    }
    //private void OnTriggerEnter2D(Collider2D collision) // om spelaren träffar flugan så dör den 
    //{
    //    if (collision.gameObject.CompareTag("Player") == true)
    //    {
    //        //Destroy(gameObject);
    //    }

    //}
}
