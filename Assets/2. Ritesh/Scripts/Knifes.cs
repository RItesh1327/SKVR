using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Knifes : MonoBehaviour
{
    private void OnValidate()
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<XRGrabInteractable>().hoverEntered.AddListener(OnHoverEnter);
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
        KnifeHandlingManager.instance.KnifeInfoPanel.SetActive(false);
    }

    public void OnSelectExit(SelectExitEventArgs args)
    {
        GetComponent<Collider>().isTrigger = false;

        if (KnifeHandlingManager.instance.wrongKnifePanel.activeInHierarchy)
        {
            KnifeHandlingManager.instance.wrongKnifePanel.SetActive(false);
        }
    }
}
