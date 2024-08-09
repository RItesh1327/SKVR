using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Module_3_Object_Handling : MonoBehaviour
{
    public ParticleSystem fireParticleSystem;

    private XRGrabInteractable grabInteractable;
    private bool isGrabbed = false;
    public GameObject socket1;
    public GameObject socket2;

    public Module_3_UI_Behaviour UIBehaviour;

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();

        if (grabInteractable == null)
        {
            Debug.LogError("XR Grab Interactable component not found!");
        }

        if (fireParticleSystem == null)
        {
            Debug.LogError("Fire Particle System component not assigned!");
        }

        if (fireParticleSystem != null)
        {
            fireParticleSystem.Stop();
        }

        // Find the GameObject with Module_3_UI_Behaviour
        GameObject uiBehaviourObject = GameObject.Find("XR Origin (XR Rig)");
        if (uiBehaviourObject == null)
        {
            Debug.Log("No ui object");
        }
        // Get the Module_3_UI_Behaviour component
        UIBehaviour = uiBehaviourObject.GetComponent<Module_3_UI_Behaviour>();
    }

    void Update()
    {
       
        Debug.Log("Obj Behaviour" + UIBehaviour.MissionState);
        if (grabInteractable != null)
        {
            socket1.SetActive(true);
            socket2.SetActive(true);
            if (grabInteractable.isSelected && !isGrabbed && UIBehaviour.hand)
            {
                isGrabbed = true;
                ObjectHeldCorrectly();
            }
            else if (!grabInteractable.isSelected && isGrabbed)
            {
                isGrabbed = false;
                StopParticle();
              
                Debug.Log("Object let go");
            }
        }
    }

   public  void ObjectHeldCorrectly()
    {
        Debug.Log("Object held correctly");
        
            PlayParticle();
        UIBehaviour.WrongAnswer.SetBool("wrong", true);
        UIBehaviour.MissionState = Module.missionState.lost;
        UIBehaviour.gameplay = false;
        // Add your custom logic here
        UIBehaviour.DisplayReset();
    }

    void PlayParticle()
    {
        if (!IsParticleSystemPlaying())
        {
            fireParticleSystem.Play();
        }
    }

    void StopParticle()
    {
        if (fireParticleSystem != null)
        {
            fireParticleSystem.Stop();
        }
    }

    // Function to check if the particle system is playing
    bool IsParticleSystemPlaying()
    {
        return fireParticleSystem != null && fireParticleSystem.isPlaying;
    }
}
