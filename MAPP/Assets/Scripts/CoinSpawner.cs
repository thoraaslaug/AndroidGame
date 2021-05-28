using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {
    [SerializeField] GameObject player;
    [SerializeField] GameObject coinObject;
    private string coinLock = "n";
    private Transform playerTransform;


    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (coinLock == "n") {
            SpawnCoin();
            StartCoroutine(CoinCooldown());
        }
    }


    public void SpawnCoin() {
        playerTransform = transform;
        float z = player.transform.position.z;
        System.Random rand = new System.Random();
        int rndnmb = rand.Next(1, 3);
        if (rndnmb == 1) {
            playerTransform.position = new Vector3(3, 2, z + 15);
            Instantiate(coinObject, playerTransform.position, Quaternion.identity, transform);
        }
        else if (rndnmb == 2) {
            playerTransform.position = new Vector3(0, 2, z + 15);
            Instantiate(coinObject, playerTransform.position, Quaternion.identity, transform);
        }
        else {
            playerTransform.position = new Vector3(-3, 2, z + 15);
            Instantiate(coinObject, playerTransform.position, Quaternion.identity, transform);
        }
        coinLock = "y";
    }
    

    IEnumerator CoinCooldown() {
        yield return new WaitForSeconds(2f);
        coinLock = "n";
    }
}
