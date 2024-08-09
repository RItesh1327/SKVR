using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;

public class pin : MonoBehaviour
{
    public GameObject holder;
    public GameObject Pass1;
    public GameObject Pass2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.parent != null)
        {
         //   Debug.Log(this.transform.parent.name);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "pintrigger")
        {
            // Disable/Enable components as needed
            GetComponent<CustomXRGrabInteractable>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = false;
            holder.GetComponent<Outline>().enabled = true;
            holder.GetComponent<CustomXRGrabInteractable>().enabled = true;
            StartCoroutine(DelayedUnparent());
            if (this.gameObject.name == "pasted__Pin1")
            {
                Pass1.SetActive(false);
                Pass2.SetActive(true);
            }
        }
    }

    private IEnumerator DelayedUnparent()
    {
        // Introduce a slight delay to ensure proper physics interactionss
        yield return new WaitForSeconds(1);

       this.gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

}
