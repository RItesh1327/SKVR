using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Knifes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<XRGrabInteractable>().selectEntered.AddListener(OnSelectEnter);
        GetComponent<XRGrabInteractable>().selectExited.AddListener(OnSelectExit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSelectEnter(SelectEnterEventArgs args)
    {
        GetComponent<Collider>().isTrigger = true;
    }

    public void OnSelectExit(SelectExitEventArgs args)
    {
        GetComponent<Collider>().isTrigger = false;
    }
}
