using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KitchenEquipmentCommon : MonoBehaviour
{
    public static KitchenEquipmentCommon Instance;
    public Animator wrongAns;

    public Transform player;

    public GameObject startPanel, welcomePanel;
    public GameObject EquipmentselectionPanel;
    public GameObject exitCanvas;

    private void Awake()
    {
        Instance = this;
    }

    public void OnClickStartpanel()
    {
        startPanel.SetActive(false);
        welcomePanel.SetActive(true);
    }

    public void OnClickWelcomePanel()
    {
        EquipmentselectionPanel.SetActive(true);
        welcomePanel.SetActive(false);
    }

    public void OnClickEquipment(GameObject equipment)
    {
        player.GetComponent<CharacterControllerDriver>().locomotionProvider.GetComponent<DynamicMoveProvider>().enabled = true;
        equipment.SetActive(true);
        EquipmentselectionPanel.SetActive(false);
    }

    public void OnClickResetModule()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnClickExitApp()
    {
        Application.Quit();
    }
}
