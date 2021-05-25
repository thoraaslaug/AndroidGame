using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShake : MonoBehaviour
{
    public float power = 0.7f;
    public float duration = 1.0f;
    public Transform camera;
    public float slowdown = 1.0f;
    public bool shouldShake = false;

    Vector3 startPosition;
    float initialDuration;

    public void Start()
    {
        camera = Camera.main.transform;
        startPosition = camera.localPosition;
        initialDuration = duration;

    }

    public void Update()
    {
        if (shouldShake)
        {
            if(duration > 0)
            {
                camera.localPosition = startPosition + Random.insideUnitSphere * power;
                duration -= Time.deltaTime * slowdown;
            }
            else
            {
                shouldShake = false;
                duration = initialDuration;
                camera.localPosition = startPosition;

            }
        }
    }
}
