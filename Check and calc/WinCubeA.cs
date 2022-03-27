using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinCubeA : MonoBehaviour
    {
    public GameObject WinScreen;
    public Text moneyText;
    public Text Timer_text;
    public int[] timer_numbA_Check = new int [100];

    public float[] timer_numbA = new float [100];
    public int[] timer_numbA_s = new int [100];
    public int[] timer_numbA_m = new int [100];
    public int[] timer_numbA_h = new int [100];
    public int[] timer_numbA_d = new int [100];
    public int[] timer_numbA_y = new int [100];
    public int[] mil_sec_for_textA = new int [100];

    public float[] timer_numbA1 = new float [100];
    public int[] timer_numbA_s1 = new int [100];
    public int[] timer_numbA_m1 = new int [100];
    public int[] timer_numbA_h1 = new int [100];
    public int[] timer_numbA_d1 = new int [100];
    public int[] timer_numbA_y1 = new int [100];
    public int[] mil_sec_for_textA1 = new int [100];

    public string[] TextTimeWA = new string [100];

    public int timer_numbAT_CheckAmount;
    public int timer_numbA1CH = 0;
    public int MoneyPerLevel;
    public int money;
    public int TotMonAm;
    public float x;

    public float runSpeed = 30f;
    public float strafeSpeed= 15f;
    
    public int ContinuePrevGame;
    
    public int LevelNumber;
    public int i = 0;
    

    void Start(){
            LevelNumber = PlayerPrefs.GetInt("LevelNumber") -1;
            timer_numbA_Check[LevelNumber] = PlayerPrefs.GetInt("timer_numbA_Check" + LevelNumber);
            PlayerPrefs.SetFloat("runSpeed", 30f);
            PlayerPrefs.SetFloat("strafeSpeed", 15f);
            
            if (timer_numbA_Check[LevelNumber] == 0)
                {
                    Set_Timer_To_Zero();
                    Set_Timer_To_Zero1();
                }
            else if (timer_numbA_Check[LevelNumber] == 1)
                {
                    Set_Timer_To_Zero1();
                }
            Time.timeScale = 1f;
        }
    void FixedUpdate(){
        if (timer_numbA1[LevelNumber] > 31557600)
            {
                timer_numbA_y1[LevelNumber]++;
                timer_numbA1[LevelNumber] = timer_numbA1[LevelNumber] - 31557600;
            }
        timer_numbA1[LevelNumber] += Time.deltaTime;
        }
    private void Set_Timer_To_Zero(){ 
            PlayerPrefs.SetInt("timer_numbA_y" + LevelNumber, 0);
            PlayerPrefs.SetInt("timer_numbA_d" + LevelNumber, 0);
            PlayerPrefs.SetInt("timer_numbA_h" + LevelNumber, 0);
            PlayerPrefs.SetInt("timer_numbA_m" + LevelNumber, 0);
            PlayerPrefs.SetInt("timer_numbA_s" + LevelNumber, 0);
            PlayerPrefs.SetFloat("timer_numbA" + LevelNumber, 0);
            PlayerPrefs.SetInt("mil_sec_for_textA" + LevelNumber, 0);
        }    

    private void Set_Timer_To_Zero1(){ 
            PlayerPrefs.SetInt("timer_numbA_y1" + LevelNumber, 0);
            PlayerPrefs.SetInt("timer_numbA_d1" + LevelNumber, 0);
            PlayerPrefs.SetInt("timer_numbA_h1" + LevelNumber, 0);
            PlayerPrefs.SetInt("timer_numbA_m1" + LevelNumber, 0);
            PlayerPrefs.SetInt("timer_numbA_s1" + LevelNumber, 0);
            PlayerPrefs.SetFloat("timer_numbA1" + LevelNumber, 0);
            PlayerPrefs.SetInt("mil_sec_for_textA1" + LevelNumber, 0);
        }

    private void Timer_text_Check(){
        Timer_Count_To_Normal();
        if (timer_numbA_Check[LevelNumber] == 0)
            {
                b();
            }
        else if (timer_numbA_Check[LevelNumber] == 1)
            {   
                timer_numbA_y[LevelNumber] = PlayerPrefs.GetInt("timer_numbA_y" + LevelNumber);
                timer_numbA_d[LevelNumber] = PlayerPrefs.GetInt("timer_numbA_d" + LevelNumber);
                timer_numbA_h[LevelNumber] = PlayerPrefs.GetInt("timer_numbA_h" + LevelNumber);
                timer_numbA_m[LevelNumber] = PlayerPrefs.GetInt("timer_numbA_m" + LevelNumber);
                timer_numbA_s[LevelNumber] = PlayerPrefs.GetInt("timer_numbA_s" + LevelNumber);
                timer_numbA[LevelNumber] = PlayerPrefs.GetFloat("timer_numbA" + LevelNumber);
                Timer_compare();
            }
        }

    private void Timer_Count_To_Normal(){
            timer_numbA1CH = 0;
            while (timer_numbA1[LevelNumber] >= 86400)
                {
                    timer_numbA_d1[LevelNumber]++;
                    if (timer_numbA1CH<4)
                        {
                            if (timer_numbA_d1[LevelNumber] == 365)
                                {
                                    timer_numbA1CH++;
                                    timer_numbA_d1[LevelNumber] = timer_numbA_d1[LevelNumber] - 365;
                                    timer_numbA_y1[LevelNumber]++;
                                }
                        }
                    else if (timer_numbA1CH==4)
                        {   
                            if (timer_numbA_d1[LevelNumber] == 366)
                                {
                                    timer_numbA1CH-=4;
                                    timer_numbA_d1[LevelNumber] = timer_numbA_d1[LevelNumber] - 366;
                                    timer_numbA_y1[LevelNumber]++;
                                }
                        }
                    timer_numbA1[LevelNumber] = timer_numbA1[LevelNumber] - 86400;      
                }
            while (timer_numbA1[LevelNumber] >= 3600)
                {
                    timer_numbA_h1[LevelNumber]++;
                    timer_numbA1[LevelNumber] = timer_numbA1[LevelNumber] -  3600;
                }
            while (timer_numbA1[LevelNumber] >= 60)
                {
                    timer_numbA_m1[LevelNumber]++;
                    timer_numbA1[LevelNumber] = timer_numbA1[LevelNumber] - 60;
                }
            while (timer_numbA1[LevelNumber] >= 1)
                {
                    timer_numbA_s1[LevelNumber]++;
                    timer_numbA1[LevelNumber] = timer_numbA1[LevelNumber] - 1;
                }
            x = timer_numbA1[LevelNumber] *100;            
            while (x >= 1)
                {
                    mil_sec_for_textA1[LevelNumber]++;
                    x--;
                }     
        }

    private void T0_And_T1_EQ2(){
            mil_sec_for_textA[LevelNumber] = mil_sec_for_textA1[LevelNumber];
            timer_numbA_s[LevelNumber] = timer_numbA_s1[LevelNumber];
            timer_numbA_m[LevelNumber] = timer_numbA_m1[LevelNumber];
            timer_numbA_h[LevelNumber] = timer_numbA_h1[LevelNumber];
            timer_numbA_d[LevelNumber] = timer_numbA_d1[LevelNumber];
            timer_numbA_y[LevelNumber] = timer_numbA_y1[LevelNumber];
            timer_numbA[LevelNumber] = timer_numbA1[LevelNumber];
        }

    private void Timer_compare(){       
        if (timer_numbA_y[LevelNumber]<timer_numbA_y1[LevelNumber])
            {
                a();
            }
        else if (timer_numbA_y[LevelNumber]>timer_numbA_y1[LevelNumber])
            {
                b();
            }
        else if (timer_numbA_y[LevelNumber]==timer_numbA_y1[LevelNumber])
            {
                if (timer_numbA_d[LevelNumber]<timer_numbA_d1[LevelNumber])
                    {
                        a();
                    }        
                else if (timer_numbA_d[LevelNumber]>timer_numbA_d1[LevelNumber])
                    {
                        b();
                    }        
                else if (timer_numbA_d[LevelNumber]==timer_numbA_d1[LevelNumber])
                    {
                        if (timer_numbA_h[LevelNumber]<timer_numbA_h1[LevelNumber])
                            {
                                a();    
                            }
                        else if (timer_numbA_h[LevelNumber]>timer_numbA_h1[LevelNumber])
                            {
                                b();    
                            }
                        else if (timer_numbA_h[LevelNumber]==timer_numbA_h1[LevelNumber])
                            {
                                if (timer_numbA_m[LevelNumber]<timer_numbA_m1[LevelNumber])
                                    {
                                        a();       
                                    }
                                else if (timer_numbA_m[LevelNumber]>timer_numbA_m1[LevelNumber])
                                    {
                                        b();       
                                    }
                                else if (timer_numbA_m[LevelNumber]==timer_numbA_m1[LevelNumber])
                                    {
                                        if (timer_numbA_s[LevelNumber]<timer_numbA_s1[LevelNumber])
                                            {
                                                a();
                                            }
                                        else if (timer_numbA_s[LevelNumber]>timer_numbA_s1[LevelNumber])
                                            {
                                                b();       
                                            }
                                        else if (timer_numbA_s[LevelNumber]==timer_numbA_s1[LevelNumber])
                                            { 
                                                if (timer_numbA[LevelNumber]<timer_numbA1[LevelNumber])
                                                    {
                                                        a();
                                                    }
                                                else if (timer_numbA[LevelNumber]>timer_numbA1[LevelNumber])
                                                    {
                                                        b();       
                                                    }
                                                else if (timer_numbA[LevelNumber]==timer_numbA1[LevelNumber])
                                                    {
                                                        a();  
                                                    }          
                                            }    
                                    }
                            }
                    }
            }
        }

    private void a(){
            T0_And_T1_EQ2();
            Timer_text_writer();
            Set_Timer_To_Zero1();
        }

    private void b(){
            T0_And_T1_EQ2();
            Timer_text_writer();
            PlayerPrefs.SetString("TextTimeWA" + LevelNumber, Timer_text.text);
            remember(); 
            Set_Timer_To_Zero1();
        }

    private void Timer_text_writer(){
        
        if (timer_numbA_y[LevelNumber]>0)
            {
                if (timer_numbA_d[LevelNumber]>=10)
                    {
                        if (timer_numbA_h[LevelNumber]<10)
                            {
                                if (timer_numbA_m[LevelNumber]<10)
                                    {
                                        if (timer_numbA_s[LevelNumber]<10)
                                            {
                                                if (mil_sec_for_textA[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":" +  timer_numbA_d[LevelNumber] + ":0" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                                    }
                                                else if (mil_sec_for_textA[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":" +  timer_numbA_d[LevelNumber] + ":0" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                                    }
                                            }
                                        else if (timer_numbA_s[LevelNumber]>=10)
                                            {
                                                if (mil_sec_for_textA[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":" +  timer_numbA_d[LevelNumber] + ":0" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                                    }
                                                else if (mil_sec_for_textA[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":" + timer_numbA_d[LevelNumber] + ":0" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                                    }
                                            }
                                    }                        
                                else if (timer_numbA_m[LevelNumber]>=10)
                                    {
                                        if (timer_numbA_s[LevelNumber]<10)
                                            {
                                                if (mil_sec_for_textA[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":" + timer_numbA_d[LevelNumber] + ":0" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                                    }
                                                else if (mil_sec_for_textA[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":" + timer_numbA_d[LevelNumber] + ":0" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                                    }
                                            }
                                        else if (timer_numbA_s[LevelNumber]>=10)
                                            {
                                                if (mil_sec_for_textA[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":" + timer_numbA_d[LevelNumber] + ":0" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                                    }
                                                else if (mil_sec_for_textA[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":" + timer_numbA_d[LevelNumber] + ":0" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                                    }
                                            }
                                    }
                            }
                        else if (timer_numbA_h[LevelNumber]>=10)
                            {
                                if (timer_numbA_m[LevelNumber]<10)
                                    {
                                        if (timer_numbA_s[LevelNumber]<10)
                                            {
                                                if (mil_sec_for_textA[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":" + timer_numbA_d[LevelNumber] + ":" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                                    }
                                                else if (mil_sec_for_textA[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":" + timer_numbA_d[LevelNumber] + ":" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                                    }
                                            }
                                        else if (timer_numbA_s[LevelNumber]>=10)
                                            {
                                                if (mil_sec_for_textA[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":" + timer_numbA_d[LevelNumber] + ":" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                                    }
                                                else if (mil_sec_for_textA[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":" + timer_numbA_d[LevelNumber] + ":" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                                    }
                                            }
                                    }                        
                                else if (timer_numbA_m[LevelNumber]>=10)
                                    {
                                        if (timer_numbA_s[LevelNumber]<10)
                                            {
                                                if (mil_sec_for_textA[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":" + timer_numbA_d[LevelNumber] + ":" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                                    }
                                                else if (mil_sec_for_textA[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":" + timer_numbA_d[LevelNumber] + ":" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                                    }
                                            }
                                        else if (timer_numbA_s[LevelNumber]>=10)
                                            {
                                                if (mil_sec_for_textA[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":" + timer_numbA_d[LevelNumber] + ":" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                                    }
                                                else if (mil_sec_for_textA[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":" + timer_numbA_d[LevelNumber] + ":" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                                    }
                                            }
                                    }
                            }
                    }
                else if (timer_numbA_d[LevelNumber]>0)
                    {
                        if (timer_numbA_h[LevelNumber]<10)
                            {
                                if (timer_numbA_m[LevelNumber]<10)
                                    {
                                        if (timer_numbA_s[LevelNumber]<10)
                                            {
                                                if (mil_sec_for_textA[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":0" +  timer_numbA_d[LevelNumber] + ":0" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                                    }
                                                else if (mil_sec_for_textA[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":0" +  timer_numbA_d[LevelNumber] + ":0" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                                    }
                                            }
                                        else if (timer_numbA_s[LevelNumber]>=10)
                                            {
                                                if (mil_sec_for_textA[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":0" +  timer_numbA_d[LevelNumber] + ":0" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                                    }
                                                else if (mil_sec_for_textA[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":0" + timer_numbA_d[LevelNumber] + ":0" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                                    }
                                            }
                                    }                        
                                else if (timer_numbA_m[LevelNumber]>=10)
                                    {
                                        if (timer_numbA_s[LevelNumber]<10)
                                            {
                                                if (mil_sec_for_textA[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":0" + timer_numbA_d[LevelNumber] + ":0" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                                    }
                                                else if (mil_sec_for_textA[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":0" + timer_numbA_d[LevelNumber] + ":0" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                                    }
                                            }
                                        else if (timer_numbA_s[LevelNumber]>=10)
                                            {
                                                if (mil_sec_for_textA[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":0" + timer_numbA_d[LevelNumber] + ":0" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                                    }
                                                else if (mil_sec_for_textA[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":0" + timer_numbA_d[LevelNumber] + ":0" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                                    }
                                            }
                                    }
                            }
                        else if (timer_numbA_h[LevelNumber]>=10)
                            {
                                if (timer_numbA_m[LevelNumber]<10)
                                    {
                                        if (timer_numbA_s[LevelNumber]<10)
                                            {
                                                if (mil_sec_for_textA[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":0" + timer_numbA_d[LevelNumber] + ":" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                                    }
                                                else if (mil_sec_for_textA[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":0" + timer_numbA_d[LevelNumber] + ":" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                                    }
                                            }
                                        else if (timer_numbA_s[LevelNumber]>=10)
                                            {
                                                if (mil_sec_for_textA[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":0" + timer_numbA_d[LevelNumber] + ":" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                                    }
                                                else if (mil_sec_for_textA[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":0" + timer_numbA_d[LevelNumber] + ":" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                                    }
                                            }
                                    }                        
                                else if (timer_numbA_m[LevelNumber]>=10)
                                    {
                                        if (timer_numbA_s[LevelNumber]<10)
                                            {
                                                if (mil_sec_for_textA[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":0" + timer_numbA_d[LevelNumber] + ":" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                                    }
                                                else if (mil_sec_for_textA[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":0" + timer_numbA_d[LevelNumber] + ":" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                                    }
                                            }
                                        else if (timer_numbA_s[LevelNumber]>=10)
                                            {
                                                if (mil_sec_for_textA[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":0" + timer_numbA_d[LevelNumber] + ":" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                                    }
                                                else if (mil_sec_for_textA[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numbA_y[LevelNumber] + ":0" + timer_numbA_d[LevelNumber] + ":" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                                    }
                                            }
                                    }
                            }
                    }
            }
        else if (timer_numbA_d[LevelNumber]>0)
            {
                if (timer_numbA_h[LevelNumber]<10)
                    {
                        if (timer_numbA_m[LevelNumber]<10)
                            {
                                if (timer_numbA_s[LevelNumber]<10)
                                    {
                                        if (mil_sec_for_textA[LevelNumber]<10)
                                            {
                                                Timer_text.text = timer_numbA_d[LevelNumber] + ":0" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                            }
                                        else if (mil_sec_for_textA[LevelNumber]>=10)
                                            {
                                                Timer_text.text = timer_numbA_d[LevelNumber] + ":0" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                            }
                                    }
                                else if (timer_numbA_s[LevelNumber]>=10)
                                    {
                                        if (mil_sec_for_textA[LevelNumber]<10)
                                            {
                                                Timer_text.text = timer_numbA_d[LevelNumber] + ":0" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                            }
                                        else if (mil_sec_for_textA[LevelNumber]>=10)
                                            {
                                                Timer_text.text = timer_numbA_d[LevelNumber] + ":0" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                            }
                                    }
                            }                        
                        else if (timer_numbA_m[LevelNumber]>=10)
                            {
                                if (timer_numbA_s[LevelNumber]<10)
                                    {
                                        if (mil_sec_for_textA[LevelNumber]<10)
                                            {
                                                Timer_text.text = timer_numbA_d[LevelNumber] + ":0" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                            }
                                        else if (mil_sec_for_textA[LevelNumber]>=10)
                                            {
                                                Timer_text.text = timer_numbA_d[LevelNumber] + ":0" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                            }
                                    }
                                else if (timer_numbA_s[LevelNumber]>=10)
                                    {
                                        if (mil_sec_for_textA[LevelNumber]<10)
                                            {
                                                Timer_text.text = timer_numbA_d[LevelNumber] + ":0" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                            }
                                        else if (mil_sec_for_textA[LevelNumber]>=10)
                                            {
                                                Timer_text.text = timer_numbA_d[LevelNumber] + ":0" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                            }
                                    }
                            }
                    }
                else if (timer_numbA_h[LevelNumber]>=10)
                    {
                        if (timer_numbA_m[LevelNumber]<10)
                            {
                                if (timer_numbA_s[LevelNumber]<10)
                                    {
                                        if (mil_sec_for_textA[LevelNumber]<10)
                                            {
                                                Timer_text.text = timer_numbA_d[LevelNumber] + ":" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                            }
                                        else if (mil_sec_for_textA[LevelNumber]>=10)
                                            {
                                                Timer_text.text = timer_numbA_d[LevelNumber] + ":" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                            }
                                    }
                                else if (timer_numbA_s[LevelNumber]>=10)
                                    {
                                        if (mil_sec_for_textA[LevelNumber]<10)
                                            {
                                                Timer_text.text = timer_numbA_d[LevelNumber] + ":" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                            }
                                        else if (mil_sec_for_textA[LevelNumber]>=10)
                                            {
                                                Timer_text.text = timer_numbA_d[LevelNumber] + ":" +  timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                            }
                                    }
                            }                        
                        else if (timer_numbA_m[LevelNumber]>=10)
                            {
                                if (timer_numbA_s[LevelNumber]<10)
                                    {
                                        if (mil_sec_for_textA[LevelNumber]<10)
                                            {
                                                Timer_text.text = timer_numbA_d[LevelNumber] + ":" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                            }
                                        else if (mil_sec_for_textA[LevelNumber]>=10)
                                            {
                                                Timer_text.text = timer_numbA_d[LevelNumber] + ":" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                            }
                                    }
                                else if (timer_numbA_s[LevelNumber]>=10)
                                    {
                                        if (mil_sec_for_textA[LevelNumber]<10)
                                            {
                                                Timer_text.text = timer_numbA_d[LevelNumber] + ":" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                            }
                                        else if (mil_sec_for_textA[LevelNumber]>=10)
                                            {
                                                Timer_text.text = timer_numbA_d[LevelNumber] + ":" + timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                            }
                                    }
                            }
                    }
            }
        else if (timer_numbA_h[LevelNumber]>0)
            {
                if (timer_numbA_m[LevelNumber]<10)
                    {
                        if (timer_numbA_s[LevelNumber]<10)
                            {
                                if (mil_sec_for_textA[LevelNumber]<10)
                                    {
                                        Timer_text.text = timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                    }
                                else if (mil_sec_for_textA[LevelNumber]>=10)
                                    {
                                        Timer_text.text = timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                    }
                            }
                        else if (timer_numbA_s[LevelNumber]>=10)
                            {
                                if (mil_sec_for_textA[LevelNumber]<10)
                                    {
                                        Timer_text.text = timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                    }
                                else if (mil_sec_for_textA[LevelNumber]>=10)
                                    {
                                        Timer_text.text = timer_numbA_h[LevelNumber] + ":0" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                    }
                            }
                    }
                else if (timer_numbA_m[LevelNumber]>=10)
                    {
                        if (timer_numbA_s[LevelNumber]<10)
                            {
                                if (mil_sec_for_textA[LevelNumber]<10)
                                    {
                                        Timer_text.text = timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                    }
                                else if (mil_sec_for_textA[LevelNumber]>=10)
                                    {
                                        Timer_text.text = timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                    }
                            }
                        else if (timer_numbA_s[LevelNumber]>=10)
                            {
                                if (mil_sec_for_textA[LevelNumber]<10)
                                    {
                                        Timer_text.text = timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                                    }
                                else if (mil_sec_for_textA[LevelNumber]>=10)
                                    {
                                        Timer_text.text = timer_numbA_h[LevelNumber] + ":" + timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                                    }
                            }
                    }
            }
        else if (timer_numbA_m[LevelNumber]>0)
            {
                if (timer_numbA_s[LevelNumber]<10)
                    {
                        if (mil_sec_for_textA[LevelNumber]<10)
                            {
                                Timer_text.text = timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                            }
                        else if (mil_sec_for_textA[LevelNumber]>=10)
                            {
                                Timer_text.text = timer_numbA_m[LevelNumber] + ":0" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                            }
                    }
                else if (timer_numbA_s[LevelNumber]>=10)
                    {
                        if (mil_sec_for_textA[LevelNumber]<10)
                            {
                                Timer_text.text = timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                            }
                        else if (mil_sec_for_textA[LevelNumber]>=10)
                            {
                                Timer_text.text = timer_numbA_m[LevelNumber] + ":" + timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                            }
                    }
            }
        else if (timer_numbA_s[LevelNumber]>0)
            {
                if (mil_sec_for_textA[LevelNumber]<10)
                    {
                        Timer_text.text = timer_numbA_s[LevelNumber] + ":0" + mil_sec_for_textA[LevelNumber];
                    }
                else if (mil_sec_for_textA[LevelNumber]>=10)
                    {
                        Timer_text.text = timer_numbA_s[LevelNumber] + ":" + mil_sec_for_textA[LevelNumber];
                    }
            }
        else if (mil_sec_for_textA[LevelNumber]>0)
            {
                Timer_text.text = "Really?";
            }
        }
        
    private void remember(){
        PlayerPrefs.SetInt("timer_numbA_y" + LevelNumber, timer_numbA_y[LevelNumber]);
        PlayerPrefs.SetInt("timer_numbA_d" + LevelNumber, timer_numbA_d[LevelNumber]);
        PlayerPrefs.SetInt("timer_numbA_h" + LevelNumber, timer_numbA_h[LevelNumber]);
        PlayerPrefs.SetInt("timer_numbA_m" + LevelNumber, timer_numbA_m[LevelNumber]);
        PlayerPrefs.SetInt("timer_numbA_s" + LevelNumber, timer_numbA_s[LevelNumber]);
        PlayerPrefs.SetFloat("timer_numbA" + LevelNumber, timer_numbA[LevelNumber]);
        PlayerPrefs.SetInt("mil_sec_for_textA" + LevelNumber, mil_sec_for_textA[LevelNumber]);
        }

    private void OnTriggerEnter(Collider other){
        Time.timeScale = 0f;
        
        ContinuePrevGame = PlayerPrefs.GetInt("ContinuePrevGame")+1;
        PlayerPrefs.SetInt("ContinuePrevGame", ContinuePrevGame);
        
        MoneyPerLevel = PlayerPrefs.GetInt("MoneyPerLevel");
        moneyText.text = "Money: " + MoneyPerLevel;
        money = PlayerPrefs.GetInt("money");
        money = money + MoneyPerLevel;
        TotMonAm = PlayerPrefs.GetInt("TotMonAm");
        TotMonAm = TotMonAm + MoneyPerLevel;       
        PlayerPrefs.SetInt("TotMonAm", TotMonAm);
        PlayerPrefs.SetInt("money", money);
        
        Timer_text_Check();      
        PlayerPrefs.SetInt("timer_numbA_Check" + LevelNumber, 1);
        timer_numbAT_CheckAmount = PlayerPrefs.GetInt("timer_numbAT_CheckAmount");
        PlayerPrefs.SetInt("timer_numbAT_CheckAmount", timer_numbAT_CheckAmount+1);
        WinScreen.SetActive(true);
        other.gameObject.SetActive(false);
        }
    }
