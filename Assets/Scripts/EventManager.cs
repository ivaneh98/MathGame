using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static Action OnTimerRestart;
    public static Action OnTimeIsUp;
    public static Action OnGameRestart;
    public static Action OnWrongChoice;
    public static Action OnClick;
    public static Action OnCorrectChoice;
    public static Action<int> OnGameOver;

    public static void SendWrongChoice()
    {
        OnWrongChoice?.Invoke();
    }
    public static void SendCorrectChoice()
    {
        OnCorrectChoice?.Invoke();
    }
    public static void SendTimeIsUp()
    {
        OnTimeIsUp?.Invoke();
    }
    public static void SendGameOver(int score)
    {
        OnGameOver?.Invoke(score);
    }
    public static void SendGameRestart()
    {
        OnGameRestart?.Invoke();
    }
    public static void SendClick()
    {
        OnClick?.Invoke();
    }
}
