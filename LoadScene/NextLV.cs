using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLV : MonoBehaviour
{
    public int LevelNumber;
    public int[] Global_x_size = new int [205];
    public int[] Global_y_size = new int [205];
    public int _x_size;
    public int _y_size;
    public int SetType;
    
    public GameObject NextLVButton;

    private void Start(){
        LevelNumber = PlayerPrefs.GetInt("LevelNumber");
        if (LevelNumber == 100)
        {
            NextLVButton.SetActive(false);
        }
        else if (LevelNumber == 200)
        {
            NextLVButton.SetActive(false);
        }
        else if (LevelNumber < 200)
        {
            NextLVButton.SetActive(true);
        }
        else if (LevelNumber > 200)
        {
            NextLVButton.SetActive(false);
        }
    }
    
    public void LoadSceneButton()
    {
        LevelNumber = PlayerPrefs.GetInt("LevelNumber");
        SetType = PlayerPrefs.GetInt("SetType");

        if (SetType==0)
            {
                if (LevelNumber<100)
                    {
                        _x_size = PlayerPrefs.GetInt("Global_x_size" + LevelNumber);
                        _y_size = PlayerPrefs.GetInt("Global_y_size" + LevelNumber);
                        PlayerPrefs.SetInt("_x_size", _x_size);
                        PlayerPrefs.SetInt("_y_size", _y_size);
                        LevelNumber++;
                        PlayerPrefs.SetInt("LevelNumber", LevelNumber);
                        Time.timeScale = 1f;
                        SceneManager.LoadScene("Maze3D", LoadSceneMode.Single);
                    }
                else if (LevelNumber<200)
                    {
                        _x_size = PlayerPrefs.GetInt("Global_x_size" + LevelNumber);
                        _y_size = PlayerPrefs.GetInt("Global_y_size" + LevelNumber);
                        PlayerPrefs.SetInt("_x_size", _x_size);
                        PlayerPrefs.SetInt("_y_size", _y_size);
                        LevelNumber++;
                        PlayerPrefs.SetInt("LevelNumber", LevelNumber);
                        Time.timeScale = 1f;
                        SceneManager.LoadScene("Maze3DH", LoadSceneMode.Single);
                    }
            }
        else if (SetType==1)
            {
                        _x_size = PlayerPrefs.GetInt("Global_x_size" + LevelNumber);
                        _y_size = PlayerPrefs.GetInt("Global_y_size" + LevelNumber);
                        PlayerPrefs.SetInt("_x_size", _x_size);
                        PlayerPrefs.SetInt("_y_size", _y_size);
                        LevelNumber++;
                        PlayerPrefs.SetInt("LevelNumber", LevelNumber);
                        Time.timeScale = 1f;
                        SceneManager.LoadScene("Maze3DA", LoadSceneMode.Single);
            }
        else if (SetType==2)
            {
                        _x_size = PlayerPrefs.GetInt("Global_x_size" + LevelNumber);
                        _y_size = PlayerPrefs.GetInt("Global_y_size" + LevelNumber);
                        PlayerPrefs.SetInt("_x_size", _x_size);
                        PlayerPrefs.SetInt("_y_size", _y_size);
                        LevelNumber++;
                        PlayerPrefs.SetInt("LevelNumber", LevelNumber);
                        Time.timeScale = 1f;
                        SceneManager.LoadScene("Maze3DT", LoadSceneMode.Single);
            }

    }
    
}
