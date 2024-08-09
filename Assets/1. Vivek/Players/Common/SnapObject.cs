using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(Rigidbody))]
public class SnapObject : MonoBehaviour
{
    [SerializeField]
    public GameObject snapAnyObject;
    public bool connected;
    public GameObject[] SnapObject_new;
    public GameObject[] HideObject;
    public float distance;
    public UnityEvent onSnap;
    public bool isHideThis;

    private void OnTriggerEnter(Collider other)
    {
        if (!connected)
        {
            if (Vector3.Distance(transform.position, snapAnyObject.transform.position) < distance)
            {
                SnapObjectNearHighlight();
            }
        }
    }

    private void OnEnable()
    {
        connected = false;
        if (snapAnyObject.GetComponent<Outline>())
            snapAnyObject.GetComponent<Outline>().enabled = true;

        snapAnyObject.GetComponent<XRGrabInteractable>().enabled = true;
    }

    public void SnapObjectNearHighlight()
    {
        snapAnyObject.transform.SetPositionAndRotation(transform.position, transform.rotation);
        snapAnyObject.GetComponent<XRGrabInteractable>().enabled = false;

        snapAnyObject.GetComponent<Rigidbody>().useGravity = false;
        snapAnyObject.GetComponent<Rigidbody>().isKinematic = true;

        if (isHideThis)
            this.gameObject.SetActive(false);

        if (snapAnyObject.GetComponent<Outline>())
            snapAnyObject.GetComponent<Outline>().enabled = false;

        for (int i = 0; i < SnapObject_new.Length; i++)
        {
            SnapObject_new[i].SetActive(true);
        }

        for (int i = 0; i < HideObject.Length; i++)
        {
            if (HideObject[i] != null)
                HideObject[i].SetActive(false);
        }

        connected = true;
        onSnap?.Invoke();
    }

}
