using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text questionText;
    [SerializeField]
    private GameObject[] answers;
    private string correctAnswer;
    Question question;
    // Start is called before the first frame update
    void Start()
    {
        SetQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetQuestion()
    {
        question = QuestionGenerator.GetQuestion();
        questionText.text = question.GetQuestion();
        for (int i = 0; i < answers.Length; i++)
        {
            answers[i].GetComponentInChildren<TMP_Text>().text = question.GetAnswers()[i];
        }
        correctAnswer = question.GetCorrectAnswer();
    }
    public void CheckAnswer(int i)
    {
        if (question.GetAnswers()[i] == correctAnswer)
        {
            SetQuestion();
        }
    }
}
