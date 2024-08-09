using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;
using TMPro;

public class ButtonManager : MonoBehaviour
{
    public GameObject home;
    public GameObject scenarios;
    
    //scorekeeper
    public int score = 0;
    public int attempted = 0;
    public TextMeshProUGUI txt;
    public TextMeshProUGUI attempted_txt;
    

    public GameObject ui_Hazards;
    public LocomotionSystem LMsyst;
    public ActionBasedContinuousMoveProvider ABCMprov;

    public Animator wrongAns;
    public AudioSource aSource;
    public AudioClip rightAnsClip;
    public AudioClip wrongAnsClip;
    public AudioClip clickHazardClip;
    
    //Identify 1
    public GameObject S1_WholeScenario;
    public GameObject S1_Dummy;
    public GameObject S1_wrong1;
    public GameObject S1_wrong2;
    public GameObject S1_correct;
    public GameObject S1_question;
    public GameObject S1_info;
    public GameObject S1_showSphere;
    
    //Identify 2
    public GameObject S2_WholeScenario;
    public GameObject S2_Dummy;
    public GameObject S2_wrong1;
    public GameObject S2_wrong2;
    public GameObject S2_correct;
    public GameObject S2_question;
    public GameObject S2_info;
    public GameObject S2_showSphere;

    //Identify 3
    public GameObject S3_WholeScenario;
    public GameObject S3_Dummy;
    public GameObject S3_wrong1;
    public GameObject S3_wrong2;
    public GameObject S3_correct;
    public GameObject S3_question;
    public GameObject S3_info;
    public GameObject S3_showSphere;

    
    //Identify 4
    public GameObject S4_WholeScenario;
    public GameObject S4_UI;
    public GameObject S4_wrong1;
    public GameObject S4_wrong2;
    public GameObject S4_correct;
    public GameObject S4_question;
    public GameObject S4_info;
    public GameObject S4_showSphere;

    
    //Identify 5
    public GameObject S5_WholeScenario;
    public GameObject S5_UI;
    public GameObject S5_wrong1;
    public GameObject S5_wrong2;
    public GameObject S5_correct;
    public GameObject S5_question;
    public GameObject S5_info;
    public GameObject S5_showSphere;

    
    //Identify 6
    public GameObject S6_WholeScenario;
    public GameObject S6_UI;
    public GameObject S6_wrong1;
    public GameObject S6_wrong2;
    public GameObject S6_correct;
    public GameObject S6_question;
    public GameObject S6_info;
    public GameObject S6_showSphere;

    
    //Identify 7
    public GameObject S7_WholeScenario;
    public GameObject S7_UI;
    public GameObject S7_wrong1;
    public GameObject S7_wrong2;
    public GameObject S7_correct;
    public GameObject S7_question;
    public GameObject S7_info;  
    public GameObject S7_showSphere;

    
    //Identify 8
    public GameObject S8_WholeScenario;
    public GameObject S8_UI;
    public GameObject S8_wrong1;
    public GameObject S8_wrong2;
    public GameObject S8_correct;
    public GameObject S8_question;
    public GameObject S8_info;
    public GameObject S8_showSphere;

    
    //Identify 9
    public GameObject S9_WholeScenario;
    public GameObject S9_UI;
    public GameObject S9_wrong1;
    public GameObject S9_wrong2;
    public GameObject S9_correct;
    public GameObject S9_question;
    public GameObject S9_info;
    public GameObject S9_showSphere;

    
    //Identify 10
    public GameObject S10_WholeScenario;
    public GameObject S10_UI;
    public GameObject S10_wrong1;
    public GameObject S10_wrong2;
    public GameObject S10_correct;
    public GameObject S10_question;
    public GameObject S10_info; 
    public GameObject S10_showSphere;

    
    //Identify 11
    public GameObject S11_WholeScenario;
    public GameObject S11_UI;
    public GameObject S11_wrong1;
    public GameObject S11_wrong2;
    public GameObject S11_correct;
    public GameObject S11_question;
    public GameObject S11_info;
    public GameObject S11_showSphere;

    
    //Identify 12
    public GameObject S12_WholeScenario;
    public GameObject S12_UI;
    public GameObject S12_wrong1;
    public GameObject S12_wrong2;
    public GameObject S12_correct;
    public GameObject S12_question;
    public GameObject S12_info;
    public GameObject S12_showSphere;
    
    //Identify 13
    public GameObject S13_WholeScenario;
    public GameObject S13_UI;
    public GameObject S13_wrong1;
    public GameObject S13_wrong2;
    public GameObject S13_correct;
    public GameObject S13_question;
    public GameObject S13_info;
    public GameObject S13_showSphere;
    
    //Identify 14
    public GameObject S14_WholeScenario;
    public GameObject S14_UI;
    public GameObject S14_wrong1;
    public GameObject S14_wrong2;
    public GameObject S14_correct;
    public GameObject S14_question;
    public GameObject S14_info;
    public GameObject S14_showSphere;
    
    //Identify 15
    public GameObject S15_WholeScenario;
    public GameObject S15_UI;
    public GameObject S15_wrong1;
    public GameObject S15_wrong2;
    public GameObject S15_correct;
    public GameObject S15_question;
    public GameObject S15_info;
    public GameObject S15_showSphere;
    
    //Identify 16
    public GameObject S16_WholeScenario;
    public GameObject S16_UI;
    public GameObject S16_wrong1;
    public GameObject S16_wrong2;
    public GameObject S16_correct;
    public GameObject S16_question;
    public GameObject S16_info;
    public GameObject S16_showSphere;
    
    //Identify 17
    public GameObject S17_WholeScenario;
    public GameObject S17_UI;
    public GameObject S17_wrong1;
    public GameObject S17_wrong2;
    public GameObject S17_correct;
    public GameObject S17_question;
    public GameObject S17_info;
    public GameObject S17_showSphere;
    
    //Identify 18
    public GameObject S18_WholeScenario;
    public GameObject S18_UI;
    public GameObject S18_wrong1;
    public GameObject S18_wrong2;
    public GameObject S18_correct;
    public GameObject S18_question;
    public GameObject S18_info;
    public GameObject S18_showSphere;
    
    //Identify 19
    public GameObject S19_WholeScenario;
    public GameObject S19_UI;
    public GameObject S19_wrong1;
    public GameObject S19_wrong2;
    public GameObject S19_correct;
    public GameObject S19_question;
    public GameObject S19_info;
    public GameObject S19_showSphere;
    
    //Identify 20
    public GameObject S20_WholeScenario;
    public GameObject S20_UI;
    public GameObject S20_wrong1;
    public GameObject S20_wrong2;
    public GameObject S20_correct;
    public GameObject S20_question;
    public GameObject S20_info;
    public GameObject S20_showSphere;
    
    //Identify 21
    public GameObject S21_WholeScenario;
    public GameObject S21_UI;
    public GameObject S21_wrong1;
    public GameObject S21_wrong2;
    public GameObject S21_correct;
    public GameObject S21_question;
    public GameObject S21_info;
    public GameObject S21_showSphere;

    //Identify 22
    public GameObject S22_WholeScenario;
    public GameObject S22_UI;
    public GameObject S22_wrong1;
    public GameObject S22_wrong2;
    public GameObject S22_correct;
    public GameObject S22_question;
    public GameObject S22_info;
    public GameObject S22_showSphere;
    
    //Identify 23
    public GameObject S23_WholeScenario;
    public GameObject S23_UI;
    public GameObject S23_wrong1;
    public GameObject S23_wrong2;
    public GameObject S23_correct;
    public GameObject S23_question;
    public GameObject S23_info;
    public GameObject S23_showSphere;
    
    //Identify 24
    public GameObject S24_WholeScenario;
    public GameObject S24_UI;
    public GameObject S24_wrong1;
    public GameObject S24_wrong2;
    public GameObject S24_correct;
    public GameObject S24_question;
    public GameObject S24_info;
    public GameObject S24_showSphere;
    
    //Identify 25
    public GameObject S25_WholeScenario;
    public GameObject S25_UI;
    public GameObject S25_wrong1;
    public GameObject S25_wrong2;
    public GameObject S25_correct;
    public GameObject S25_question;
    public GameObject S25_info;
    public GameObject S25_showSphere;
    
    //Identify 26
    public GameObject S26_WholeScenario;
    public GameObject S26_UI;
    public GameObject S26_wrong1;
    public GameObject S26_wrong2;
    public GameObject S26_correct;
    public GameObject S26_question;
    public GameObject S26_info;
    public GameObject S26_showSphere;


    public AudioSource wrongClick;
    public AudioSource rightClick;
    public void IncorrectAnswerClick(GameObject go)
    {
        for (int i = 0; i < go.transform.childCount; i++)
        {
            if(go.transform.GetChild(i).GetComponent<Outline>() != null)
            {
                go.transform.GetChild(i).GetComponent<Outline>().enabled = true;
            }
        }

        //aSource.PlayOneShot(wrongAnsClip);
        wrongClick.Play();
        AttemptedQuestions();
    }

    public void CorrectAnsClick()
    {
        //aSource.PlayOneShot(rightAnsClip);
        rightClick.Play();
        AttemptedQuestions();
        score++;
        txt.text = "Score:<color=\"green\"> " + score.ToString() + "/26";
    }

    public void AttemptedQuestions()
    {
        attempted++;
        attempted_txt.text = "Attempted:<color=\"green\"> " + attempted.ToString() + "/26";

        if (attempted == 26)
        {
            Debug.Log("congratulations");
            attempted_txt.text = "congratulations!";
        }
    }

    public void WrongAnsClick()
    {
        StartCoroutine(OnClickWrongAns());
    }

    IEnumerator OnClickWrongAns()
    {
        wrongAns.SetBool("isWrong", true);
        yield return new WaitForSeconds(5f);
        wrongAns.SetBool("isWrong", false);
    }


    public void MenuScenarios()
    {
        home.SetActive(false);
        scenarios.SetActive(true);
    }
    public void MenuBack()
    {
        home.SetActive(true);
        scenarios.SetActive(false);
    }
    
    public void LoadScenario1()
    {
        SceneManager.LoadScene(1);
    }
    
    public void LoadScenario2()
    {
        SceneManager.LoadScene(2);
    }

    public void OnClickRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //******************************************
    //Module 1 Intro UI
    public GameObject Page0;
    public GameObject Page1;
    public GameObject Page2;
    public GameObject TutorialPage;

    public AudioSource Intro1;
    public AudioSource Intro2;
    public AudioSource Intro3;
    public void NextPage()
    {
        Intro1.Stop();
        Intro2.Play();
        Page0.SetActive(false);
        Page1.SetActive(true);
    }
    
    public void NextPage2()
    {
        Intro2.Stop();
        Intro3.Play();
        Page1.SetActive(false);
        Page2.SetActive(true);
    }

    public void LoadTutorialPage()
    {
        Intro3.Stop();
        Page2.SetActive(false);
        TutorialPage.SetActive(true);
    }

    //********************************************
    //TODO Identify Hazards

    public void StartHazards()
    {
        //start sim
        ui_Hazards.SetActive(false);
        //S1_WholeScenario.SetActive(true);
        LMsyst.enabled = true;
        ABCMprov.enabled = true;

    }
    public void Knife_Question_Option1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S3_WholeScenario);
        S3_question.SetActive(false);
        S3_wrong1.SetActive(true);
        StartCoroutine(knife_wait5());
    }
    
    public void Knife_Question_Option2()
    {
        //correct
        CorrectAnsClick();

        S3_question.SetActive(false);
        S3_correct.SetActive(true);
        StartCoroutine(knife_wait5());
    }
    
    public void Knife_Question_Option3()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S3_WholeScenario);
        S3_question.SetActive(false);
        S3_wrong2.SetActive(true);
        StartCoroutine(knife_wait5());
    }

    public void Knife_Question_Next()
    {
        S3_info.SetActive(false);
        //S3_WholeScenario.SetActive(false);
        S3_Dummy.SetActive(false);
        //S4_WholeScenario.SetActive(true);
        
    }
    
    public void Hot_Question_Option1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S2_WholeScenario);
        S2_question.SetActive(false);
        S2_wrong1.SetActive(true);
        StartCoroutine(hot_wait5());
    }
    
    public void Hot_Question_Option2()
    {
        //correct
        CorrectAnsClick();

        S2_question.SetActive(false);
        S2_correct.SetActive(true);
        StartCoroutine(hot_wait5());
    }
    
    public void Hot_Question_Option3()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S2_WholeScenario);
        S2_question.SetActive(false);
        S2_wrong2.SetActive(true);
        StartCoroutine(hot_wait5());
    }

    public void Hot_Question_Next()
    {
        S2_info.SetActive(false);
        //S2_WholeScenario.SetActive(false);
        S2_Dummy.SetActive(false);
        //S3_WholeScenario.SetActive(true);
    }
    
    public void Slip_Question_Option1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S1_WholeScenario);
        S1_question.SetActive(false);
        S1_wrong1.SetActive(true);
        StartCoroutine(slip_wait5());
    }
    
    public void Slip_Question_Option3()
    {
        //correct
        CorrectAnsClick();

        S1_question.SetActive(false);
        S1_correct.SetActive(true);
        StartCoroutine(slip_wait5());
    }
    
    public void Slip_Question_Option2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S1_WholeScenario);
        S1_question.SetActive(false);
        S1_wrong2.SetActive(true);
        StartCoroutine(slip_wait5());
    }

    public void Slip_Question_Next()
    {
        S1_info.SetActive(false);
        //S1_WholeScenario.SetActive(false);
        S1_Dummy.SetActive(false);
        //S2_WholeScenario.SetActive(true);
    }
    
    public void Flame_Question_Option1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S4_WholeScenario);
        S4_question.SetActive(false);
        S4_wrong1.SetActive(true);
        StartCoroutine(flame_wait5());
    }
    
    public void Flame_Question_Option3()
    {
        //correct
        CorrectAnsClick();

        S4_question.SetActive(false);
        S4_correct.SetActive(true);
        StartCoroutine(flame_wait5());
    }
    
    public void Flame_Question_Option2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S4_WholeScenario);
        S4_question.SetActive(false);
        S4_wrong2.SetActive(true);
        StartCoroutine(flame_wait5());
    }

    public void Flame_Question_Next()
    {
        S4_info.SetActive(false);
        //S4_WholeScenario.SetActive(false);
        S4_UI.SetActive(false);
        //S5_WholeScenario.SetActive(true);
    }
    
    public void Electric_Question_Option1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S5_WholeScenario);
        S5_question.SetActive(false);
        S5_wrong1.SetActive(true);
        StartCoroutine(elec_wait5());
    }
    
    public void Electric_Question_Option3()
    {
        //correct
        CorrectAnsClick();

        S5_question.SetActive(false);
        S5_correct.SetActive(true);
        StartCoroutine(elec_wait5());
    }
    
    public void Electric_Question_Option2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S5_WholeScenario);
        S5_question.SetActive(false);
        S5_wrong2.SetActive(true);
        StartCoroutine(elec_wait5());
    }

    public void Electric_Question_Next()
    {
        S5_info.SetActive(false);
        //S5_WholeScenario.SetActive(false);
        S5_UI.SetActive(false);
        //S6_WholeScenario.SetActive(true);
    }
    
    public void Steam_Question_Option1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S6_WholeScenario);
        S6_question.SetActive(false);
        S6_wrong1.SetActive(true);
        StartCoroutine(steam_wait5());
    }
    
    public void Steam_Question_Option3()
    {
        //correct
        CorrectAnsClick();

        S6_question.SetActive(false);
        S6_correct.SetActive(true);
        StartCoroutine(steam_wait5());
    }
    
    public void Steam_Question_Option2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S6_WholeScenario);
        S6_question.SetActive(false);
        S6_wrong2.SetActive(true);
        StartCoroutine(steam_wait5());
    }

    public void Steam_Question_Next()
    {
        S6_info.SetActive(false);
        //S6_WholeScenario.SetActive(false);
        S6_UI.SetActive(false);
        //S7_WholeScenario.SetActive(true);
    }

    public void Chem_Question_Option1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S7_WholeScenario);
        S7_question.SetActive(false);
        S7_wrong1.SetActive(true);
        StartCoroutine(chem_wait5());
    }
    
    public void Chem_Question_Option3()
    {
        //correct
        CorrectAnsClick();

        S7_question.SetActive(false);
        S7_correct.SetActive(true);
        StartCoroutine(chem_wait5());
    }
    
    public void Chem_Question_Option2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S7_WholeScenario);
        S7_question.SetActive(false);
        S7_wrong2.SetActive(true);
        StartCoroutine(chem_wait5());
    }

    public void Chem_Question_Next()
    {
        S7_info.SetActive(false);
        //S7_WholeScenario.SetActive(false);
        S7_UI.SetActive(false);
        //S8_WholeScenario.SetActive(true);
    }
    
    public void Lift_Question_Option1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S8_WholeScenario);
        S8_question.SetActive(false);
        S8_wrong1.SetActive(true);
        StartCoroutine(lift_wait5());
    }
    
    public void Lift_Question_Option3()
    {
        //correct
        CorrectAnsClick();

        S8_question.SetActive(false);
        S8_correct.SetActive(true);
        StartCoroutine(lift_wait5());
    }
    
    public void Lift_Question_Option2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S8_WholeScenario);
        S8_question.SetActive(false);
        S8_wrong2.SetActive(true);
        StartCoroutine(lift_wait5());
    }

    public void Lift_Question_Next()
    {
        S8_info.SetActive(false);
        //S8_WholeScenario.SetActive(false);
        S8_UI.SetActive(false);
        //S9_WholeScenario.SetActive(true);
    }
    
    public void Fall_Question_Option1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S9_WholeScenario);
        S9_question.SetActive(false);
        S9_wrong1.SetActive(true);
        StartCoroutine(fall_wait5());
    }
    
    public void Fall_Question_Option3()
    {
        //correct
        CorrectAnsClick();

        S9_question.SetActive(false);
        S9_correct.SetActive(true);
        StartCoroutine(fall_wait5());
    }
    
    public void Fall_Question_Option2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S9_WholeScenario);
        S9_question.SetActive(false);
        S9_wrong2.SetActive(true);
        StartCoroutine(fall_wait5());
    }

    public void Fall_Question_Next()
    {
        S9_info.SetActive(false);
        //S9_WholeScenario.SetActive(false);
        S9_UI.SetActive(false);
        //S10_WholeScenario.SetActive(true);
    }

    
    public void Cong_Question_Option1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S10_WholeScenario);
        S10_question.SetActive(false);
        S10_wrong1.SetActive(true);
        StartCoroutine(cong_wait5());
    }
    
    public void Cong_Question_Option3()
    {
        //correct
        CorrectAnsClick();

        S10_question.SetActive(false);
        S10_correct.SetActive(true);
        StartCoroutine(cong_wait5());
    }
    
    public void Cong_Question_Option2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S10_WholeScenario);
        S10_question.SetActive(false);
        S10_wrong2.SetActive(true);
        StartCoroutine(cong_wait5());
    }

    public void Cong_Question_Next()
    {
        S10_info.SetActive(false);
        //S10_WholeScenario.SetActive(false);
        S10_UI.SetActive(false);
        //S11_WholeScenario.SetActive(true);
    }
    
    public void Exit_Question_Option1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S11_WholeScenario);
        S11_question.SetActive(false);
        S11_wrong1.SetActive(true);
        StartCoroutine(exit_wait5());
    }
    
    public void Exit_Question_Option3()
    {
        //correct
        CorrectAnsClick();

        S11_question.SetActive(false);
        S11_correct.SetActive(true);
        StartCoroutine(exit_wait5());
    }
    
    public void Exit_Question_Option2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S11_WholeScenario);
        S11_question.SetActive(false);
        S11_wrong2.SetActive(true);
        StartCoroutine(exit_wait5());
    }

    public void Exit_Question_Next()
    {
        S11_info.SetActive(false);
        //S11_WholeScenario.SetActive(false);
        S11_UI.SetActive(false);
        //S12_WholeScenario.SetActive(true);
    }
    
    public void PPE_Question_Option1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S12_WholeScenario);
        S12_question.SetActive(false);
        S12_wrong1.SetActive(true);
        StartCoroutine(ppe_wait5());
    }
    
    public void PPE_Question_Option3()
    {
        //correct
        CorrectAnsClick();

        S12_question.SetActive(false);
        S12_correct.SetActive(true);
        StartCoroutine(ppe_wait5());
    }
    
    public void PPE_Question_Option2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S12_WholeScenario);
        S12_question.SetActive(false);
        S12_wrong2.SetActive(true);
        StartCoroutine(ppe_wait5());
    }

    public void PPE_Question_Next()
    {
        S12_info.SetActive(false);
        //S12_WholeScenario.SetActive(false);
        S12_UI.SetActive(false);
    }
    //------------------------
    //New Ones
    public void SharpObject_Question_Wrong1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S13_WholeScenario);
        S13_question.SetActive(false);
        S13_wrong1.SetActive(true);
        StartCoroutine(SharpObject_wait5());
    }
    
    public void SharpObject_Question_Correct()
    {
        //correct
        CorrectAnsClick();

        S13_question.SetActive(false);
        S13_correct.SetActive(true);
        StartCoroutine(SharpObject_wait5());
    }
    
    public void SharpObject_Question_Wrong2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S13_WholeScenario);
        S13_question.SetActive(false);
        S13_wrong2.SetActive(true);
        StartCoroutine(SharpObject_wait5());
    }

    public void SharpObject_Question_Next()
    {
        S13_info.SetActive(false);
        S13_UI.SetActive(false);
    }
    public void ElectricHazard_Question_Wrong1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S14_WholeScenario);
        S14_question.SetActive(false);
        S14_wrong1.SetActive(true);
        StartCoroutine(ElectricHazard_wait5());
    }
    
    public void ElectricHazard_Question_Correct()
    {
        //correct
        CorrectAnsClick();

        S14_question.SetActive(false);
        S14_correct.SetActive(true);
        StartCoroutine(ElectricHazard_wait5());
    }
    
    public void ElectricHazard_Question_Wrong2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S14_WholeScenario);
        S14_question.SetActive(false);
        S14_wrong2.SetActive(true);
        StartCoroutine(ElectricHazard_wait5());
    }

    public void ElectricHazard_Question_Next()
    {
        S14_info.SetActive(false);
        S14_UI.SetActive(false);
    }
    public void ChemicalExposure_Question_Wrong1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S15_WholeScenario);
        S15_question.SetActive(false);
        S15_wrong1.SetActive(true);
        StartCoroutine(ChemicalExposure_wait5());
    }
    
    public void ChemicalExposure_Question_Correct()
    {
        //correct
        CorrectAnsClick();

        S15_question.SetActive(false);
        S15_correct.SetActive(true);
        StartCoroutine(ChemicalExposure_wait5());
    }
    
    public void ChemicalExposure_Question_Wrong2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S15_WholeScenario);
        S15_question.SetActive(false);
        S15_wrong2.SetActive(true);
        StartCoroutine(ChemicalExposure_wait5());
    }

    public void ChemicalExposure_Question_Next()
    {
        S15_info.SetActive(false);
        S15_UI.SetActive(false);
    }
    public void CrossContamination_Question_Wrong1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S16_WholeScenario);
        S16_question.SetActive(false);
        S16_wrong1.SetActive(true);
        StartCoroutine(CrossContamination_wait5());
    }
    
    public void CrossContamination_Question_Correct()
    {
        //correct
        CorrectAnsClick();

        S16_question.SetActive(false);
        S16_correct.SetActive(true);
        StartCoroutine(CrossContamination_wait5());
    }
    
    public void CrossContamination_Question_Wrong2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S16_WholeScenario);
        S16_question.SetActive(false);
        S16_wrong2.SetActive(true);
        StartCoroutine(CrossContamination_wait5());
    }

    public void CrossContamination_Question_Next()
    {
        S16_info.SetActive(false);
        S16_UI.SetActive(false);
    }
    
    //-----------------------------------------------
    
    public void FoodAllergens_Question_Wrong1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S17_WholeScenario);
        S17_question.SetActive(false);
        S17_wrong1.SetActive(true);
        StartCoroutine(FoodAllergens_wait5());
    }
    
    public void FoodAllergens_Question_Correct()
    {
        //correct
        CorrectAnsClick();

        S17_question.SetActive(false);
        S17_correct.SetActive(true);
        StartCoroutine(FoodAllergens_wait5());
    }
    
    public void FoodAllergens_Question_Wrong2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S17_WholeScenario);
        S17_question.SetActive(false);
        S17_wrong2.SetActive(true);
        StartCoroutine(FoodAllergens_wait5());
    }

    public void FoodAllergens_Question_Next()
    {
        S17_info.SetActive(false);
        S17_UI.SetActive(false);
    }
    
    //-----------------------------------------------
    
    public void ImproperStorage_Question_Wrong1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S18_WholeScenario);
        S18_question.SetActive(false);
        S18_wrong1.SetActive(true);
        StartCoroutine(ImproperStorage_wait5());
    }
    
    public void ImproperStorage_Question_Correct()
    {
        //correct
        CorrectAnsClick();

        S18_question.SetActive(false);
        S18_correct.SetActive(true);
        StartCoroutine(ImproperStorage_wait5());
    }
    
    public void ImproperStorage_Question_Wrong2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S18_WholeScenario);
        S18_question.SetActive(false);
        S18_wrong2.SetActive(true);
        StartCoroutine(ImproperStorage_wait5());
    }

    public void ImproperStorage_Question_Next()
    {
        S18_info.SetActive(false);
        S18_UI.SetActive(false);
    }
    
    //-----------------------------------------------
    
    public void InadequateVentilation_Question_Wrong1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S19_WholeScenario);
        S19_question.SetActive(false);
        S19_wrong1.SetActive(true);
        StartCoroutine(InadequateVentilation_wait5());
    }
    
    public void InadequateVentilation_Question_Correct()
    {
        //correct
        CorrectAnsClick();

        S19_question.SetActive(false);
        S19_correct.SetActive(true);
        StartCoroutine(InadequateVentilation_wait5());
    }
    
    public void InadequateVentilation_Question_Wrong2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S19_WholeScenario);
        S19_question.SetActive(false);
        S19_wrong2.SetActive(true);
        StartCoroutine(InadequateVentilation_wait5());
    }

    public void InadequateVentilation_Question_Next()
    {
        S19_info.SetActive(false);
        S19_UI.SetActive(false);
    }
    
    //-----------------------------------------------
    
    public void MachineryAccidents_Question_Wrong1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S20_WholeScenario);
        S20_question.SetActive(false);
        S20_wrong1.SetActive(true);
        StartCoroutine(MachineryAccidents_wait5());
    }
    
    public void MachineryAccidents_Question_Correct()
    {
        //correct
        CorrectAnsClick();

        S20_question.SetActive(false);
        S20_correct.SetActive(true);
        StartCoroutine(MachineryAccidents_wait5());
    }
    
    public void MachineryAccidents_Question_Wrong2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S20_WholeScenario);
        S20_question.SetActive(false);
        S20_wrong2.SetActive(true);
        StartCoroutine(MachineryAccidents_wait5());
    }

    public void MachineryAccidents_Question_Next()
    {
        S20_info.SetActive(false);
        S20_UI.SetActive(false);
    }
    
    //-----------------------------------------------
    
    public void WasteManagement_Question_Wrong1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S21_WholeScenario);
        S21_question.SetActive(false);
        S21_wrong1.SetActive(true);
        StartCoroutine(WasteManagement_wait5());
    }
    
    public void WasteManagement_Question_Correct()
    {
        //correct
        CorrectAnsClick();

        S21_question.SetActive(false);
        S21_correct.SetActive(true);
        StartCoroutine(WasteManagement_wait5());
    }
    
    public void WasteManagement_Question_Wrong2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S21_WholeScenario);
        S21_question.SetActive(false);
        S21_wrong2.SetActive(true);
        StartCoroutine(WasteManagement_wait5());
    }

    public void WasteManagement_Question_Next()
    {
        S21_info.SetActive(false);
        S21_UI.SetActive(false);
    }
    
    //-----------------------------------------------
    
    public void InadequateLabeling_Question_Wrong1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S22_WholeScenario);
        S22_question.SetActive(false);
        S22_wrong1.SetActive(true);
        StartCoroutine(InadequateLabeling_wait5());
    }
    
    public void InadequateLabeling_Question_Correct()
    {
        //correct
        CorrectAnsClick();

        S22_question.SetActive(false);
        S22_correct.SetActive(true);
        StartCoroutine(InadequateLabeling_wait5());
    }
    
    public void InadequateLabeling_Question_Wrong2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S22_WholeScenario);
        S22_question.SetActive(false);
        S22_wrong2.SetActive(true);
        StartCoroutine(InadequateLabeling_wait5());
    }

    public void InadequateLabeling_Question_Next()
    {
        S22_info.SetActive(false);
        S22_UI.SetActive(false);
    }
    
    //-----------------------------------------------
    
    public void InadequateSanitation_Question_Wrong1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S23_WholeScenario);
        S23_question.SetActive(false);
        S23_wrong1.SetActive(true);
        StartCoroutine(InadequateSanitation_wait5());
    }
    
    public void InadequateSanitation_Question_Correct()
    {
        //correct
        CorrectAnsClick();

        S23_question.SetActive(false);
        S23_correct.SetActive(true);
        StartCoroutine(InadequateSanitation_wait5());
    }
    
    public void InadequateSanitation_Question_Wrong2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S23_WholeScenario);
        S23_question.SetActive(false);
        S23_wrong2.SetActive(true);
        StartCoroutine(InadequateSanitation_wait5());
    }

    public void InadequateSanitation_Question_Next()
    {
        S23_info.SetActive(false);
        S23_UI.SetActive(false);
    }
    //-----------------------------------------------
    
    public void OverCrowded_Question_Wrong1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S24_WholeScenario);
        S24_question.SetActive(false);
        S24_wrong1.SetActive(true);
        StartCoroutine(OverCrowded_wait5());
    }
    
    public void OverCrowded_Question_Correct()
    {
        //correct
        CorrectAnsClick();

        S24_question.SetActive(false);
        S24_correct.SetActive(true);
        StartCoroutine(OverCrowded_wait5());
    }
    
    public void OverCrowded_Question_Wrong2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S24_WholeScenario);
        S24_question.SetActive(false);
        S24_wrong2.SetActive(true);
        StartCoroutine(OverCrowded_wait5());
    }

    public void OverCrowded_Question_Next()
    {
        S24_info.SetActive(false);
        S24_UI.SetActive(false);
    }
    //-----------------------------------------------
    
    public void Overhead_Question_Wrong1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S25_WholeScenario);
        S25_question.SetActive(false);
        S25_wrong1.SetActive(true);
        StartCoroutine(Overhead_wait5());
    }
    
    public void Overhead_Question_Correct()
    {
        //correct
        CorrectAnsClick();

        S25_question.SetActive(false);
        S25_correct.SetActive(true);
        StartCoroutine(Overhead_wait5());
    }
    
    public void Overhead_Question_Wrong2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S25_WholeScenario);
        S25_question.SetActive(false);
        S25_wrong2.SetActive(true);
        StartCoroutine(Overhead_wait5());
    }

    public void Overhead_Question_Next()
    {
        S25_info.SetActive(false);
        S25_UI.SetActive(false);
    }
    
    //-----------------------------------------------
    
    public void InadequatePestControl_Question_Wrong1()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S26_WholeScenario);
        S26_question.SetActive(false);
        S26_wrong1.SetActive(true);
        StartCoroutine(InadequatePestControl_wait5());
    }
    
    public void InadequatePestControl_Question_Correct()
    {
        //correct
        CorrectAnsClick();

        S26_question.SetActive(false);
        S26_correct.SetActive(true);
        StartCoroutine(InadequatePestControl_wait5());
    }
    
    public void InadequatePestControl_Question_Wrong2()
    {
        //incorrect
        //WrongAnsClick();
        IncorrectAnswerClick(S26_WholeScenario);
        S26_question.SetActive(false);
        S26_wrong2.SetActive(true);
        StartCoroutine(InadequatePestControl_wait5());
    }

    public void InadequatePestControl_Question_Next()
    {
        S26_info.SetActive(false);
        S26_UI.SetActive(false);
    }
    
    //coroutines--------------------------------------------------------------------------------------------------------
    public IEnumerator slip_wait5()
    {
        yield return new WaitForSeconds(5);
        S1_correct.SetActive(false);
        S1_wrong1.SetActive(false);
        S1_wrong2.SetActive(false);
        S1_info.SetActive(true);
    }
    
    public IEnumerator hot_wait5()
    {
        yield return new WaitForSeconds(5);
        S2_correct.SetActive(false);
        S2_wrong1.SetActive(false);
        S2_wrong2.SetActive(false);
        S2_info.SetActive(true);
    }
    public IEnumerator knife_wait5()
    {
        yield return new WaitForSeconds(5);
        S3_correct.SetActive(false);
        S3_wrong1.SetActive(false);
        S3_wrong2.SetActive(false);
        S3_info.SetActive(true);
    }
    
    public IEnumerator flame_wait5()
    {
        yield return new WaitForSeconds(5);
        S4_correct.SetActive(false);
        S4_wrong1.SetActive(false);
        S4_wrong2.SetActive(false);
        S4_info.SetActive(true);
    }
    
    public IEnumerator elec_wait5()
    {
        yield return new WaitForSeconds(5);
        S5_correct.SetActive(false);
        S5_wrong1.SetActive(false);
        S5_wrong2.SetActive(false);
        S5_info.SetActive(true);
    }
    
    public IEnumerator steam_wait5()
    {
        yield return new WaitForSeconds(5);
        S6_correct.SetActive(false);
        S6_wrong1.SetActive(false);
        S6_wrong2.SetActive(false);
        S6_info.SetActive(true);
    }
    
    public IEnumerator chem_wait5()
    {
        yield return new WaitForSeconds(5);
        S7_correct.SetActive(false);
        S7_wrong1.SetActive(false);
        S7_wrong2.SetActive(false);
        S7_info.SetActive(true);
    }
    
    public IEnumerator lift_wait5()
    {
        yield return new WaitForSeconds(5);
        S8_correct.SetActive(false);
        S8_wrong1.SetActive(false);
        S8_wrong2.SetActive(false);
        S8_info.SetActive(true);
    }
    
    public IEnumerator fall_wait5()
    {
        yield return new WaitForSeconds(5);
        S9_correct.SetActive(false);
        S9_wrong1.SetActive(false);
        S9_wrong2.SetActive(false);
        S9_info.SetActive(true);
    }
    
    public IEnumerator cong_wait5()
    {
        yield return new WaitForSeconds(5);
        S10_correct.SetActive(false);
        S10_wrong1.SetActive(false);
        S10_wrong2.SetActive(false);
        S10_info.SetActive(true);
    }
    
    public IEnumerator exit_wait5()
    {
        yield return new WaitForSeconds(5);
        S11_correct.SetActive(false);
        S11_wrong1.SetActive(false);
        S11_wrong2.SetActive(false);
        S11_info.SetActive(true);
    } 
    public IEnumerator ppe_wait5()
    {
        yield return new WaitForSeconds(5);
        S12_correct.SetActive(false);
        S12_wrong1.SetActive(false);
        S12_wrong2.SetActive(false);
        S12_info.SetActive(true);
    }
    
    public IEnumerator SharpObject_wait5()
    {
        yield return new WaitForSeconds(5);
        S13_correct.SetActive(false);
        S13_wrong1.SetActive(false);
        S13_wrong2.SetActive(false);
        S13_info.SetActive(true);
    }
    
    public IEnumerator ElectricHazard_wait5()
    {
        yield return new WaitForSeconds(5);
        S14_correct.SetActive(false);
        S14_wrong1.SetActive(false);
        S14_wrong2.SetActive(false);
        S14_info.SetActive(true);
    }
    public IEnumerator ChemicalExposure_wait5()
    {
        yield return new WaitForSeconds(5);
        S15_correct.SetActive(false);
        S15_wrong1.SetActive(false);
        S15_wrong2.SetActive(false);
        S15_info.SetActive(true);
    }
    
    public IEnumerator CrossContamination_wait5()
    {
        yield return new WaitForSeconds(5);
        S16_correct.SetActive(false);
        S16_wrong1.SetActive(false);
        S16_wrong2.SetActive(false);
        S16_info.SetActive(true);
    }
    public IEnumerator FoodAllergens_wait5()
    {
        yield return new WaitForSeconds(5);
        S17_correct.SetActive(false);
        S17_wrong1.SetActive(false);
        S17_wrong2.SetActive(false);
        S17_info.SetActive(true);
    }
    public IEnumerator ImproperStorage_wait5()
    {
        yield return new WaitForSeconds(5);
        S18_correct.SetActive(false);
        S18_wrong1.SetActive(false);
        S18_wrong2.SetActive(false);
        S18_info.SetActive(true);
    }
    public IEnumerator InadequateVentilation_wait5()
    {
        yield return new WaitForSeconds(5);
        S19_correct.SetActive(false);
        S19_wrong1.SetActive(false);
        S19_wrong2.SetActive(false);
        S19_info.SetActive(true);
    }
    public IEnumerator MachineryAccidents_wait5()
    {
        yield return new WaitForSeconds(5);
        S20_correct.SetActive(false);
        S20_wrong1.SetActive(false);
        S20_wrong2.SetActive(false);
        S20_info.SetActive(true);
    }
    public IEnumerator WasteManagement_wait5()
    {
        yield return new WaitForSeconds(5);
        S21_correct.SetActive(false);
        S21_wrong1.SetActive(false);
        S21_wrong2.SetActive(false);
        S21_info.SetActive(true);
    }
    public IEnumerator InadequateLabeling_wait5()
    {
        yield return new WaitForSeconds(5);
        S22_correct.SetActive(false);
        S22_wrong1.SetActive(false);
        S22_wrong2.SetActive(false);
        S22_info.SetActive(true);
    }
    public IEnumerator InadequateSanitation_wait5()
    {
        yield return new WaitForSeconds(5);
        S23_correct.SetActive(false);
        S23_wrong1.SetActive(false);
        S23_wrong2.SetActive(false);
        S23_info.SetActive(true);
    }
    public IEnumerator OverCrowded_wait5()
    {
        yield return new WaitForSeconds(5);
        S24_correct.SetActive(false);
        S24_wrong1.SetActive(false);
        S24_wrong2.SetActive(false);
        S24_info.SetActive(true);
    }
    public IEnumerator Overhead_wait5()
    {
        yield return new WaitForSeconds(5);
        S25_correct.SetActive(false);
        S25_wrong1.SetActive(false);
        S25_wrong2.SetActive(false);
        S25_info.SetActive(true);
    }
    public IEnumerator InadequatePestControl_wait5()
    {
        yield return new WaitForSeconds(5);
        S26_correct.SetActive(false);
        S26_wrong1.SetActive(false);
        S26_wrong2.SetActive(false);
        S26_info.SetActive(true);
    }

}
