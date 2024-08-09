using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DustbinFood : MonoBehaviour
{
    public static DustbinFood Instance;
    public int dustbinCounter;

    private void Awake()
    {
        Instance = this;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FoodItem"))
        {
            other.GetComponent<XRGrabInteractable>().enabled = false;
            dustbinCounter++;
        }

        if (dustbinCounter > 2 && ContainerFood.Instance.containerCounter > 2)
        {
            Debug.Log("this Module done");
            KnifeHandlingManager.instance.nextmodulePanel.SetActive(true);
        }
    }
}
