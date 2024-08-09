using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction.Toolkit;

public class Oven : KitchenEquipmentManager
{
    public XRBaseController rightController;
    public GameObject panHL;
    public GameObject pan;
    public GameObject chicken;
    public GameObject blisters;
    public XRKnob ovenKnob;
    public ParticleSystem flameParticle,smokeParticle;
    public ParticleSystem waterParticle, flameOnHandParticle;

    void Start()
    {
        circle.SetActive(true);

        var emission = flameParticle.emission;
        emission.rateOverTime = 0;

        var emission1 = smokeParticle.emission;
        emission1.rateOverTime = 0;

        SetOptionListener();
    }

    public override void OnClickStep1Canvas()
    {
        base.OnClickStep1Canvas();
        panHL.SetActive(true);
    }

    public override void OnclickCompleteCanvas()
    {
        base.OnclickCompleteCanvas();
        KitchenEquipmentCommon.Instance.exitCanvas.SetActive(true);
    }

    public void ChangeWrongAnsCanvasPos()
    {
        wrongAnsCanvas.transform.position = completeCanvas.transform.position;
    }

    public void OnChickenSnap()
    {
        chicken.GetComponent<Rigidbody>().isKinematic = true;
        chicken.GetComponent<Rigidbody>().useGravity = false;
        chicken.transform.SetParent(pan.transform);
        ovenKnob.GetComponent<Outline>().enabled = true;
        ovenKnob.enabled = true;
    }

    public void OnRotateKnob()
    {
        if (ovenKnob.value != 1)
        {
            var emission = flameParticle.emission;
            emission.rateOverTime = (ovenKnob.value * 5);

            var emission1 = smokeParticle.emission;
            emission1.rateOverTime = (ovenKnob.value * 2);

            flameParticle.GetComponent<AudioSource>().volume = ovenKnob.value;
        }
        else
        {
            rightController.SendHapticImpulse(0.6f, 1f);
            ovenKnob.enabled = false;
            ovenKnob.GetComponent<Outline>().enabled=false;
            flameOnHandParticle.gameObject.SetActive(true);
            blisters.SetActive(true);
            emergencyCanvas.SetActive(true);
        }
    }
}
