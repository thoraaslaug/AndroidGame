using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShake : MonoBehaviour
{
     public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;

        float elapsed = 0.5f;

        while(elapsed < duration)
        {
            float x = Random.Range(-1f, 10f) * magnitude;
            float y = Random.Range(-1f, 10f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalPos;

    }
}
