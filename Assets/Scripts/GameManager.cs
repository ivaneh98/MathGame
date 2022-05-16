using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private bool isMobile=true;
    [SerializeField]
    private TMP_Text questionText;
    [SerializeField]
    private GameObject[] answers;

    [SerializeField]
    private TMP_Text questionTextMobile;
    [SerializeField]
    private GameObject[] answersMobile;

    private string correctAnswer;
    Question question;
    private int score;
    private ADSpam instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = GameObject.FindGameObjectWithTag("AD").GetComponent<ADSpam>();

        YandexSDK.Instance.DeviceInfoSuccess += Load;
        EventManager.OnTimeIsUp += GameOver;
        EventManager.OnGameRestart += Restart;
#if DEBUG
        SetQuestion();
#endif
    }
    private void Load(bool _isMobile)
    {
        isMobile = _isMobile;
        SetQuestion();

    }
    void SetQuestion()
    {
        if (!isMobile)
        {
            question = QuestionGenerator.GetQuestion();
            questionText.text = question.GetQuestion();
            for (int i = 0; i < answers.Length; i++)
            {
                answers[i].GetComponentInChildren<TMP_Text>().text = question.GetAnswers()[i];
            }
            correctAnswer = question.GetCorrectAnswer();
        }
        else
        {
            question = QuestionGenerator.GetQuestion();
            questionTextMobile.text = question.GetQuestion();
            for (int i = 0; i < answersMobile.Length; i++)
            {
                answersMobile[i].GetComponentInChildren<TMP_Text>().text = question.GetAnswers()[i];
            }
            correctAnswer = question.GetCorrectAnswer();
        }
    }
    public void CheckAnswer(int i)
    {
        if (question.GetAnswers()[i] == correctAnswer)
        {
            SetQuestion();
            score += 10;
            if (score > PlayerPrefs.GetInt("highscore", 0))
            {
                PlayerPrefs.SetInt("highscore", score);
            }
            EventManager.SendCorrectChoice();
            EventManager.SendClick();
        }
        else
        {
            EventManager.SendWrongChoice();
        }
    }
    private void GameOver()
    {
        EventManager.SendGameOver(score);
#if !DEBUG
instance.ShowCommon();
#endif
    }
    private void Restart()
    {
        EventManager.SendClick();
        score = 0;
        SetQuestion();
    }
    private void OnDestroy()
    {
        EventManager.OnTimeIsUp -= GameOver;
        EventManager.OnGameRestart -= Restart;
        YandexSDK.Instance.DeviceInfoSuccess -= Load;
    }
}
