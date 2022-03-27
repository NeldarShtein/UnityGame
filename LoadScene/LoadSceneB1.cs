using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneB1 : MonoBehaviour
{
    public int LevelNumber;
    public int SetType;
   
    public void LoadSceneButton()
        {
            LevelNumber = PlayerPrefs.GetInt("LevelNumber") -1;
            SetType = PlayerPrefs.GetInt("SetType");
            
            Time.timeScale = 1f;
            if (SetType==0)
                {
                    if (LevelNumber<20){SceneManager.LoadScene("1-20", LoadSceneMode.Single);} 
                    else if (LevelNumber<40){SceneManager.LoadScene("21-40", LoadSceneMode.Single);} 
                    else if (LevelNumber<60){SceneManager.LoadScene("41-60", LoadSceneMode.Single);} 
                    else if (LevelNumber<80){SceneManager.LoadScene("61-80", LoadSceneMode.Single);} 
                    else if (LevelNumber<100){SceneManager.LoadScene("81-100", LoadSceneMode.Single);} 
                    else if (LevelNumber<120){SceneManager.LoadScene("1-20H", LoadSceneMode.Single);} 
                    else if (LevelNumber<140){SceneManager.LoadScene("21-40H", LoadSceneMode.Single);} 
                    else if (LevelNumber<160){SceneManager.LoadScene("41-60H", LoadSceneMode.Single);} 
                    else if (LevelNumber<180){SceneManager.LoadScene("61-80H", LoadSceneMode.Single);} 
                    else if (LevelNumber<200){SceneManager.LoadScene("81-100H", LoadSceneMode.Single);}  
                }
            else if (SetType==1)
                {
                    if (LevelNumber<20){SceneManager.LoadScene("1-20A", LoadSceneMode.Single);} 
                    else if (LevelNumber<40){SceneManager.LoadScene("21-40A", LoadSceneMode.Single);} 
                    else if (LevelNumber<60){SceneManager.LoadScene("41-60A", LoadSceneMode.Single);} 
                    else if (LevelNumber<80){SceneManager.LoadScene("61-80A", LoadSceneMode.Single);} 
                    else if (LevelNumber<100){SceneManager.LoadScene("81-100A", LoadSceneMode.Single);}
                
                }
            else if (SetType==2)
                {
                    if (LevelNumber<20){SceneManager.LoadScene("1-20T", LoadSceneMode.Single);} 
                    else if (LevelNumber<40){SceneManager.LoadScene("21-40T", LoadSceneMode.Single);} 
                    else if (LevelNumber<60){SceneManager.LoadScene("41-60T", LoadSceneMode.Single);} 
                    else if (LevelNumber<80){SceneManager.LoadScene("61-80T", LoadSceneMode.Single);} 
                    else if (LevelNumber<100){SceneManager.LoadScene("81-100T", LoadSceneMode.Single);}
                
                }
            
        }
    
}

