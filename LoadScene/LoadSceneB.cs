using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneB : MonoBehaviour
{
    public string LoadSceneName = "";
    
    public void LoadSceneButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(LoadSceneName, LoadSceneMode.Single);
    }
}

