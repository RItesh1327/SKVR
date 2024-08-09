using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction.Toolkit;

public class KnobController : MonoBehaviour
{
    public XRKnob knob;
   
    public GameObject PassPanel;
    public GameObject Lid;
    public GameObject heatoffpanel;
    public ParticleSystem flameParticle;
   
    public XRBaseController rightController;
    public AudioSource audioclip;
   
    
    // Start is called before the first frame update
    void Start()
    {
      //  knob.GetComponent<Outline>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnRotateKnob()
    {
        if (knob.value != 0)
        {
            var emission = flameParticle.emission;
            emission.rateOverTime = (knob.value * 5);
            audioclip.Play();
           

         //   flameParticle.GetComponent<AudioSource>().volume = knob.value;
        }
        else
        {
            rightController.SendHapticImpulse(0.6f, 1f);
            var emission = flameParticle.emission;
            emission.rateOverTime = 0;
            knob.enabled = false;
            knob.GetComponent<Outline>().enabled = false;
            PassPanel.SetActive(true);
            heatoffpanel.SetActive(false);
            Lid.SetActive(true);
            audioclip.Stop();
        }
    }

   
}
