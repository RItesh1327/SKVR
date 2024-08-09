using System.Collections;
using System.Collections.Generic;
using Unity.XR.OpenVR;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.OpenXR.Features.Interactions;

public class ShowSphere : MonoBehaviour
{ 
    public float rayDistance = 0.5f; // Distance of the raycast
    public ButtonManager Bm;

    private MeshRenderer currentlySelectedRenderer = null;  // MeshRenderer of the currently selected object
    private RaycastHit hit;

    private void Start()
    {
        
    }

    void Update()
    {/*
        Ray ray = new Ray(transform.position, transform.forward);
        
        // Handle previously selected object (if any)
        if (currentlySelectedRenderer != null)
        {
            currentlySelectedRenderer.enabled = false;
            currentlySelectedRenderer = null;
        }

        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            // If the raycast hits an object with the "select" tag
            if (hit.collider.CompareTag("select"))
            {
                //currentlySelectedRenderer = hit.transform.GetComponent<MeshRenderer>();
                //if (currentlySelectedRenderer != null)
                {
                    //currentlySelectedRenderer.enabled = true;
                    if (hit.collider.gameObject.name == "SELECT_Knife" && Input.GetButton("XRI_Right_TriggerButton"))
                    {
                        Debug.Log("hit");
                        Bm.S3_showSphere.SetActive(false);
                        Bm.S3_WholeScenario.SetActive(true);
                        Bm.S3_Dummy.SetActive(true);
                        hit.collider.gameObject.SetActive(false);
                        Bm.aSource.PlayOneShot(Bm.clickHazardClip);
                        
                    } else if (hit.collider.gameObject.name == "SELECT_Spill" && Input.GetButton("XRI_Right_TriggerButton"))
                    {
                        Debug.Log("hit");
                        Bm.S1_showSphere.SetActive(false);
                        Bm.S1_WholeScenario.SetActive(true);
                        Bm.S1_Dummy.SetActive(true);
                        hit.collider.gameObject.SetActive(false);
                        Bm.aSource.PlayOneShot(Bm.clickHazardClip);

                    } else if (hit.collider.gameObject.name == "SELECT_hot" && Input.GetButton("XRI_Right_TriggerButton"))
                    {
                        Debug.Log("hit");
                        Bm.S2_showSphere.SetActive(false); 
                        Bm.S2_WholeScenario.SetActive(true);
                        Bm.S2_Dummy.SetActive(true);
                        hit.collider.gameObject.SetActive(false);
                        Bm.aSource.PlayOneShot(Bm.clickHazardClip);

                    } else if (hit.collider.gameObject.name == "SELECT_Fire" && Input.GetButton("XRI_Right_TriggerButton"))
                    {
                        Debug.Log("hit");
                        Bm.S4_showSphere.SetActive(false);
                        Bm.S4_WholeScenario.SetActive(true);
                        Bm.S4_UI.SetActive(true);
                        hit.collider.gameObject.SetActive(false);
                        Bm.aSource.PlayOneShot(Bm.clickHazardClip);

                    } else if (hit.collider.gameObject.name == "SELECT_elec" && Input.GetButton("XRI_Right_TriggerButton"))
                    {
                        Debug.Log("hit");
                        Bm.S5_showSphere.SetActive(false);
                        Bm.S5_WholeScenario.SetActive(true);
                        Bm.S5_UI.SetActive(true);
                        hit.collider.gameObject.SetActive(false);
                        Bm.aSource.PlayOneShot(Bm.clickHazardClip);

                    } else if (hit.collider.gameObject.name == "SELECT_steam" && Input.GetButton("XRI_Right_TriggerButton"))
                    {
                        Debug.Log("hit");
                        Bm.S6_showSphere.SetActive(false);
                        Bm.S6_WholeScenario.SetActive(true);
                        Bm.S6_UI.SetActive(true);
                        hit.collider.gameObject.SetActive(false);
                        Bm.aSource.PlayOneShot(Bm.clickHazardClip);

                    } else if (hit.collider.gameObject.name == "SELECT_Chemical" && Input.GetButton("XRI_Right_TriggerButton"))
                    {
                        Debug.Log("hit");
                        Bm.S7_showSphere.SetActive(false);
                        Bm.S7_WholeScenario.SetActive(true);
                        Bm.S7_UI.SetActive(true);
                        hit.collider.gameObject.SetActive(false);
                        Bm.aSource.PlayOneShot(Bm.clickHazardClip);

                    } else if (hit.collider.gameObject.name == "SELECT_lifting" && Input.GetButton("XRI_Right_TriggerButton"))
                    {
                        Debug.Log("hit");
                        Bm.S8_showSphere.SetActive(false);
                        Bm.S8_WholeScenario.SetActive(true);
                        Bm.S8_UI.SetActive(true);
                        hit.collider.gameObject.SetActive(false);
                        Bm.aSource.PlayOneShot(Bm.clickHazardClip);

                    } else if (hit.collider.gameObject.name == "SELECT_fall" && Input.GetButton("XRI_Right_TriggerButton"))
                    {
                        Debug.Log("hit");
                        Bm.S9_showSphere.SetActive(false);
                        Bm.S9_WholeScenario.SetActive(true);
                        Bm.S9_UI.SetActive(true);
                        hit.collider.gameObject.SetActive(false);
                        Bm.aSource.PlayOneShot(Bm.clickHazardClip);

                    } else if (hit.collider.gameObject.name == "SELECT_CongestedArea" && Input.GetButton("XRI_Right_TriggerButton"))
                    {
                        Debug.Log("hit");
                        Bm.S10_showSphere.SetActive(false);
                        Bm.S10_WholeScenario.SetActive(true);
                        Bm.S10_UI.SetActive(true);
                        hit.collider.gameObject.SetActive(false);
                        Bm.aSource.PlayOneShot(Bm.clickHazardClip);

                    } else if (hit.collider.gameObject.name == "SELECT_exits" && Input.GetButton("XRI_Right_TriggerButton"))
                    {
                        Debug.Log("hit");
                        Bm.S11_showSphere.SetActive(false);
                        Bm.S11_WholeScenario.SetActive(true);
                        Bm.S11_UI.SetActive(true);
                        hit.collider.gameObject.SetActive(false);
                        Bm.aSource.PlayOneShot(Bm.clickHazardClip);

                    } else if (hit.collider.gameObject.name == "SELECT_ppe" && Input.GetButton("XRI_Right_TriggerButton"))
                    {
                        Debug.Log("hit");
                        Bm.S12_showSphere.SetActive(false);
                        Bm.S12_WholeScenario.SetActive(true);
                        Bm.S12_UI.SetActive(true);
                        hit.collider.gameObject.SetActive(false);
                        Bm.aSource.PlayOneShot(Bm.clickHazardClip);
                    }
                }
            }
        }*/
    }
}
