using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction.Toolkit;

public class CollectFoodSlices : MonoBehaviour
{
    public XRBaseController rightController;
    public XRSlider slicerSlider;
    public GameObject bloodparticle;
    public GameObject emergencyCanvas;
    public Transform parentObj;
    int counter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FoodItem"))
        {
            other.transform.parent = parentObj;
            counter++;

            if (counter > 2)
            {
                rightController.SendHapticImpulse(0.6f, 1f);
                slicerSlider.enabled = false;
                slicerSlider.GetComponent<Outline>().enabled = false;
                emergencyCanvas.SetActive(true);
                bloodparticle.SetActive(true);
                Debug.Log("hit the blade");
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("FoodItem"))
        {
            collision.transform.parent = parentObj;
            counter++;

            if (counter > 2)
            {
                rightController.SendHapticImpulse(0.6f, 1f);
                slicerSlider.enabled = false;
                slicerSlider.GetComponent<Outline>().enabled = false;
                emergencyCanvas.SetActive(true);
                bloodparticle.SetActive(true);
                Debug.Log("hit the blade");
            }
        }
    }
}
