using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;
    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correcto");
            quizManager.correct();
        }
        else
        {
            Debug.Log("Mal");
            quizManager.wrong();

        }
    }
}