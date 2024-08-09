using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Utilities.Extensions;

public class AssignColliders : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<XRGrabInteractable>();
        Debug.Log("Satrt Called");
        //gameObject.GetComponent<XRGrabInteractable>().colliders[0] = gameObject.GetComponent<Collider>();
        //StartCoroutine(AddGrabComponent());
    }

    /*IEnumerator AddGrabComponent()
    {
        if (gameObject.GetComponent<XRGrabInteractable>() != null)
        {
            yield return new WaitForSeconds(1f);
            Destroy(gameObject.GetComponent<XRGrabInteractable>());

            yield return new WaitForSeconds(1f);
            gameObject.AddComponent<XRGrabInteractable>();

            

            gameObject.GetComponent<XRGrabInteractable>().useDynamicAttach = true;
            yield return new WaitForSeconds(1f);

            if (gameObject.GetComponent<XRGrabInteractable>().colliders[0] == null)
            {
                gameObject.GetComponent<XRGrabInteractable>().colliders[0] = gameObject.GetComponent<MeshCollider>();
                Debug.Log("Collider Added");
            }
        }
    }*/
}
