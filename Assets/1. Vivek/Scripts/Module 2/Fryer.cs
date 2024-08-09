using System.Collections;
using System.Collections.Generic;
using MCQQuiz;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Fryer : KitchenEquipmentManager
{
    public XRBaseController rightController;
    public GameObject steamParticle, blisterOnHand;
    public GameObject chipsHL;

    public GameObject questionAnswerCanvas;

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
        QuestionAnswerManager.instance.WhenQuestionStart();
        questionAnswerCanvas.SetActive(true);
        //KitchenEquipmentCommon.Instance.exitCanvas.SetActive(true);
    }

    public void OnFrySnap()
    {
        StartCoroutine(OnFrySnapped());
    }

    public void ChangeWrongAnsCanvasPos()
    {
        wrongAnsCanvas.transform.position = completeCanvas.transform.position;
    }

    IEnumerator OnFrySnapped()
    {
        rightController.SendHapticImpulse(0.6f, 1f);
        steamParticle.SetActive(true);

        yield return new WaitForSeconds(0.7f);
        emergencyCanvas.SetActive(true);
        blisterOnHand.SetActive(true);
    }
}
