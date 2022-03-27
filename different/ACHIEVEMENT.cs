using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ACHIEVEMENT : MonoBehaviour
{
    public int[] Achivement_Status = new int [25];
    public int[] timer_numb_Check = new int [200];
    public int[] timer_numbA_Check = new int [100];
    public int[] timer_numbT_CheckT = new int [100];
    public int money;
    public int Level;
    public int SpeedLV;
    public int[,] timer_numbC_CheckC = new int [200,200];
    public int[,] timer_numbH_CheckC = new int [200,200];
    public int[,] timer_numbA_CheckC = new int [200,200];
    public int[,] timer_numbT_CheckC = new int [200,200];
    public int x;
    public int y;

    void Start()
    {
        x = 99;
        y = 199;

        timer_numbC_CheckC[x,x] = PlayerPrefs.GetInt("timer_numbC_CheckC" + x + x);
        if (timer_numbC_CheckC[x,x]==1)
            {
                PlayerPrefs.SetInt("Achivement_Status" + 17, 1);
            }
        timer_numbH_CheckC[x,x] = PlayerPrefs.GetInt("timer_numbH_CheckC" + x + x);
        if (timer_numbH_CheckC[x,x]==1)
            {
                PlayerPrefs.SetInt("Achivement_Status" + 19, 1);
            }
        timer_numbA_CheckC[x,x] = PlayerPrefs.GetInt("timer_numbA_CheckC" + x + x);
        if (timer_numbA_CheckC[x,x]==1)
            {
                PlayerPrefs.SetInt("Achivement_Status" + 21, 1);
            }
        timer_numbT_CheckC[x,x] = PlayerPrefs.GetInt("timer_numbT_CheckC" + x + x);
        if (timer_numbT_CheckC[x,x]==1)
            {
                PlayerPrefs.SetInt("Achivement_Status" + 23, 1);
            }
        timer_numbC_CheckC[y,y] = PlayerPrefs.GetInt("timer_numbC_CheckC" + y + y);
        if (timer_numbC_CheckC[y,y]==1)
            {
                PlayerPrefs.SetInt("Achivement_Status" + 18, 1);
            }
        timer_numbH_CheckC[y,y] = PlayerPrefs.GetInt("timer_numbH_CheckC" + y + y);
        if (timer_numbH_CheckC[y,y]==1)
            {
                PlayerPrefs.SetInt("Achivement_Status" + 20, 1);
            }
        timer_numbA_CheckC[y,y] = PlayerPrefs.GetInt("timer_numbA_CheckC" + y + y);
        if (timer_numbA_CheckC[y,y]==1)
            {
                PlayerPrefs.SetInt("Achivement_Status" + 22, 1);
            }
        timer_numbT_CheckC[y,y] = PlayerPrefs.GetInt("timer_numbT_CheckC" + y + y);
        if (timer_numbT_CheckC[y,y]==1)
            {
                PlayerPrefs.SetInt("Achivement_Status" + 24, 1);
            }

        timer_numb_Check[19] = PlayerPrefs.GetInt("timer_numb_Check" + 19);
        if (timer_numb_Check[19]==1)
            {
                PlayerPrefs.SetInt("Achivement_Status" + 0, 1);
            }
        timer_numb_Check[39] = PlayerPrefs.GetInt("timer_numb_Check" + 39);
        if (timer_numb_Check[39]==1)
            {
                PlayerPrefs.SetInt("Achivement_Status" + 1, 1);
            }
        timer_numb_Check[59] = PlayerPrefs.GetInt("timer_numb_Check" + 59);
        if (timer_numb_Check[59]==1)
            {
                PlayerPrefs.SetInt("Achivement_Status" + 2, 1);
            }
        timer_numb_Check[79] = PlayerPrefs.GetInt("timer_numb_Check" + 79);
        if (timer_numb_Check[79]==1)
            {
                PlayerPrefs.SetInt("Achivement_Status" + 3, 1);
            }
        timer_numb_Check[99] = PlayerPrefs.GetInt("timer_numb_Check" + 99);
        if (timer_numb_Check[99]==1)
            {
                PlayerPrefs.SetInt("Achivement_Status" + 4, 1);
            }
        timer_numb_Check[119] = PlayerPrefs.GetInt("timer_numb_Check" + 119);
        if (timer_numb_Check[119]==1)
            {
                PlayerPrefs.SetInt("Achivement_Status" + 5, 1);
            }
        timer_numb_Check[139] = PlayerPrefs.GetInt("timer_numb_Check" + 139);
        if (timer_numb_Check[139]==1)
            {
                PlayerPrefs.SetInt("Achivement_Status" + 6, 1);
            }
        timer_numb_Check[159] = PlayerPrefs.GetInt("timer_numb_Check" + 159);
        if (timer_numb_Check[159]==1)
            {
                PlayerPrefs.SetInt("Achivement_Status" + 7, 1);
            }
        timer_numb_Check[179] = PlayerPrefs.GetInt("timer_numb_Check" + 179);
        if (timer_numb_Check[179]==1)
            {
                PlayerPrefs.SetInt("Achivement_Status" + 8, 1);
            }
        timer_numb_Check[199] = PlayerPrefs.GetInt("timer_numb_Check" + 199);
        if (timer_numb_Check[199]==1)
            {
                PlayerPrefs.SetInt("Achivement_Status" + 9, 1);
            }
        money = PlayerPrefs.GetInt("money");
        Level = PlayerPrefs.GetInt("Level");
        SpeedLV = PlayerPrefs.GetInt("SpeedLV");
        if (money==3000)
        {
            PlayerPrefs.SetInt("Achivement_Status" + 10, 1);
        }
        if (money==6000)
        {
            PlayerPrefs.SetInt("Achivement_Status" + 11, 1);
        }
        if (money==10000)
        {
            PlayerPrefs.SetInt("Achivement_Status" + 12, 1);
        }
        if (Level==100)
        {
            PlayerPrefs.SetInt("Achivement_Status" + 13, 1);
        }
        if (SpeedLV==100)
        {
            PlayerPrefs.SetInt("Achivement_Status" + 14, 1);
        }
        timer_numbA_Check[99] = PlayerPrefs.GetInt("timer_numbA_Check" + 99);
        if (timer_numbA_Check[99]==1)
            {
                PlayerPrefs.SetInt("Achivement_Status" + 15, 1);
            }
        timer_numbT_CheckT[99] = PlayerPrefs.GetInt("timer_numbT_CheckT" + 99);
        if (timer_numbT_CheckT[99]==1)
            {
                PlayerPrefs.SetInt("Achivement_Status" + 16, 1);
            }
        SceneManager.LoadScene("ACHIEVEMENT", LoadSceneMode.Single);
    }
}
