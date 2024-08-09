using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ContainerFood : MonoBehaviour
{
    public static ContainerFood Instance;
    public int containerCounter;

    private void Awake()
    {
        Instance = this;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FoodItem"))
        {
            other.GetComponent<XRGrabInteractable>().enabled = false;
            containerCounter++;
        }

        if (containerCounter > 2 && DustbinFood.Instance.dustbinCounter > 2)
        {
            Debug.Log("this Module done");
            KnifeHandlingManager.instance.nextmodulePanel.SetActive(true);
        }
    }
}
