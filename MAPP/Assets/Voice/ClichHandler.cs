using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;
[RequireComponent(typeof(Collider))]
public class ClichHandler : MonoBehaviour
{

    public UnityEvent upEvent;
    public UnityEvent downEvent;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        downEvent?.Invoke();
    }
    private void OnMouseUp()
    {
        upEvent?.Invoke();
    }
}
