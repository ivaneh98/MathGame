using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{
    private string _question;
    private List<string> _answers;
    private string _correctAnswer;
    public Question(string question, List<string> answers, string correctAnser)
    {
        _question = question;
        _answers = answers;
        _correctAnswer = correctAnser;
    }
    public List<string> GetAnswers()
    {
        return _answers;
    }
    public string GetCorrectAnswer()
    {
        return _correctAnswer;
    }
    public string GetQuestion() 
    { 
        return _question; 
    }
}
