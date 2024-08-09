using UnityEngine;
using System.Collections.Generic;

public class Module_3_Wiping : MonoBehaviour
{
    public float decreaseRate = 0.2f;
    public float targetScale = 0.2f;
    public Module_3_UI_SpillBehaviour1 uiManager; // Reference to the UIManager script

    private bool isOverlapping = false;
    public GameObject panelToClose;
    public GameObject panelToClose1;
    public GameObject panelToShow;
    public GameObject panelToBin;
    public GameObject Bin;
    public GameObject panelToStove;
    public GameObject panelToglove;
    public GameObject panelToFinal;
    public GameObject cloth;
    public GameObject glove;
    public GameObject Pan;
    public GameObject Pan1;
 
    private AudioManager audioManager;
    // Public list to store game objects
    public List<GameObject> objectsToCheck = new List<GameObject>();
    public List<GameObject> StoveobjectsToCheck = new List<GameObject>();
    public bool objectscecked;
    public bool Stoveobjectscecked;
    public ParticleSystem particle;
    public XRKnob nob;
    void Start()
    {
        // Add the GameObject to the list when the script starts
        //   objectsToCheck.Add(gameObject);
        objectscecked = false;
        nob.gameObject.GetComponent<Outline>().enabled = false;
     
    }

    void Update()
    {
        if (isOverlapping)
        {
            Debug.Log("Decreasing Scale!");
            DecreaseScale();

            // Check if UIManager is assigned
            if (uiManager != null)
            {
                uiManager.SetSpillCleaned(true); // Change the bool in UIManager
            }
        }

        // Check if all objects in the list have SetActive set to false
        if (CheckAllObjectsInactive() && objectscecked == false)
        {
            YourFunctionToCall(); // Call your function when all objects are inactive
        }

        if(CheckStoveObjectsInactive() && Stoveobjectscecked == false)
        {
            StoveIdentified();
        }

        UpdateParticleSystem();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cloth"))
        {
            isOverlapping = true;
            Debug.Log("Collision with cloth detected!");

            // Add the collided GameObject to the list
            objectsToCheck.Add(other.gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("cloth"))
        {
            isOverlapping = false;

            // Check if UIManager is assigned
            if (uiManager != null)
            {
                uiManager.SetSpillCleaned(false); // Reset the bool in UIManager
            }

            Debug.Log("Collision with cloth ended!");

            // Remove the exited GameObject from the list
            objectsToCheck.Remove(other.gameObject);
        }
    }

    void DecreaseScale()
    {
      //  Debug.Log("Decreasing Scale: " + transform.localScale);

        transform.localScale -= new Vector3(decreaseRate * Time.deltaTime, decreaseRate * Time.deltaTime, decreaseRate * Time.deltaTime);

        if (transform.localScale.x <= targetScale)
        {
            

            Debug.Log("Scale below target. Destroying GameObject!");

            // Remove the GameObject from the list before destroying
            objectsToCheck.Remove(gameObject);
            //   Destroy(gameObject);
            panelToShow.SetActive(false);
            panelToBin.SetActive(true);
            Bin.GetComponent<Outline>().enabled = true;
        }
    }
    public void MovetoStove()
    {
        Debug.LogError("moving to stove");
        panelToBin.SetActive(false);
        panelToStove.SetActive(true);
        Pan.SetActive(true);
        Pan1.SetActive(false);
        nob.gameObject.GetComponent<Outline>().enabled = true;
      //  Bin.GetComponent<Outline>().enabled = false;
    
    //  audioManager.PlayOneShot();
}
  
 
    float maxEmissionRate = 10.0f; // Adjust this value based on your particle system
    public bool knoboff = false;
    void UpdateParticleSystem()
    {
        if (particle != null) // Check if the Particle System reference is not null
        {
            // Assuming emission rate is used, you can modify this based on your particle system setup
            var emission = particle.emission;

            // Adjust emission rate based on knob's value using Mathf.Lerp
            float lerpedEmissionRate = Mathf.Lerp(maxEmissionRate, 0f, nob.value);

            // Set the lerped emission rate to the particle system's emission rate
            emission.rateOverTime = lerpedEmissionRate;

            // Output lerped emission rate to the console
            Debug.Log("Lerped Emission Rate: " + lerpedEmissionRate);

            // Check if the lerped emission rate is greater than 0.85
            if (nob.value > 0.95f && knoboff == false)
            {
                // Call your function when the lerped emission rate is greater than 0.85
                Knoboff();
            }
        }
        else
        {
            Debug.LogError("No particle system reference assigned.");
        }
    }

    void Knoboff()
    {
        // Implement the functionality you want to call when the lerped emission rate is greater than 0.85
        AfterStoveOff();
        knoboff = true;
    //    nob.gameObject.GetComponent<Outline>().enabled = false;
    }
    public void AfterStoveOff()
    {
        panelToStove.SetActive(false);
        panelToglove.SetActive(true);
      //cloth.SetActive(false);
        glove.SetActive(true);
    }

    public GameObject Hand_Glove;
    public GameObject Hand_;
    public void AfterPanPlaced()
    {
        panelToglove.SetActive(false);
        panelToClose1.SetActive(true);
        Hand_.SetActive(true);
        Hand_Glove.SetActive(false);
        foreach (GameObject obj in StoveobjectsToCheck)
        {
            obj.GetComponent<BoxCollider>().isTrigger = false;
        }
        nob.gameObject.GetComponent<Outline>().enabled = false;
    }

    bool CheckAllObjectsInactive()
    {
        // Check if all objects in the list have SetActive set to false
        foreach (GameObject obj in objectsToCheck)
        {
            if (obj.activeSelf)
            {
                return false;
            }
        }
        return true;
    }

    bool CheckStoveObjectsInactive()
    {
        // Check if all objects in the list have SetActive set to false
        foreach (GameObject obj in StoveobjectsToCheck)
        {
            if (obj.activeSelf)
            {
                return false;
            }
        }
        return true;
    }

    void YourFunctionToCall()
    {
        // Implement the functionality you want to call when all objects are inactive
        Debug.Log("All objects are inactive. Calling your function!");
        panelToClose.SetActive(false);
        panelToShow.SetActive(true);
        cloth.SetActive(true);
        objectscecked = true;
    }

    void StoveIdentified()
    {
        panelToClose1.SetActive(false);
        panelToFinal.SetActive(true);
        Stoveobjectscecked = true;
    } 
}
