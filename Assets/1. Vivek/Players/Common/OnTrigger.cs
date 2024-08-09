using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTrigger : MonoBehaviour
{
    public GameObject collisionObj;
    public UnityEvent exitFromTrigger;
    public UnityEvent enterOnTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == collisionObj)
        {
            enterOnTrigger?.Invoke();
            //gameObject.GetComponent<Collider>().enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == collisionObj)
        {
            exitFromTrigger?.Invoke();
            //gameObject.GetComponent<Collider>().enabled = false;
        }
    }
}
