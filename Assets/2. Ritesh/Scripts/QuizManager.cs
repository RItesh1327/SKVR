using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.IO;

public class QuizManager : MonoBehaviour
{
    public GameObject Quizpanel;

    public TMP_Text questionText;
    public Button[] choiceButtons;
    public TMP_Text timerText;
    public TMP_Text scoreText;

    private Question[] questions;
    private int currentQuestionIndex;
    private int correctAnswers;
    private int totalQuestions;
    private float timerDuration = 15f;
    private float timer;
    private float delayAfterQuestion = 2f;

    // Reference to the parent transform of the quiz UI
    public Transform quizParentTransform;
    public Transform quizParentTransform1;

    public Animator wronganswer;

    void Start()
    {
        InitializeQuiz();
    }

    void Update()
    {
        UpdateTimerUI();
    }

    void InitializeQuiz()
    {
        Quizpanel.SetActive(true);
        Debug.LogError("Quiz Started");
        // Reset variables to initial state
        currentQuestionIndex = 0;
        correctAnswers = 0;

        // Load questions from a ScriptableObject
        QuizData quizData = Resources.Load<QuizData>("QuizData");

        if (quizData != null)
        {
            questions = quizData.questions;
            totalQuestions = questions.Length;
        }
        else
        {
            Debug.LogError("QuizData not found. Make sure to create a QuizData asset in the Resources folder.");
        }

        UpdateScoreUI();
        DisplayQuestion();
        StartCoroutine(StartTimer());
    }

    void DisplayQuestion()
    {
        // Display the current question and choices on the UI
        questionText.text = questions[currentQuestionIndex].question;

        for (int i = 0; i < choiceButtons.Length; i++)
        {
            TMP_Text choiceText = choiceButtons[i].GetComponentInChildren<TMP_Text>();
            choiceText.text = questions[currentQuestionIndex].choices[i];

            // Reset the color to the original color (e.g., white)
            choiceText.color = Color.white;

            int choiceIndex = i; // Capture the current value of i for the lambda function
            choiceButtons[i].onClick.RemoveAllListeners();
            choiceButtons[i].onClick.AddListener(() => OnChoiceSelected(choiceIndex, choiceText));
        }
    }
    public void wrongAnimPlay()
    {
        wronganswer.SetBool("wrong", true);
    }
    void OnChoiceSelected(int choiceIndex, TMP_Text choiceText)
    {
        // Check if the selected choice is correct
        if (choiceIndex == questions[currentQuestionIndex].correctChoice)
        {
            // Correct answer
            choiceText.color = Color.green;
            correctAnswers++;

            // Update the score immediately after a correct answer
            UpdateScoreUI();
        }
        else
        {
            // Incorrect answer
            choiceText.color = Color.red;
            wrongAnimPlay();
        }

        
        // Move to the next question
        currentQuestionIndex++;

        // Check if there are more questions
        if (currentQuestionIndex < totalQuestions)
        {
            StartCoroutine(NextQuestionWithDelay());
        }
        else
        {
            EndQuiz();
        }
    }

    IEnumerator StartTimer()
    {
        timer = timerDuration;

        while (timer > 0)
        {
            yield return new WaitForSeconds(1f);
            timer -= 1f;
            UpdateTimerUI();

            if (timer <= 0)
            {
                // Handle the case when the timer runs out
                currentQuestionIndex++;
                StartCoroutine(NextQuestionWithDelay());
            }
        }
    }

    IEnumerator NextQuestionWithDelay()
    {
        yield return new WaitForSeconds(delayAfterQuestion);
        DisplayQuestion();
        ResetTimer();
    }

    void UpdateTimerUI()
    {
        timerText.text = "Time: " + Mathf.CeilToInt(timer).ToString();
    }

    void ResetTimer()
    {
        StopAllCoroutines();
        StartCoroutine(StartTimer());
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + correctAnswers.ToString() + "/" + totalQuestions.ToString();
    }

    void EndQuiz()
    {
        // Display the final score and perform any other end-of-quiz actions
        Debug.Log("Quiz completed!");
        UpdateScoreUI();

        // Deactivate the parent transform of the quiz UI
        if (quizParentTransform != null)
        {
            quizParentTransform.gameObject.SetActive(false);
            quizParentTransform1.gameObject.SetActive(true);
        }
    }
}

[System.Serializable]
public class Question
{
    public string question;
    public string[] choices;
    public int correctChoice;
}
