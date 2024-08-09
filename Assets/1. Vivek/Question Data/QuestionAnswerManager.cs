using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace MCQQuiz
{
    public class QuestionAnswerManager : MonoBehaviour
    {
        public static QuestionAnswerManager instance;
        public AudioSource aSource;
        public AudioClip wrongAnsClip, rightAnsClip;

        public GameObject questionPanel, resultPanel;
        public GameObject chatbotBtn, chatbotConversation;

        public int score = 0;
        public int QuestionIndex;
        public Button nextButton;
        public TextMeshProUGUI score_txt;

        public MCQQuizData QuestionData;
        public TextMeshProUGUI questionTxt;
        public Button[] options;

        private void Awake()
        {
            instance = this;
        }


        private void Start()
        {
            nextButton.gameObject.SetActive(false);
            questionTxt.text = "Question " + (QuestionIndex + 1) + "\n\n" + QuestionData.questions[QuestionIndex].question;
            for (int i = 0; i < QuestionData.questions[QuestionIndex].options.Length; i++)
            {
                options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QuestionData.questions[QuestionIndex].options[i];
            }
        }

        public void WhenQuestionStart()
        {
            chatbotBtn.SetActive(false);
            chatbotConversation.SetActive(false);
        }

        
        public void OnClickNext()
        {
            if (QuestionData.questions.Count == QuestionIndex)
            {
                Debug.Log("All done");
                questionPanel.SetActive(false);
                resultPanel.SetActive(true);
                resultPanel.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Congratulations ! \n\n Your score is \n" + score + "/" + QuestionData.questions.Count;
            }
            else
            {
                nextButton.gameObject.SetActive(false);
                questionTxt.text = "Question " + (QuestionIndex + 1) + "\n\n" + QuestionData.questions[QuestionIndex].question;
                for (int i = 0; i < options.Length; i++)
                {
                    options[i].interactable = true;
                    options[i].GetComponent<Image>().color = new Color32(87, 100, 169, 255);
                    options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QuestionData.questions[QuestionIndex].options[i];
                }
            }
        }

        public void OnOptionClick(int optionIndex)
        {
            for (int i = 0; i < options.Length; i++)
            {
                options[i].interactable = false;
            }

            if(QuestionData.questions[QuestionIndex].answerIndex == optionIndex)
            {
                options[optionIndex].GetComponent<Image>().color = new Color32(119, 184, 96, 255);
                CorrectAnsClick();
            }
            else
            {
                options[optionIndex].GetComponent<Image>().color = new Color32(255, 98, 98, 255);
                options[QuestionData.questions[QuestionIndex].answerIndex].GetComponent<Image>().color = new Color32(119, 184, 96, 255);
                aSource.PlayOneShot(wrongAnsClip);
            }
            QuestionIndex++;
            nextButton.gameObject.SetActive(true);
        }

        public void CorrectAnsClick()
        {
            aSource.PlayOneShot(rightAnsClip);
            score++;
            score_txt.text = "Score:<color=\"green\"> " + score.ToString() + "/" + QuestionData.questions.Count;
        }
    }
}

