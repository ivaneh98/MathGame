using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    private bool isSoundOn;
    [SerializeField]
    private GameObject soundOn;
    [SerializeField]
    private GameObject soundOff;

    [SerializeField]
    private GameObject soundOnMobile;
    [SerializeField]
    private GameObject soundOffMobile;

    [SerializeField]
    private GameObject MenuPC;
    [SerializeField]
    private GameObject MenuMobile;

    [SerializeField]
    private bool isMobile;
    [SerializeField]
    private GameObject levelSelection;

    [SerializeField]
    private GameObject levelSelectionMobile;

    [SerializeField]
    private TMP_Text highscoreText;
    [SerializeField]
    private TMP_Text highscoreTextMobile;
    private ADSpam instance;

    private void Start()
    {
        YandexSDK.Instance.DeviceInfoSuccess += Load;

        instance = GameObject.FindGameObjectWithTag("AD").GetComponent<ADSpam>();
#if !DEBUG
instance.ShowCommon();
#endif
    }
    private void Update()
    {


        highscoreText.text = "Ваш рекорд: " + PlayerPrefs.GetInt("highscore", 0).ToString();
        highscoreTextMobile.text = "Ваш рекорд: " + PlayerPrefs.GetInt("highscore", 0).ToString();
        isSoundOn = PlayerPrefs.GetInt("is_sound_on", 1) == 1;
        if (isSoundOn)
        {
            soundOff.SetActive(true);
            soundOn.SetActive(false);
            soundOffMobile.SetActive(true);
            soundOnMobile.SetActive(false);
        }
        else
        {
            soundOff.SetActive(false);
            soundOn.SetActive(true);
            soundOffMobile.SetActive(false);
            soundOnMobile.SetActive(true);
        }
    }
    private void Load(bool _isMobile)
    {
        isMobile = _isMobile;
        if (isMobile)
        {
            MenuMobile.SetActive(true);
            MenuPC.SetActive(false);
        }
        else
        {
            MenuPC.SetActive(true);
            MenuMobile.SetActive(false);
        }
    }
    public void StartGame(int id)
    {
        PlayerPrefs.SetInt("level", id);
        EventManager.SendClick();
        SceneManager.LoadScene(1);
    }
    public void ShowLevelSelection()
    {
        levelSelection.SetActive(true);
        levelSelectionMobile.SetActive(true);
        EventManager.SendClick();
#if !DEBUG
instance.ShowCommon();
#endif
    }
    public void HideLevelSelection()
    {
        levelSelection.SetActive(false);
        levelSelectionMobile.SetActive(false);
        EventManager.SendClick();
#if !DEBUG
instance.ShowCommon();
#endif

    }
    public void SwitchSound()
    {
        if (isSoundOn)
        {
            PlayerPrefs.SetInt("is_sound_on", 0);
            isSoundOn = false;
            soundOff.SetActive(false);
            soundOn.SetActive(true);
            soundOffMobile.SetActive(false);
            soundOnMobile.SetActive(true);
        }
        else
        {
            PlayerPrefs.SetInt("is_sound_on", 1);
            isSoundOn = true;
            EventManager.SendClick();
            soundOff.SetActive(true);
            soundOn.SetActive(false);
            soundOffMobile.SetActive(true);
            soundOnMobile.SetActive(false);
        }
    }
    public void MoreGames()
    {
        Application.OpenURL("https://yandex.ru/games/developer?name=I.V.Games");
    }
    private void OnDestroy()
    {
        YandexSDK.Instance.DeviceInfoSuccess -= Load;
    }
}
