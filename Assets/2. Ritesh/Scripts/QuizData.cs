using UnityEngine;

[CreateAssetMenu(fileName = "New Quiz Data", menuName = "Quiz Data", order = 51)]
public class QuizData : ScriptableObject
{
    public Question[] questions;
}