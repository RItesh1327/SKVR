using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using MCQQuiz;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class SlipsPrevention : MonoBehaviour
{
    public GameObject circle1, circle2, circle3,circle4;
    public Transform player;
    public GameObject welcomePanel, infoPanel1, infoPanel2;
    public GameObject questionCanvas, wrongAnsCanvas, shoeCanvas, shoeSelectionCanvas, ladderCanvas;

    public GameObject WetFloor,ladder,firstHandHL;
    public Animator wrongAns;

    //public string completePanelWrong;
    //public TextMeshProUGUI completePanelText;

    public int questionCounter;
    int QuestionCanvasCounter;
    int wrongAnsCounter;

    public GameObject[] emergencyPanels;
    public QuestionManager[] questionManager;

    private void Start()
    {
        SetOptionListener();
    }

    public void OnClickWelcomePanel()
    {
        infoPanel1.SetActive(true);
        welcomePanel.SetActive(false);
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

    public void PlayerLook(Transform lookObj)
    {
        Vector3 dir = lookObj.transform.position - player.transform.position;
        Quaternion lookRot = Quaternion.LookRotation(dir);
        lookRot.x = 0;
        lookRot.z = 0;
        //player.transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, Mathf.Clamp01(3.0f * Time.maximumDeltaTime));
        player.transform.rotation = lookRot;
    }

    public void OnClickInfoPanel1()
    {
        circle1.SetActive(true);
        player.GetComponent<CharacterControllerDriver>().locomotionProvider.GetComponent<DynamicMoveProvider>().enabled = true;
        infoPanel1.SetActive(false);
    }

    public void OnClickInfoPanel2()
    {
        questionCanvas.SetActive(true);
        infoPanel2.SetActive(false);
    }

    public void OnClickTryAgain()
    {
        for (int i = 0; i < questionManager[questionCounter].options.Length; i++)
        {
            questionManager[questionCounter].options[i].interactable = true;
            questionManager[questionCounter].options[i].GetComponent<Image>().color = new Color32(87, 100, 169, 255);
        }

        questionCanvas.SetActive(true);
        wrongAnsCanvas.SetActive(false);
    }

    public void OnTaskDone()
    {
        QuestionCanvasCounter++;
        if (QuestionCanvasCounter >= emergencyPanels.Length)
        {
            circle3.SetActive(true);
            shoeSelectionCanvas.SetActive(false);
            questionCanvas.SetActive(false);
        }
        else
        {
            emergencyPanels[QuestionCanvasCounter - 1].SetActive(false);
            emergencyPanels[QuestionCanvasCounter].SetActive(true);
        }
    }

    public void OnClickShoeCanvas()
    {
        wrongAnsCanvas.transform.localPosition = shoeCanvas.transform.localPosition;
        OnTaskDone();
        shoeSelectionCanvas.SetActive(true);
        shoeCanvas.SetActive(false);
    }

    public void OnClickLadderCanvas()
    {
        firstHandHL.SetActive(true);
        //ladder.GetComponent<Outline>().enabled = true;
        ladder.GetComponentInChildren<ClimbInteractable>().enabled = true;
        ladderCanvas.SetActive(false);
    }

    int climbCounter;
    public void OnClimbLadder()
    {
        climbCounter++;
        if (climbCounter > 2)
        {
            //QuestionAnswerManager.instance.WhenQuestionStart();
            //lastQuestionCanvas.SetActive(true);
            circle4.SetActive(true);
            ladder.GetComponent<Outline>().enabled = false;
        }
    }

    public void OnClickResetModule()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnClickExitApp()
    {
        Application.Quit();
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
            wrongAnsCounter++;
            option.GetComponent<Image>().color = new Color32(255, 98, 98, 255);
            wrongAns.SetBool("isWrong", true);
            yield return new WaitForSeconds(3f);
            wrongAns.SetBool("isWrong", false);
            wrongAnsCanvas.SetActive(true);
            questionCanvas.SetActive(false);

            /*if (wrongAnsCounter >= 2)
            {
                completePanelText.text = "EMERGENCY ALERT!\n\n" + completePanelWrong + "\n\nYou have completed this emergency training, however, you made a lot of mistakes along the way!";
            }*/
        }
    }
    #endregion
}

