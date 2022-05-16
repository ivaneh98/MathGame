using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private Slider timer;
    private int timePenalty;
    private bool isTriggered=false;
    // Start is called before the first frame update
    void Start()
    {
        EventManager.OnCorrectChoice+= Restart;
        EventManager.OnGameRestart += Restart;
        EventManager.OnWrongChoice += ReduceTime;
        timePenalty = (int)timer.maxValue / 3;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer.value--;
    }
    private void Update()
    {
        if (timer.value < 1&&!isTriggered)
        {
            isTriggered = true;
            EventManager.OnTimeIsUp();
        }


    }
    private void Restart()
    {
        timer.value = timer.maxValue;
        isTriggered = false;

    }
    private void ReduceTime()
    {
        timer.value -= timePenalty;
    }
    private void OnDestroy()
    {
        EventManager.OnCorrectChoice -= Restart;
        EventManager.OnGameRestart -= Restart;
        EventManager.OnWrongChoice -= ReduceTime;
    }
}
