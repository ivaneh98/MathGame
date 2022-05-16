using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private bool isSoundOn;



    [SerializeField]
    private GameObject soundTimer;
    [SerializeField]
    private GameObject soundClick;
    [SerializeField]
    private GameObject soundWrong;
    // Start is called before the first frame update
    void Start()
    {
        isSoundOn = PlayerPrefs.GetInt("is_sound_on", 1) == 1;
        EventManager.OnTimeIsUp += PlaySoundTimer;
        EventManager.OnClick += PlaySoundClick;
        EventManager.OnWrongChoice += PlaySoundWrong;

    }
    private void Update()
    {
        isSoundOn = PlayerPrefs.GetInt("is_sound_on", 1) == 1;
    }
    private void PlaySoundTimer()
    {
        if (isSoundOn)
            Instantiate(soundTimer);
    }
    private void PlaySoundClick()
    {
        if (isSoundOn)
            Instantiate(soundClick);

    }
    private void PlaySoundWrong()
    {
        if (isSoundOn)
            Instantiate(soundWrong);

    }
}
