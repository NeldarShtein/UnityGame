using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVLOCKT : MonoBehaviour
{
    
    public GameObject [] LV; 
    public GameObject [] LVE;

    public int[] timer_numbT_CheckT = new int [100];

    void Start()
    {
        timer_numbT_CheckT[19] = PlayerPrefs.GetInt("timer_numbT_CheckT" + 19);
        timer_numbT_CheckT[39] = PlayerPrefs.GetInt("timer_numbT_CheckT" + 39);
        timer_numbT_CheckT[59] = PlayerPrefs.GetInt("timer_numbT_CheckT" + 59);
        timer_numbT_CheckT[79] = PlayerPrefs.GetInt("timer_numbT_CheckT" + 79);
        if (timer_numbT_CheckT[19] == 1)
            {
                LV[0].SetActive(true);
                LVE[0].SetActive(false);
            }
        else if (timer_numbT_CheckT[19] == 0)
            {
                LV[0].SetActive(false);
                LVE[0].SetActive(true);
            }
        if (timer_numbT_CheckT[39] == 1)
            {
                LV[1].SetActive(true);
                LVE[1].SetActive(false);
            }
        else if (timer_numbT_CheckT[39] == 0)
            {
                LV[1].SetActive(false);
                LVE[1].SetActive(true);
            }
        if (timer_numbT_CheckT[59] == 1)
            {
                LV[2].SetActive(true);
                LVE[2].SetActive(false);
            }
        else if (timer_numbT_CheckT[59] == 0)
            {
                LV[2].SetActive(false);
                LVE[2].SetActive(true);
            }
        if (timer_numbT_CheckT[79] == 1)
            {
                LV[3].SetActive(true);
                LVE[3].SetActive(false);
            }
        else if (timer_numbT_CheckT[79] == 0)
            {
                LV[3].SetActive(false);
                LVE[3].SetActive(true);
            }
    }
}
