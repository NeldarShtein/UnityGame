using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Check1NLT : MonoBehaviour
{
    
    public int LevelNumber2;

    public int[] LevelNumberNT = new int [5];
    public int[] timer_numbT_CheckT = new int [100];

    private int f = 0;
    
    public GameObject [] OBJ;

    void Start()
        {
            LevelNumberNT[LevelNumber2] = PlayerPrefs.GetInt("LevelNumberNT" + LevelNumber2);
                               
            if (LevelNumberNT[LevelNumber2] == 0)
                {
                    f = 20*LevelNumber2;
                    for (int x = 0; x < 20; x++)
                        {   
                            OBJ[x].SetActive(false);
                        }
                    PlayerPrefs.SetInt("LevelNumberNT" + LevelNumber2, 7);
                    if (LevelNumber2 == 0)
                        {
                            OBJ[0].SetActive(true);
                        }
                    else if (LevelNumber2 == 5)
                        {
                            OBJ[0].SetActive(true);
                        }
                    else if (LevelNumber2>0)
                        {
                            f = 20*LevelNumber2-1;
                            timer_numbT_CheckT[f] = PlayerPrefs.GetInt("timer_numbT_CheckT"+f);
                            if (timer_numbT_CheckT[f] == 1)
                                {
                                    OBJ[0].SetActive(true);
                                }
                        }            
                }
            else if (LevelNumberNT[LevelNumber2] == 7)
                {
                    if (LevelNumber2==0)
                    {
                        OBJ[0].SetActive(true);
                        f = 20*LevelNumber2;
                        b();
                    }
                    else if (LevelNumber2==5)
                    {
                        OBJ[0].SetActive(true);
                        f = 20*LevelNumber2;
                        b();
                    }
                    else if (LevelNumber2>=1)
                    {
                        f = 20*LevelNumber2-1;
                        a();
                    }
                }
        } 
    
    private void a(){
        for (int x = 0; x < 20; x++)
            {
                timer_numbT_CheckT[f] = PlayerPrefs.GetInt("timer_numbT_CheckT"+f);
                if (timer_numbT_CheckT[f] == 1)
                    {
                        OBJ[x].SetActive(true);
                    }
                else if (timer_numbT_CheckT[f] == 0)
                    {
                        x=25;
                    }
                f++;
            }
        }
    private void b(){
        for (int x = 0; x < 20; x++)
            {
                timer_numbT_CheckT[f] = PlayerPrefs.GetInt("timer_numbT_CheckT"+f);
                if (timer_numbT_CheckT[f] == 1)
                    {
                        if (x<20)
                        {
                            OBJ[x+1].SetActive(true);
                        }
                    }
                else if (timer_numbT_CheckT[f] == 0)
                    {
                        x=25;
                    }
                f++;
            }
        }
}