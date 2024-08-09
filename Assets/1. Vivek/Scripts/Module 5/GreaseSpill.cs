using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Content.Interaction;

public class GreaseSpill : MonoBehaviour
{
    public XRKnob ovenKnob;
    public ParticleSystem flameParticle, smokeParticle;

    public Animator wrongAns;
    public GameObject emergencyCanvas, wrongAnsCanvas, quizCanvas, exitCanvas;
    public int questionCounter;
    int QuestionCanvasCounter;

    public GameObject[] emergencyPanels;
    public QuestionManager[] questionManager;

    private void Start()
    {
        SetOptionListener();
    }

    public void SetOptionListener()
    {
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

    public void OnTaskDone()
    {
        QuestionCanvasCounter++;
        if (QuestionCanvasCounter >= emergencyPanels.Length)
        {
            quizCanvas.SetActive(true);
            emergencyCanvas.SetActive(false);
        }
        else
        {
            emergencyPanels[QuestionCanvasCounter - 1].SetActive(false);
            emergencyPanels[QuestionCanvasCounter].SetActive(true);
        }
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

    public void OnRotateKnob()
    {
        if (ovenKnob.value != 0)
        {
            var emission = flameParticle.emission;
            emission.rateOverTime = (ovenKnob.value * 5);

            var emission1 = smokeParticle.emission;
            emission1.rateOverTime = (ovenKnob.value * 2);

            flameParticle.GetComponent<AudioSource>().volume = ovenKnob.value;
        }
        else
        {
            flameParticle.gameObject.SetActive(false);
            smokeParticle.gameObject.SetActive(false);
            ovenKnob.enabled = false;
            ovenKnob.GetComponent<Outline>().enabled = false;
            OnTaskDone();
        }
    }

    public void OnClickQuestionPanelNext()
    {
        quizCanvas.SetActive(false);
        exitCanvas.SetActive(true);
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
                emergencyPanels[QuestionCanvasCounter].SetActive(false);
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
            option.GetComponent<Image>().color = new Color32(255, 98, 98, 255);
            wrongAns.SetBool("isWrong", true);
            yield return new WaitForSeconds(3f);
            wrongAns.SetBool("isWrong", false);
            wrongAnsCanvas.SetActive(true);
            emergencyCanvas.SetActive(false);
        }
    }
    #endregion
}
