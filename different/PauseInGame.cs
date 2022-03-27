using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseInGame : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenUI;
    public GameObject PauseBot;

    public void Resume(){
        PauseMenUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        PauseBot.SetActive(true);
    }

    public void Pause(){
        PauseMenUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        PauseBot.SetActive(false);
    }
}
