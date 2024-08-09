using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Module_3_PanHandling : MonoBehaviour
{
    public CharacterController Player;
    public GameObject InfoPanel;
    public List<GameObject> HotObjects;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject obj in HotObjects)
        {
            Debug.Log(obj.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GloveCheck()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        
    }
    public void welcomeOff()
    {
        InfoPanel.SetActive(false);
        DisplayHotObjects();
    }
    private void DisplayHotObjects()
    {
        
            foreach (GameObject obj in HotObjects)
            {
                obj.SetActive(true);
            }
        Debug.Log("Welcome OFf!");
    }

}
