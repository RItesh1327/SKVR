using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[System.Serializable]
public class QuestionManager 
{
    public Button[] options;
    public Button rightAnswer;
    public bool isAnyTask;
    public UnityEvent task;
}
