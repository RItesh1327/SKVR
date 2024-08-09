using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class KnifeHandlingManager : MonoBehaviour
{
    public static KnifeHandlingManager instance;

    public Transform player;
    public GameObject circle;

    public GameObject startPanel, welcomePanel;
    public GameObject infoPanel1,infoPanel2;
    public GameObject containerCanvas,dustbinCanvas;

    public GameObject knifeHandling;
    public GameObject wrongKnifePanel;
    public GameObject KnifeInfoPanel;
    public GameObject nextmodulePanel;
    public GameObject nextSatrtPanel;

    public GameObject[] knives;
    public Sprite[] KnivesInfo1;
    public Sprite[] KnivesInfo2;

    Vector3 playerInitialPos;

    private void Awake()
    {
        instance = this;
        playerInitialPos = player.transform.localPosition;
    }

    #region INFO OF KNIVES WHEN HOVER
    public void AddHoverEvent()
    {
        for (int i = 0; i < knives.Length; i++)
        {
            knives[i].GetComponent<XRGrabInteractable>().enabled = true;
            knives[i].GetComponent<XRGrabInteractable>().hoverEntered.AddListener(OnHoverEnter);
        }
    }


    public void OnHoverEnter(HoverEnterEventArgs args)
    {
        for (int i = 0; i < knives.Length; i++)
        {
            if (knives[i].GetComponent<XRGrabInteractable>().isSelected)
            {
                return;
            }
        }

        GameObject go = args.interactableObject.ConvertTo<GameObject>();

        for (int i = 0; i < knives.Length; i++)
        {
            if (knives[i] == go)
            {
                KnifeInfoPanel.transform.GetChild(0).GetComponent<Image>().sprite = KnivesInfo1[i];
                KnifeInfoPanel.transform.GetChild(1).GetComponent<Image>().sprite = KnivesInfo2[i];

                KnifeInfoPanel.transform.GetChild(0).gameObject.SetActive(true);
                KnifeInfoPanel.transform.GetChild(1).gameObject.SetActive(false);
                KnifeInfoPanel.SetActive(true);

                KnifeInfoPanel.transform.parent = go.transform;
                KnifeInfoPanel.transform.localPosition = new Vector3(0f, 0.5f, 0f);
                KnifeInfoPanel.transform.localRotation = Quaternion.Euler(0, 90, 0);
                Debug.Log("Knife Info");
            }
        }
    }
    #endregion

    public void OnClickStartpanel()
    {
        player.GetComponent<CharacterControllerDriver>().locomotionProvider.GetComponent<DynamicMoveProvider>().enabled = true;
        circle.SetActive(true);
        circle.GetComponent<Collider>().enabled = true;
        startPanel.SetActive(false);
    }

    public void OnClickWelcomePanel()
    {
        knifeHandling.SetActive(true);
        infoPanel1.SetActive(true);
        welcomePanel.SetActive(false);
    }

    public void OnClickInfoPanel1()
    {
        infoPanel2.SetActive(true);
        infoPanel1.SetActive(false);
    }

    public void OnClickInfoPanel2()
    {
        AddHoverEvent();
        containerCanvas.SetActive(true);
        dustbinCanvas.SetActive(true);
        infoPanel2.SetActive(false);
    }

    public void OnClickNextModule()
    {
        player.transform.localPosition = playerInitialPos;
        player.GetComponent<CharacterControllerDriver>().locomotionProvider.GetComponent<DynamicMoveProvider>().enabled = false;
        nextSatrtPanel.SetActive(true);
        knifeHandling.SetActive(false);
        nextmodulePanel.SetActive(false);
    }
}
