using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;

public class Attach : MonoBehaviour
{
    public Collider colliderObject; // Assign the collider object in the Inspector
    public GameObject panel3; // Assign the collider object in the Inspector
    public GameObject panel2; // Assign the collider object in the Inspector
    public GameObject Extinguisher; // Assign the collider object in the Inspector
    public ParticleSystem fire;
    // Start is called before the first frame update
    void Start()
    {
        // Check if the colliderObject is assigned
        if (colliderObject == null)
        {
            Debug.LogError("Collider object not assigned in the Inspector!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Your update logic (if any) goes here
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider is the one we want to attach
        if (other == colliderObject)
        {
            if(fire!= null)
            {
                fire.Stop();
            }
            // Set the position of the collider object to the trigger object's position
            colliderObject.GetComponent<CustomXRGrabInteractable>().enabled = false;
            colliderObject.GetComponent<Rigidbody>().isKinematic = true;
            colliderObject.transform.position = transform.position;
            colliderObject.transform.rotation = transform.rotation;
            this.gameObject.SetActive(false);
            if (other.gameObject.activeSelf)
            {
                StartCoroutine(resetinteractable());
            }
            panel2.SetActive(false);
            panel3.SetActive(true);
            Extinguisher.SetActive(true);
        }
    }

    IEnumerator resetinteractable()
    {
        yield return new WaitForSeconds(2);
        colliderObject.GetComponent<CustomXRGrabInteractable>().enabled = true;
    }
}
