using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void StartGame(int id)
    {
        PlayerPrefs.SetInt("level", id);
        SceneManager.LoadScene(1);
    }
}
