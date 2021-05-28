using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour{
    [SerializeField] private AudioSource pickupSound;
    [SerializeField] private ParticleSystem particles;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player") == true) {
            SaveCoinsToMemory(1);
            pickupSound.Play();
            particles.Play();
        }

    }
    public static void SaveCoinsToMemory(int amount) {
            PlayerPrefs.SetInt("CoinAmount", PlayerPrefs.GetInt("CoinAmount") + amount);
    }
    
}
