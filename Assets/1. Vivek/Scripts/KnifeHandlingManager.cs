using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeHandlingManager : MonoBehaviour
{
    public GameObject welcomePanel;
    public GameObject knifeHandling;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickWelcomePanel()
    {
        welcomePanel.SetActive(false);
        knifeHandling.SetActive(true);
    }
}
