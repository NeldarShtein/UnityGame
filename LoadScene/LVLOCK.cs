using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVLOCK : MonoBehaviour
{
    
    public GameObject [] LV; 
    public GameObject [] LVE;

    public int[] timer_numb_Check = new int [200];

    void Start()
    {
        timer_numb_Check[19] = PlayerPrefs.GetInt("timer_numb_Check" + 19);
        timer_numb_Check[39] = PlayerPrefs.GetInt("timer_numb_Check" + 39);
        timer_numb_Check[59] = PlayerPrefs.GetInt("timer_numb_Check" + 59);
        timer_numb_Check[79] = PlayerPrefs.GetInt("timer_numb_Check" + 79);
        if (timer_numb_Check[19] == 1)
            {
                LV[0].SetActive(true);
                LVE[0].SetActive(false);
            }
        else if (timer_numb_Check[19] == 0)
            {
                LV[0].SetActive(false);
                LVE[0].SetActive(true);
            }
        if (timer_numb_Check[39] == 1)
            {
                LV[1].SetActive(true);
                LVE[1].SetActive(false);
            }
        else if (timer_numb_Check[39] == 0)
            {
                LV[1].SetActive(false);
                LVE[1].SetActive(true);
            }
        if (timer_numb_Check[59] == 1)
            {
                LV[2].SetActive(true);
                LVE[2].SetActive(false);
            }
        else if (timer_numb_Check[59] == 0)
            {
                LV[2].SetActive(false);
                LVE[2].SetActive(true);
            }
        if (timer_numb_Check[79] == 1)
            {
                LV[3].SetActive(true);
                LVE[3].SetActive(false);
            }
        else if (timer_numb_Check[79] == 0)
            {
                LV[3].SetActive(false);
                LVE[3].SetActive(true);
            }
    }
}
