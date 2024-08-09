using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEnterObject : MonoBehaviour
{
    public GameObject collisionObj;
    public UnityEvent onTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == collisionObj)
        {
            onTrigger?.Invoke();
        }
    }
}
