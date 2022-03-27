using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Achievement_Done : MonoBehaviour
{
    public int[] Star_was_Received = new int [25];
    public int[] Achivement_Status = new int [25];
    public GameObject [] AchiveOBJ;

    public Text [] AchiveText;

    void Start()
        {     
            for (int i = 0; i < 25; i++)
                {
                    Achivement_Status[i] = PlayerPrefs.GetInt("Achivement_Status" + i);
                    Star_was_Received[i] = PlayerPrefs.GetInt("Star_was_Received" + i);
                        if (Achivement_Status[i]==0)
                            {
                                AchiveText[i].text = "[_]";
                                AchiveOBJ[i].SetActive(false);
                            }
                        else if (Achivement_Status[i]==1)
                            {
                                AchiveText[i].text = "[V]";
                                if (Star_was_Received[i]==0)
                                {
                                    AchiveOBJ[i].SetActive(true);
                                }
                                else if (Star_was_Received[i]==1)
                                {
                                    AchiveOBJ[i].SetActive(false);
                                }
                            }
                }
        }  
}
