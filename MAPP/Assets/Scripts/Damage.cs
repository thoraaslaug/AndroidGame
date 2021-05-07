using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    public int damage = 1;
    private void OnCollisionEnter3D(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
            collision.gameObject.GetComponent<PlayerState>().DoHarm(damage);
        {

        }
    }

}
