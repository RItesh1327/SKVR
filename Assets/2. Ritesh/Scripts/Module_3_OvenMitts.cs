using System.Collections;
using UnityEngine;

public class Module_3_OvenMitts : MonoBehaviour
{
    public GameObject mittsToShow;
    public GameObject mittsToHide;
    public GameObject Hands;
    public float delayToShow = 0.1f;
    public Module_3_UI_Behaviour UImanager;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    public void playfunction()
    {
        StartCoroutine(ShowAndHideMitts());
    }

    // Coroutine to show and hide mitts
    IEnumerator ShowAndHideMitts()
    {
        while (true)
        {
            // Wait for a specific time
            yield return new WaitForSeconds(delayToShow);
            HideMitts();
            // Show the mitts
            ShowMitts();
            this.gameObject.SetActive(false);
            // Hide the mitts

            UImanager.hand = false;
            // Check if mittsToShow is null and log a message
            if (mittsToShow == null)
            {
                Debug.LogError("mittsToShow is null!");
            }

            // Check if mittsToHide is null and log a message
            if (mittsToHide == null)
            {
                Debug.LogError("mittsToHide is null!");
            }
        }
    }

    // Show the mitts
    void ShowMitts()
    {
        if (mittsToShow != null)
        {
            mittsToShow.SetActive(true);
           
        }
    }

    // Hide the mitts
    void HideMitts()
    {
        
        mittsToHide.SetActive(false);
        Hands.SetActive(false);
    }
}
