using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneB2 : MonoBehaviour
{
    public int LevelNumber;

    public int[] levelActive = new int [200];
    public string[] LoadSceneNameC = new string [10];

    public string LoadSceneNameC0 = "1-20";
    public string LoadSceneNameC1 = "21-40";
    public string LoadSceneNameC2 = "41-60";
    public string LoadSceneNameC3 = "61-80";
    public string LoadSceneNameC4 = "81-100";
    public string LoadSceneNameC5 = "1-20H";
    public string LoadSceneNameC6 = "21-40H";
    public string LoadSceneNameC7 = "41-60H";
    public string LoadSceneNameC8 = "61-80H";
    public string LoadSceneNameC9 = "81-100H";

    public void LoadSceneButton2()
    {
        LevelNumber = PlayerPrefs.GetInt("LevelNumber")-1;
        levelActive[LevelNumber] = 0;
        PlayerPrefs.SetInt("levelActive"+LevelNumber, levelActive[LevelNumber]);
        Time.timeScale = 1f;
            if (LevelNumber<20){SceneManager.LoadScene(LoadSceneNameC0, LoadSceneMode.Single);} 
            else if (LevelNumber<40){SceneManager.LoadScene(LoadSceneNameC1, LoadSceneMode.Single);} 
            else if (LevelNumber<60){SceneManager.LoadScene(LoadSceneNameC2, LoadSceneMode.Single);} 
            else if (LevelNumber<80){SceneManager.LoadScene(LoadSceneNameC3, LoadSceneMode.Single);} 
            else if (LevelNumber<100){SceneManager.LoadScene(LoadSceneNameC4, LoadSceneMode.Single);} 
            else if (LevelNumber<120){SceneManager.LoadScene(LoadSceneNameC5, LoadSceneMode.Single);} 
            else if (LevelNumber<140){SceneManager.LoadScene(LoadSceneNameC6, LoadSceneMode.Single);} 
            else if (LevelNumber<160){SceneManager.LoadScene(LoadSceneNameC7, LoadSceneMode.Single);} 
            else if (LevelNumber<180){SceneManager.LoadScene(LoadSceneNameC8, LoadSceneMode.Single);} 
            else if (LevelNumber<200){SceneManager.LoadScene(LoadSceneNameC9, LoadSceneMode.Single);}  
    }
}

