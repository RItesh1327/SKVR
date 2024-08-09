using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonToggle : MonoBehaviour
{
    public GameObject panel;

    public GameObject coin;

    public void TurnOn()
    {
        panel.SetActive(true);
        coin.SetActive(false);
    }
    
    public void TurnOff()
    {
        panel.SetActive(false);
        coin.SetActive(true);
    }

}
