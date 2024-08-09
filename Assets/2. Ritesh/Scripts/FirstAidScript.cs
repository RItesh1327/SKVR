using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstAidScript : MonoBehaviour
{
    public ParticleSystem particleEffect;
    public GameObject Emergency;
    public GameObject AssessPanel;
    public GameObject InfoPanel;
    public GameObject WaterTreatmentPanel;
    public GameObject WaterTreatmentPanel1;
    public GameObject GoToWaterPanel;
    public GameObject AfterTreatmentPanel;
    public Slider assessSlider;
    public GameObject water;
    public GameObject player;
    public Transform playerPos;
    public GameObject ovenMitt;
    public GameObject hand;
    public List<GameObject> FirstAidKits = new List<GameObject>();
    private void Start()
    {
        // Disable UI panels initially
        SetPanelStates(false, false, false, false, false);

        // Play particle effect
        particleEffect.Play();

        // Enable Emergency panel after a delay (adjust as needed)
        Invoke("EmergencyFn", 2f);
        player.transform.position = playerPos.position;
        water.SetActive(true);
        ovenMitt.SetActive(false);
        hand.SetActive(true);
    }

    public void EmergencyFn()
    {
        // Enable Emergency panel
        SetPanelStates(true, false, false, false, false);
    }

    public void AssessFn()
    {
        // Perform actions when the Assess button is clicked
        // You can add more logic or scenes transitions here
        Debug.Log("Assess button clicked!");
        SetPanelStates(false, true, false, false, false);
    }

    public void MoveToInfoPanel()
    {
        // Perform actions when moving to InfoPanel
        // You can add more logic or scenes transitions here
        Debug.Log("Moving to InfoPanel!");

        // Get the slider fill amount and use it as needed
        float sliderValue = assessSlider.value;
        Debug.Log("Slider Value: " + sliderValue);
        hand.GetComponent<BoxCollider>().isTrigger = false;
        // Move to InfoPanel
        SetPanelStates(false, false, true, false, false);
    }
    public void MoveToWater()
    {
        WaterTreatmentPanel1.SetActive(true);
        SetPanelStates(false, false, false, true, false);
    }
    public void SetHandInWater(bool inWater)
    {
        if (inWater)
        {
            // If hand is in water, move to Water Treatment Panel
            SetPanelStates(false, false, false, true, false);
            GoToWaterPanel.SetActive(false);
            particleEffect.Stop();
            foreach(GameObject first in FirstAidKits)
            {
                first.SetActive(true);
            }
        }
        else
        {
            // If hand is not in water, move to the appropriate panel based on the context
            // (Emergency, Assess, Info, etc.)
            // Add your own logic here
        }
    }
    public void bandage()
    {
        SetPanelStates(false, false, false, false, true);
    }
    public void disableAllPanels()
    {
        SetPanelStates(false, false, false, false,false);
    }
    private void SetPanelStates(bool emergency, bool assess, bool info, bool waterTreatment, bool after)
    {
        Emergency.SetActive(emergency);
        AssessPanel.SetActive(assess);
        InfoPanel.SetActive(info);
        WaterTreatmentPanel.SetActive(waterTreatment);
        AfterTreatmentPanel.SetActive(after);
    }
}
