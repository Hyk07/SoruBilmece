using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;
    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("CorrectAnswer");
            quizManager.correct();
        }
        else
        {
            Debug.Log("WrongAnswer");
            quizManager.wrong();
        }
    }
}
