using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip Bells, Jump, Run, Bump;
    static AudioSource audiosrc;

    public void Start()
    {
        Bells = Resources.Load<AudioClip>("Bells");
        Jump = Resources.Load<AudioClip>("Jump");
        Run = Resources.Load<AudioClip>("Run");
        Bump = Resources.Load<AudioClip>("Bump");
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
            case "Jump":

                audiosrc.PlayOneShot(Jump);
            break;
            //case "Run":
              //  audiosrc.PlayOneShot(Run);
               // break;
            case "Bump":
                audiosrc.PlayOneShot(Bump);
                break;
        }
        }
         
}

