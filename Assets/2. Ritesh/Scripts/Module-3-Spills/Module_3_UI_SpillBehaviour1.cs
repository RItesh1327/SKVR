using UnityEngine;
using System.Collections.Generic;

public class Module_3_UI_SpillBehaviour1 : MonoBehaviour
{
    public List<GameObject> panels;
    public GameObject objPanel;
    public GameObject SpillPanel;

    private static Module_3_UI_SpillBehaviour1 instance;

    public static Module_3_UI_SpillBehaviour1 Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Module_3_UI_SpillBehaviour1>();

                if (instance == null)
                {
                    Debug.LogError("UIManager instance not found in the scene. Make sure it is added to a GameObject.");
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Debug.LogWarning("Duplicate UIManager instance found. Destroying the extra instance.");
            Destroy(gameObject);
        }

     //   HideAllPanels();
      //  HideObjectPanel();
    }

    public void ShowPanel(GameObject panel)
    {
        if (panel != null)
        {
            panel.SetActive(true);
        }
        else
        {
            Debug.LogError("Panel is null. Cannot show.");
        }
    }

    public void HidePanel(GameObject panel)
    {
        if (panel != null)
        {
            panel.SetActive(false);
        }
        else
        {
            Debug.LogError("Panel is null. Cannot hide.");
        }
    }

    public void ShowAllPanels()
    {
        foreach (GameObject panel in panels)
        {
            ShowPanel(panel);
        }
    }

    public void HideAllPanels()
    {
        foreach (GameObject panel in panels)
        {
            HidePanel(panel);
        }
    }

    public void HideObjectPanel()
    {
        if (objPanel != null)
        {
            objPanel.SetActive(false);
        }
        else
        {
            Debug.LogError("Object Panel is null. Cannot hide.");
        }
    }

    public void ShowObjectPanelWithDelay()
    {
        Invoke("ShowObjectPanel", 2f);
    }

    public void ShowObjectPanel()
    {
        if (objPanel != null)
        {
            objPanel.SetActive(true);
        }
        else
        {
            Debug.LogError("Object Panel is null. Cannot show.");
        }
    }
    public void DontShowObjectPanel()
    {
        if (objPanel != null)
        {
            objPanel.SetActive(false);
        }
        else
        {
            Debug.LogError("Object Panel is null. Cannot show.");
        }
    }



    public void ActivateGameObject(GameObject targetObject)
    {
        if (targetObject != null)
        {
            targetObject.SetActive(true);
        }
        else
        {
            Debug.LogError("Target object is null. Cannot activate.");
        }
    }

    public void SpillOption()
    {
        if (panels[3] != null)
        {
            panels[3].SetActive(true);
        }
        else
        {
            Debug.LogError("Spill object is null. Cannot activate.");
        }
    }

    public void SetSpillCleaned(bool isCleaned)
    {
        // Add your logic here based on whether the spill is cleaned or not
        if (isCleaned)
        {
            Debug.Log("Spill is cleaned!");
            // You can add more actions or UI changes here
        }
        else
        {
            Debug.Log("Spill is not cleaned!");
            // You can add more actions or UI changes here
        }
    }
     public void spillObjs()
    {
        if(SpillPanel != null)
        {
            SpillPanel.SetActive(true);
        }
        else
        {
            Debug.Log("No spill objects");
        }
    }
}
