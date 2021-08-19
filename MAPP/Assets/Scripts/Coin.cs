using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour{
    [SerializeField] private AudioSource pickupSoundSource;
    [SerializeField] private ParticleSystem particles;
    [SerializeField] private GameObject player;
    [SerializeField] private AudioClip pickupSound;
    void Start() {
        pickupSoundSource.clip = pickupSound;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player") == true) {
            //SaveCoinsToMemory(1);
            if (player.GetComponent<LifeCount>().livesRemaining < 3) {
                player.GetComponent<LifeCount>().lives[player.GetComponent<LifeCount>().livesRemaining].enabled = true;
                player.GetComponent<LifeCount>().livesRemaining += 1;
                print(player.GetComponent<LifeCount>().livesRemaining);
                player.GetComponent<PlayerState>().healthPoints += 1;
            }
            
            pickupSoundSource.Play();
            particles.Play();
            StartCoroutine(deleteObject());
        }

    }


    IEnumerator deleteObject() {
        yield return new WaitForSeconds(.3f);
        gameObject.SetActive(false);
    }
    //public static void SaveCoinsToMemory(int amount) {
    //      PlayerPrefs.SetInt("CoinAmount", PlayerPrefs.GetInt("CoinAmount") + amount);
    //}

}
