using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnEnterCircle : MonoBehaviour
{
    public GameObject player;
    public GameObject[] enableObjects;
    public GameObject[] disableObjects;
    public UnityEvent OnEnter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            for (int i = 0; i < enableObjects.Length; i++)
            {
                enableObjects[i].SetActive(true);
            }

            for (int i = 0; i < disableObjects.Length; i++)
            {
                disableObjects[i].SetActive(false);
            }

            GetComponent<Collider>().enabled = false;
            OnEnter?.Invoke();

            gameObject.SetActive(false);
        }
    }
}
