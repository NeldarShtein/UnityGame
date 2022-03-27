using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NEW1 : MonoBehaviour
{
    public string[] RESULTS_Textnew = new string [200];
    public string[] TextTimeWTnew = new string [100];
    public string[] TextTimeWAnew = new string [100];
    public string[] TextTimeWnew = new string [200];

    public void LoadSceneButtonNEW1()
    {
        for (int i = 0; i < 200; i++)
        {
            PlayerPrefs.SetString("TextTimeWnew" + i, "");
        }
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void LoadSceneButtonNEW2()
    {
        for (int i = 0; i < 100; i++)
        {
            PlayerPrefs.SetString("TextTimeWTnew" + i, "");
        }
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    public void LoadSceneButtonNEW3()
    {
        
        for (int i = 0; i < 200; i++)
        {
            PlayerPrefs.SetString("RESULTS_Textnew" + i, "");
        }
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    
    public void LoadSceneButtonNEW4()
    {
        for (int i = 0; i < 100; i++)
        {
            PlayerPrefs.SetString("TextTimeWAnew" + i, "");
        }
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    
    
}
