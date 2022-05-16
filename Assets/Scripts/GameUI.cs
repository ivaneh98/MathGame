using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    [SerializeField]
    private bool isMobile;
    [SerializeField]
    private GameObject CanvasPC;
    [SerializeField]
    private GameObject GameOverPanelPC;
    [SerializeField]
    private TMP_Text textFinalScorePC;
    [SerializeField]
    private TMP_Text textScorePC; 
    [SerializeField]
    private TMP_Text textHighscorePC;

    [SerializeField]
    private GameObject CanvasMobile;
    [SerializeField]
    private GameObject GameOverPanelMobile;
    [SerializeField]
    private TMP_Text textFinalScoreMobile;
    [SerializeField]
    private TMP_Text textScoreMobile;
    [SerializeField]
    private TMP_Text textHighscoreMobile;
    private ADSpam instance;

    private int score=0;
    private void Start()
    {
        YandexSDK.Instance.DeviceInfoSuccess += Load;

        EventManager.OnGameOver += ShowGameOverWindow;
        EventManager.OnCorrectChoice += UpdateScore;

        instance = GameObject.FindGameObjectWithTag("AD").GetComponent<ADSpam>();
    }
    private void Load(bool _isMobile)
    {
        isMobile = _isMobile;
        if (isMobile)
        {
            CanvasMobile.SetActive(true);
        }
        else
        {
            CanvasPC.SetActive(true);
        }
    }
    private void Update()
    {


        //if (!isMobile)
        //    textScorePC.text = "Счет: " + score.ToString();
        //else
        //    textScoreMobile.text = "Счет: " + score.ToString();
    }
    public void Back()
    {
        EventManager.SendClick();
        SceneManager.LoadScene(0);
    }
    private void ShowGameOverWindow(int score)
    {
        if (!isMobile)
        {
            GameOverPanelPC.SetActive(true);
            textFinalScorePC.text = "Вы набрали: " + score.ToString();
            textHighscorePC.text = "Ваш рекорд: " + PlayerPrefs.GetInt("highscore", 0).ToString();

        }
        else
        {
            GameOverPanelMobile.SetActive(true);
            textFinalScoreMobile.text = "Вы набрали: " + score.ToString();
            textHighscoreMobile.text = "Ваш рекорд: " + PlayerPrefs.GetInt("highscore", 0).ToString();

        }
    }
    private void UpdateScore()
    {
        score += 10;
        if (!isMobile)
            textScorePC.text = "Счет: " + score.ToString();
        else
            textScoreMobile.text = "Счет: " + score.ToString();
    }
    public void Restart()
    {
        EventManager.SendGameRestart();
        EventManager.SendClick();

        if (!isMobile)
            GameOverPanelPC.SetActive(false);
        else
            GameOverPanelMobile.SetActive(false);
    }
    private void OnDestroy()
    {
        EventManager.OnGameOver -= ShowGameOverWindow;
        EventManager.OnCorrectChoice -= UpdateScore;
        YandexSDK.Instance.DeviceInfoSuccess -= Load;

    }
}
