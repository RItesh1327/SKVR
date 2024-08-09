using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MCQQuiz;


[CreateAssetMenu(fileName = "MCQQuizData", menuName = "ScriptableObjects/QuestionData", order = 2)]
public class MCQQuizData : ScriptableObject
{
    public List<MCQ_Question> questions;
}


