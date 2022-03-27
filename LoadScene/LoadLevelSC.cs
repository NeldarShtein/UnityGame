using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLevelSC : MonoBehaviour
{
    
    public Text Timer_text;
    
    public int[] timer_numb_Check = new int [200];
    public int[] timer_numbT_CheckT = new int [100];
    public int[] timer_numbA_Check = new int [100];

    public int LevelNumber;
    public int SetType;

    public string[] TextTimeW = new string [200];
    public string[] TextTimeWA = new string [100];
    public string[] TextTimeWT = new string [100];

    public int[] Global_x_size = new int [200];
    public int[] Global_y_size = new int [200];

    public int _x_size;
    public int _y_size;
    private int i = 0;

    void Start(){   
            i = LevelNumber - 1;
            SetType = PlayerPrefs.GetInt("SetType");
            if (SetType==0)
                {
                    timer_numb_Check[i] = PlayerPrefs.GetInt("timer_numb_Check" + i); 
                    
                    if (timer_numb_Check[i]==0)
                        {
                            Timer_text.text = "xx:xx:xx:xx";   
                        }
                    else if (timer_numb_Check[i]==1)
                        {
                            Timer_text.text = PlayerPrefs.GetString("TextTimeW" + i);   
                        }
                }
            else if (SetType==1)
            {
                    timer_numbA_Check[i] = PlayerPrefs.GetInt("timer_numbA_Check" + i); 
                    
                    if (timer_numbA_Check[i]==0)
                        {
                            Timer_text.text = "xx:xx:xx:xx";   
                        }
                    else if (timer_numbA_Check[i]==1)
                        {
                            Timer_text.text = PlayerPrefs.GetString("TextTimeWA" + i);   
                        }
            }
            else if (SetType==2)
            {
                    timer_numbT_CheckT[i] = PlayerPrefs.GetInt("timer_numbT_CheckT" + i); 
                    
                    if (timer_numbT_CheckT[i]==0)
                        {
                            Timer_text.text = "xx:xx:xx:xx";   
                        }
                    else if (timer_numbT_CheckT[i]==1)
                        {
                            Timer_text.text = PlayerPrefs.GetString("TextTimeWT" + i);   
                        }
            }
        }
            
        public void LoadSceneButton()
        {
            PlayerPrefs.SetInt("LevelNumber", LevelNumber);
            PlayerPrefs.SetInt("_x_size", _x_size);
            PlayerPrefs.SetInt("_y_size", _y_size);
            i = LevelNumber - 1;
            PlayerPrefs.SetInt("Global_x_size"+i, _x_size);
            PlayerPrefs.SetInt("Global_y_size"+i, _y_size);
            Time.timeScale = 1f;
            if (SetType==0)
                {
                    if (LevelNumber<=100)
                    {
                        SceneManager.LoadScene("Maze3D", LoadSceneMode.Single);
                    }
                    else if (LevelNumber<=200)
                    {
                        SceneManager.LoadScene("Maze3DH", LoadSceneMode.Single);
                    }
                }
            else if (SetType==1)
            {
                SceneManager.LoadScene("Maze3DA", LoadSceneMode.Single);
            }
            else if (SetType==2)
            {
                SceneManager.LoadScene("Maze3DT", LoadSceneMode.Single);
            }
        }
}

