using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionReset : MonoBehaviour
{
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    public GameObject fireexample;
    public GameObject panel;
    public GameObject panel1;
    private bool hasBeenActivated = true;
    public GameObject resetObj;
   
   

    public void ResetObject()
    {
        // Destroy the current GameObject
        Destroy(gameObject);

        // Instantiate a new GameObject at the initial position
        GameObject newObject = Instantiate(gameObject, initialPosition, Quaternion.identity);

        // Attach this script to the new GameObject
        PositionReset resettableScript = newObject.GetComponent<PositionReset>();
        if (resettableScript == null)
        {
            // If the script is not already attached, attach it
            resettableScript = newObject.AddComponent<PositionReset>();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        // Store the initial position and rotation when the object is initialized
        initialPosition = new Vector3(0,0,0);
        initialRotation = Quaternion.Euler(0, 0, 0);
    }

    // Function to reset the position and rotation to initial values
    public void ResetToInitialPositionAndRotation()
    {
        // Set the position and rotation to the initial values
        StartCoroutine(reseting());
    }

    // Function to check if the GameObject's name is "ClassK" and can only be called once
    public void CheckAndActivateOnce(GameObject panel)
    {
        if (!hasBeenActivated && gameObject.name == "Fire_Ext_foam (1)")
        {
            // Your logic for the one-time activation goes here
            Debug.Log("Activated for ClassK");
            panel.SetActive(true);
            fireexample.SetActive(true);
            
            this.gameObject.SetActive(false);
            // Set the bool to true to prevent further activations
            hasBeenActivated = true;
        }
    }
   public IEnumerator reseting()
    {

        yield return new WaitForSeconds (.1f);
        resetObj.transform.localPosition = initialPosition;
        resetObj.transform.localRotation = initialRotation;
    }
    public void MakeitFalse()
    {
        hasBeenActivated = false;
    }

    // Update is called once per frame
    void Update()
    {
        // You can add any additional update logic here if needed
    }

}
