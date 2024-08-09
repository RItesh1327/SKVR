using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class Slicer : KitchenEquipmentManager
{
    public GameObject blade;
    public Vector3 targetRotation;

    public GameObject hamHL;

    public GameObject arrowHL;
    public GameObject handleSlider;
    public GameObject slicerSlider;

    public GameObject questionCanvas;


    private void Start()
    {
        circle.SetActive(true);
        SetOptionListener();
    }

    #region BLADE ROTATION
    IEnumerator LerpFunction(Quaternion endValue, float duration)
    {
        float time = 0;
        Quaternion startValue = blade.transform.localRotation;
        while (time < duration)
        {
            blade.transform.localRotation = Quaternion.Lerp(startValue, endValue, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        blade.transform.localRotation = endValue;

        targetRotation.x = targetRotation.x + 90f;
        if (targetRotation.x >= 360)
            targetRotation.x = 0;

        StartCoroutine(LerpFunction(Quaternion.Euler(targetRotation), 0.4f));
    }
    #endregion

    public void OnHandleSliderValueChange()
    {
        if (handleSlider.GetComponent<XRSlider>().value == 1)
        {
            StartCoroutine(LerpFunction(Quaternion.Euler(targetRotation), 0.4f));
            handleSlider.GetComponent<Outline>().enabled = false;
            handleSlider.GetComponent<XRSlider>().enabled = false;
            arrowHL.SetActive(false);

            slicerSlider.GetComponent<XRSlider>().enabled = true;
            slicerSlider.GetComponent<Outline>().enabled = true;
        }
    }

    public override void OnClickStep1Canvas()
    {
        base.OnClickStep1Canvas();
        hamHL.SetActive(true);
    }

    public override void OnclickCompleteCanvas()
    {
        base.OnclickCompleteCanvas();
        KitchenEquipmentCommon.Instance.exitCanvas.SetActive(true);
    }

    public void OnClickQuestionPanelNext()
    {
        questionCanvas.SetActive(false);
        KitchenEquipmentCommon.Instance.exitCanvas.SetActive(true);
    }
}
