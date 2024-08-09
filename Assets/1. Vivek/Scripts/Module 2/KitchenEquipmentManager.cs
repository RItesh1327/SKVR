using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class KitchenEquipmentManager : MonoBehaviour
{
    public GameObject circle;
    public GameObject infoPanel1, infoPanel2;
    public GameObject step1Canvas, emergencyCanvas, wrongAnsCanvas, completeCanvas;

    public GameObject kitchenEquipment;
    public Vector3 exitCanvasPos;

    public string completePanelWrong;
    public TextMeshProUGUI completePanelText;

    public int questionCounter;
    int emergencyCanvasCounter;
    int wrongAnsCounter;

    public GameObject[] emergencyPanels;
    public QuestionManager[] questionManager;

    public void SetOptionListener()
    {
        //wrongAnsCanvas.transform.localPosition = wrongAnsPos;
        KitchenEquipmentCommon.Instance.exitCanvas.transform.localPosition = exitCanvasPos;

        for (int i = 0; i < questionManager.Length; i++)
        {
            int ii = i;
            for (int j = 0; j < questionManager[ii].options.Length; j++)
            {
                int jj = j;
                questionManager[ii].options[jj].onClick.AddListener(() => OnClickAnyOption(questionManager[ii].options[jj]));
            }
        }
    }

    public void OnClickInfoPanel1()
    {
        infoPanel2.SetActive(true);
        infoPanel1.SetActive(false);
    }

    public void OnClickInfoPanel2()
    {
        step1Canvas.SetActive(true);
        infoPanel2.SetActive(false);
    }

    public virtual void OnClickStep1Canvas()
    {
        step1Canvas.SetActive(false);
    }

    public void OnClickTryAgain()
    {
        for (int i = 0; i < questionManager[questionCounter].options.Length; i++)
        {
            questionManager[questionCounter].options[i].interactable = true;
            questionManager[questionCounter].options[i].GetComponent<Image>().color = new Color32(87, 100, 169, 255);
        }

        emergencyCanvas.SetActive(true);
        wrongAnsCanvas.SetActive(false);
    }

    public void OnTaskDone()
    {
        emergencyCanvasCounter++;
        if (emergencyCanvasCounter >= emergencyPanels.Length)
        {
            completeCanvas.SetActive(true);
            emergencyCanvas.SetActive(false);
        }
        else
        {
            emergencyPanels[emergencyCanvasCounter - 1].SetActive(false);
            emergencyPanels[emergencyCanvasCounter].SetActive(true);
        }
    }

    public virtual void OnclickCompleteCanvas()
    {
        completeCanvas.SetActive(false);
    }

    #region OPTION CLICK EVENT
    public void OnClickAnyOption(Button option)
    {
        StartCoroutine(ClickOption(option));
    }

    IEnumerator ClickOption(Button option)
    {
        for (int i = 0; i < questionManager[questionCounter].options.Length; i++)
        {
            questionManager[questionCounter].options[i].interactable = false;
        }

        if (questionManager[questionCounter].rightAnswer == option)
        {
            option.GetComponent<Image>().color = new Color32(119, 184, 96, 255);
            yield return new WaitForSeconds(2f);

            if (questionManager[questionCounter].isAnyTask)
            {
                emergencyPanels[emergencyCanvasCounter].SetActive(false);
                questionManager[questionCounter].task?.Invoke();
            }
            else
            {
                OnTaskDone();
            }
            questionCounter++;
        }
        else
        {
            wrongAnsCounter++;
            option.GetComponent<Image>().color = new Color32(255, 98, 98, 255);
            KitchenEquipmentCommon.Instance.wrongAns.SetBool("isWrong", true);
            yield return new WaitForSeconds(3f);
            KitchenEquipmentCommon.Instance.wrongAns.SetBool("isWrong", false);
            wrongAnsCanvas.SetActive(true);
            emergencyCanvas.SetActive(false);

            if (wrongAnsCounter >= 2)
            {
                completePanelText.text = "EMERGENCY ALERT!\n\n" + completePanelWrong + "\n\nYou have completed this emergency training, however, you made a lot of mistakes along the way!";
            }
        }
    }
    #endregion
}
