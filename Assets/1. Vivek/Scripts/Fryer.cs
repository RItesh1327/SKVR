using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Fryer : KitchenEquipmentManager
{
    public XRBaseController rightController;
    public GameObject steamParticle,flameOnHandParticle;
    public GameObject chipsHL;

    // Start is called before the first frame update
    void Start()
    {
        circle.SetActive(true);
        SetOptionListener();
    }

    public override void OnClickStep1Canvas()
    {
        base.OnClickStep1Canvas();
        chipsHL.SetActive(true);
    }

    public override void OnclickCompleteCanvas()
    {
        base.OnclickCompleteCanvas();
        KitchenEquipmentCommon.Instance.exitCanvas.SetActive(true);
    }

    public void OnFrySnap()
    {
        rightController.SendHapticImpulse(0.6f, 1f);
        steamParticle.SetActive(true);
        //flameOnHandParticle.SetActive(true);
        emergencyCanvas.SetActive(true);
    }
}
