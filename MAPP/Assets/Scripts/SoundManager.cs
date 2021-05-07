using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip Bells, Begin, Run;
    static AudioSource audiosrc;

    public void Start()
    {
        Bells = Resources.Load<AudioClip>("Bells");

        audiosrc = GetComponent<AudioSource>();
    }

    public void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {

            case "Bells":

                audiosrc.PlayOneShot(Bells);
                break;
        }
    }
}

