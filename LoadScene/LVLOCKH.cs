using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVLOCKH : MonoBehaviour
{
    
    public GameObject [] LV; 
    public GameObject [] LVE;

    public int[] timer_numb_Check = new int [200];

    void Start()
    {
        timer_numb_Check[119] = PlayerPrefs.GetInt("timer_numb_Check" + 119);
        timer_numb_Check[139] = PlayerPrefs.GetInt("timer_numb_Check" + 139);
        timer_numb_Check[159] = PlayerPrefs.GetInt("timer_numb_Check" + 159);
        timer_numb_Check[179] = PlayerPrefs.GetInt("timer_numb_Check" + 179);
        if (timer_numb_Check[119] == 1)
            {
                LV[0].SetActive(true);
                LVE[0].SetActive(false);
            }
        else if (timer_numb_Check[119] == 0)
            {
                LV[0].SetActive(false);
                LVE[0].SetActive(true);
            }
        if (timer_numb_Check[139] == 1)
            {
                LV[1].SetActive(true);
                LVE[1].SetActive(false);
            }
        else if (timer_numb_Check[139] == 0)
            {
                LV[1].SetActive(false);
                LVE[1].SetActive(true);
            }
        if (timer_numb_Check[159] == 1)
            {
                LV[2].SetActive(true);
                LVE[2].SetActive(false);
            }
        else if (timer_numb_Check[159] == 0)
            {
                LV[2].SetActive(false);
                LVE[2].SetActive(true);
            }
        if (timer_numb_Check[179] == 1)
            {
                LV[3].SetActive(true);
                LVE[3].SetActive(false);
            }
        else if (timer_numb_Check[179] == 0)
            {
                LV[3].SetActive(false);
                LVE[3].SetActive(true);
            }       
    }
}
