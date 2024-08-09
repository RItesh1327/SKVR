using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Utilities.Extensions;

public class AssignColliders : MonoBehaviour
{
    public List<GameObject> childObjects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator AddGrabComponent()
    {
        yield return new WaitForSeconds(1f);

        for (int i = 0; i < transform.childCount; i++)
        {
            int index = i;

            if (transform.GetChild(index).GetComponent<XRGrabInteractable>() == null)
            {
                childObjects.Add(transform.GetChild(index).gameObject);
                transform.GetChild(index).gameObject.AddComponent<XRGrabInteractable>();

                transform.GetChild(index).GetComponent<XRGrabInteractable>().useDynamicAttach = true;
                transform.GetChild(index).GetComponent<XRGrabInteractable>().colliders[0] = transform.GetChild(index).GetComponent<MeshCollider>();
                Debug.Log("Add");
            }
        }
    }

    private void OnTransformChildrenChanged()
    {
        for (int i = 0;i < childObjects.Count;i++)
        {
            if (childObjects[i].GetComponent<XRGrabInteractable>() != null)
            {
                if (childObjects[i].GetComponent<XRGrabInteractable>().isSelected)
                {
                    return;
                }
            }
        }

        if (childObjects.Count != transform.childCount)
        {
            Debug.Log("child changed");
            GetComponent<AudioSource>().Play();

            for (int i = 0; i < transform.childCount; i++)
            {
                int index = i;
                if (transform.GetChild(index).GetComponent<XRGrabInteractable>() != null)
                {
                    childObjects.Clear();
                    Destroy(transform.GetChild(index).GetComponent<XRGrabInteractable>());
                    Debug.Log("removed");
                }
            }

            StartCoroutine(AddGrabComponent());
        }
    }
}
