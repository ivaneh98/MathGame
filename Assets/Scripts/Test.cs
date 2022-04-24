using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log();
    }
    public void GenerateQuestion()
    {
        Question question= QuestionGenerator.GetQuestion();
        Debug.Log(question.GetQuestion());
        Debug.Log(question.GetAnswers()[0]);
        Debug.Log(question.GetAnswers()[1]);
        Debug.Log(question.GetAnswers()[2]);
        Debug.Log(question.GetAnswers()[3]);
        Debug.Log(question.GetCorrectAnswer());

    }
}
