using UnityEngine;
using System.Collections;
using UnityEngine.XR.Interaction.Toolkit;

public class Module_3_ObjectManipulation : MonoBehaviour
{
    public GameObject yourTargetObject;
    public Transform yourNewParent;
    public GameObject specificChildToDisable;
    public SkinnedMeshRenderer skinnedMeshRendererToDisable;

    private void Start()
    {
        // Call the Cloth_Disable method to initiate the manipulation
        // Cloth_Disable();
    }

    public void Cloth_Disable()
    {
        StartCoroutine(DelayedManipulation());
    }

    private IEnumerator DelayedManipulation()
    {
        yield return new WaitForSeconds(0.1f);
        ManipulateObject(yourTargetObject, yourNewParent, specificChildToDisable);
    }

    public void ManipulateObject(GameObject targetObject, Transform newParent, GameObject specificChild)
    {


        BoxCollider boxCollider = specificChild.GetComponent<BoxCollider>();
        if (boxCollider == null)
        {
            // If BoxCollider is not present, add it
            boxCollider = specificChild.AddComponent<BoxCollider>();
        }

        Debug.Log($"Before setting isTrigger: {boxCollider.isTrigger}");

        // Enable or disable the isTrigger property based on your needs
        boxCollider.enabled = false;
        // Get the XRGrabInteractable component of the specific child
        XRGrabInteractable grabInteractable = specificChild.GetComponent<XRGrabInteractable>();
        if (grabInteractable != null)
        {
            grabInteractable.enabled = false;
        }

        // Disable the Rigidbody component of the specific child
        Rigidbody specificChildRigidbody = specificChild.GetComponent<Rigidbody>();
        if (specificChildRigidbody != null)
        {
            specificChildRigidbody.isKinematic = true;
        }

        // Disable the Skinned Mesh Renderer component of the specified object
        if (skinnedMeshRendererToDisable != null)
        {
            skinnedMeshRendererToDisable.enabled = false;
        }

        // Set the new parent, position, and rotation for the target object
        targetObject.transform.parent = newParent;
        targetObject.transform.localPosition = new Vector3(0.0016f, 0.0113f, 0.0598f);
        targetObject.transform.localRotation = Quaternion.Euler(65.692f, 129.492f, 56.388f);

        // Ensure the BoxCollider component is present on the specific child
        // ...


        Debug.Log($"After setting isTrigger: {boxCollider.isTrigger}");

        // ...


        // Reset the local rotation and position of the specific child
        specificChild.transform.localRotation = Quaternion.Euler(90, 0, 15);
        specificChild.transform.localPosition = Vector3.zero;

        // Debug the updated position and parenting of the object
        Debug.LogError($"Object position after manipulation: {targetObject.transform.position}");
        Debug.LogError($"Object parent after manipulation: {targetObject.transform.parent}");
    }

}
