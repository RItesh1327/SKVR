using UnityEngine;
using DG.Tweening;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.VisualScripting;
using Utils;
using Utilities.Extensions;

public class BandAidsMovement : MonoBehaviour
{
    public ParticleSystem particleEffectPrefab; // Reference to the particle effect prefab

    private XRGrabInteractable grabInteractable;
    private Rigidbody rigidabody;
    public Transform handTransform;
    
    public GameObject FirstAidFinish;
    public GameObject FirstAidCheck;

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        rigidabody = GetComponent < Rigidbody>();
       // handTransform = FindHandTransform();
        particleEffectPrefab.GetComponent<ParticleSystem>();
    }

    Transform FindHandTransform()
    {
        GameObject handObject = GameObject.FindWithTag("BandAidPosition");

        if (handObject != null)
        {
            return handObject.transform;
        }

        Debug.LogError("Hand transform not found!");
        return null;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BandAidPosition") {
            MoveBandaidsToHand();
            this.gameObject.GetComponent<CustomXRGrabInteractable>().enabled = false;
        }

        
    }

    public void BandaidDisplay()
    {
        handTransform.GetComponent<MeshRenderer>().enabled = true;
    }
    public void BandaidDisplayOFf()
    {
        handTransform.GetComponent<MeshRenderer>().enabled = false;
    }
    void MoveBandaidsToHand()
    {
        Vector3 tablePosition = transform.position;
        Quaternion tableRotation = transform.rotation;

        transform.DOMove(handTransform.position, 2f)
            .SetEase(Ease.OutQuad)
            .OnStart(OnAnimationStart)
            .OnUpdate(UpdateHandTransform)
            .OnComplete(MoveComplete);

        transform.DORotate(handTransform.rotation.eulerAngles, 2f)
            .SetEase(Ease.OutQuad);

        this.gameObject.GetComponent<Outline>().enabled = false;
    }

    void OnAnimationStart()
    {
        if (grabInteractable != null)
        {
            grabInteractable.enabled = false;
        }

        if (GetComponent<Rigidbody>() != null)
        {
            GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    void UpdateHandTransform()
    {
        if (handTransform != null)
        {
            transform.DOMove(handTransform.position, 0.1f);
        }
    }

    void MoveComplete()
    {
        Debug.Log("Bandaids movement complete!");

        // Set the hand transform as the parent of the bandaid
        transform.parent = handTransform;
        FirstAidFinish.SetActive(true);
        FirstAidCheck.SetActive(false);
        // Play particle effect
        if (particleEffectPrefab != null)
        {
            // Instantiate the particle effect prefab at the bandaid's position
            //  ParticleSystem particleEffect = Instantiate(particleEffectPrefab, transform.position, Quaternion.identity);

            // Play the particle effect
            particleEffectPrefab.Play();

            // Destroy the particle effect GameObject after its duration
            Destroy(particleEffectPrefab.gameObject,5);
            handTransform.GetComponent<MeshRenderer>().enabled = false;
        }

        else
        {
            Debug.LogError("No particle");
        }

        // You can add any additional logic here after the movement is complete
    }


    public void StartBandaidsMovement(Transform targetHandTransform)
    {
        handTransform = targetHandTransform;
        MoveBandaidsToHand();
    }
}
