using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinCube : MonoBehaviour
    {
    public GameObject WinScreen;
    public Text moneyText;
    public Text Timer_text;
    public int[] timer_numb_Check = new int [200];

    public float[] timer_numb = new float [200];
    public int[] timer_numb_s = new int [200];
    public int[] timer_numb_m = new int [200];
    public int[] timer_numb_h = new int [200];
    public int[] timer_numb_d = new int [200];
    public int[] timer_numb_y = new int [200];
    public int[] mil_sec_for_text = new int [200];

    public float[] timer_numb1 = new float [200];
    public int[] timer_numb_s1 = new int [200];
    public int[] timer_numb_m1 = new int [200];
    public int[] timer_numb_h1 = new int [200];
    public int[] timer_numb_d1 = new int [200];
    public int[] timer_numb_y1 = new int [200];
    public int[] mil_sec_for_text1 = new int [200];

    public string[] TextTimeW = new string [200];

    public int timer_numb1CH = 0;
    public int timer_numb_CheckAmountC;
    public int timer_numb_CheckAmountH;
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
            timer_numb_Check[LevelNumber] = PlayerPrefs.GetInt("timer_numb_Check" + LevelNumber);
            PlayerPrefs.SetFloat("runSpeed", 30f);
            PlayerPrefs.SetFloat("strafeSpeed", 15f);
            
            if (timer_numb_Check[LevelNumber] == 0)
                {
                    Set_Timer_To_Zero();
                    Set_Timer_To_Zero1();
                }
            else if (timer_numb_Check[LevelNumber] == 1)
                {
                    Set_Timer_To_Zero1();
                }
            Time.timeScale = 1f;
        }
    void FixedUpdate(){
        if (timer_numb1[LevelNumber] > 31557600)
            {
                timer_numb_y1[LevelNumber]++;
                timer_numb1[LevelNumber] = timer_numb1[LevelNumber] - 31557600;
            }
        timer_numb1[LevelNumber] += Time.deltaTime;
        }
    private void Set_Timer_To_Zero(){ 
            PlayerPrefs.SetInt("timer_numb_y" + LevelNumber, 0);
            PlayerPrefs.SetInt("timer_numb_d" + LevelNumber, 0);
            PlayerPrefs.SetInt("timer_numb_h" + LevelNumber, 0);
            PlayerPrefs.SetInt("timer_numb_m" + LevelNumber, 0);
            PlayerPrefs.SetInt("timer_numb_s" + LevelNumber, 0);
            PlayerPrefs.SetFloat("timer_numb" + LevelNumber, 0);
            PlayerPrefs.SetInt("mil_sec_for_text" + LevelNumber, 0);
        }    

    private void Set_Timer_To_Zero1(){ 
            PlayerPrefs.SetInt("timer_numb_y1" + LevelNumber, 0);
            PlayerPrefs.SetInt("timer_numb_d1" + LevelNumber, 0);
            PlayerPrefs.SetInt("timer_numb_h1" + LevelNumber, 0);
            PlayerPrefs.SetInt("timer_numb_m1" + LevelNumber, 0);
            PlayerPrefs.SetInt("timer_numb_s1" + LevelNumber, 0);
            PlayerPrefs.SetFloat("timer_numb1" + LevelNumber, 0);
            PlayerPrefs.SetInt("mil_sec_for_text1" + LevelNumber, 0);
        }

    private void Timer_text_Check(){
        Timer_Count_To_Normal();
        if (timer_numb_Check[LevelNumber] == 0)
            {
                b();
            }
        else if (timer_numb_Check[LevelNumber] == 1)
            {   
                timer_numb_y[LevelNumber] = PlayerPrefs.GetInt("timer_numb_y" + LevelNumber);
                timer_numb_d[LevelNumber] = PlayerPrefs.GetInt("timer_numb_d" + LevelNumber);
                timer_numb_h[LevelNumber] = PlayerPrefs.GetInt("timer_numb_h" + LevelNumber);
                timer_numb_m[LevelNumber] = PlayerPrefs.GetInt("timer_numb_m" + LevelNumber);
                timer_numb_s[LevelNumber] = PlayerPrefs.GetInt("timer_numb_s" + LevelNumber);
                timer_numb[LevelNumber] = PlayerPrefs.GetFloat("timer_numb" + LevelNumber);
                Timer_compare();
            }
        }

    private void Timer_Count_To_Normal(){
            timer_numb1CH = 0;
            while (timer_numb1[LevelNumber] >= 86400)
                {
                    timer_numb_d1[LevelNumber]++;
                    if (timer_numb1CH<4)
                        {
                            if (timer_numb_d1[LevelNumber] == 365)
                                {
                                    timer_numb1CH++;
                                    timer_numb_d1[LevelNumber] = timer_numb_d1[LevelNumber] - 365;
                                    timer_numb_y1[LevelNumber]++;
                                }
                        }
                    else if (timer_numb1CH==4)
                        {   
                            if (timer_numb_d1[LevelNumber] == 366)
                                {
                                    timer_numb1CH-=4;
                                    timer_numb_d1[LevelNumber] = timer_numb_d1[LevelNumber] - 366;
                                    timer_numb_y1[LevelNumber]++;
                                }
                        }
                    timer_numb1[LevelNumber] = timer_numb1[LevelNumber] - 86400;      
                }
            while (timer_numb1[LevelNumber] >= 3600)
                {
                    timer_numb_h1[LevelNumber]++;
                    timer_numb1[LevelNumber] = timer_numb1[LevelNumber] -  3600;
                }
            while (timer_numb1[LevelNumber] >= 60)
                {
                    timer_numb_m1[LevelNumber]++;
                    timer_numb1[LevelNumber] = timer_numb1[LevelNumber] - 60;
                }
            while (timer_numb1[LevelNumber] >= 1)
                {
                    timer_numb_s1[LevelNumber]++;
                    timer_numb1[LevelNumber] = timer_numb1[LevelNumber] - 1;
                }
            x = timer_numb1[LevelNumber] *100;            
            while (x >= 1)
                {
                    mil_sec_for_text1[LevelNumber]++;
                    x--;
                }     
        }

    private void T0_And_T1_EQ2(){
            mil_sec_for_text[LevelNumber] = mil_sec_for_text1[LevelNumber];
            timer_numb_s[LevelNumber] = timer_numb_s1[LevelNumber];
            timer_numb_m[LevelNumber] = timer_numb_m1[LevelNumber];
            timer_numb_h[LevelNumber] = timer_numb_h1[LevelNumber];
            timer_numb_d[LevelNumber] = timer_numb_d1[LevelNumber];
            timer_numb_y[LevelNumber] = timer_numb_y1[LevelNumber];
            timer_numb[LevelNumber] = timer_numb1[LevelNumber];
        }

    private void Timer_compare(){       
        if (timer_numb_y[LevelNumber]<timer_numb_y1[LevelNumber])
            {
                a();
            }
        else if (timer_numb_y[LevelNumber]>timer_numb_y1[LevelNumber])
            {
                b();
            }
        else if (timer_numb_y[LevelNumber]==timer_numb_y1[LevelNumber])
            {
                if (timer_numb_d[LevelNumber]<timer_numb_d1[LevelNumber])
                    {
                        a();
                    }        
                else if (timer_numb_d[LevelNumber]>timer_numb_d1[LevelNumber])
                    {
                        b();
                    }        
                else if (timer_numb_d[LevelNumber]==timer_numb_d1[LevelNumber])
                    {
                        if (timer_numb_h[LevelNumber]<timer_numb_h1[LevelNumber])
                            {
                                a();    
                            }
                        else if (timer_numb_h[LevelNumber]>timer_numb_h1[LevelNumber])
                            {
                                b();    
                            }
                        else if (timer_numb_h[LevelNumber]==timer_numb_h1[LevelNumber])
                            {
                                if (timer_numb_m[LevelNumber]<timer_numb_m1[LevelNumber])
                                    {
                                        a();       
                                    }
                                else if (timer_numb_m[LevelNumber]>timer_numb_m1[LevelNumber])
                                    {
                                        b();       
                                    }
                                else if (timer_numb_m[LevelNumber]==timer_numb_m1[LevelNumber])
                                    {
                                        if (timer_numb_s[LevelNumber]<timer_numb_s1[LevelNumber])
                                            {
                                                a();
                                            }
                                        else if (timer_numb_s[LevelNumber]>timer_numb_s1[LevelNumber])
                                            {
                                                b();       
                                            }
                                        else if (timer_numb_s[LevelNumber]==timer_numb_s1[LevelNumber])
                                            { 
                                                if (timer_numb[LevelNumber]<timer_numb1[LevelNumber])
                                                    {
                                                        a();
                                                    }
                                                else if (timer_numb[LevelNumber]>timer_numb1[LevelNumber])
                                                    {
                                                        b();       
                                                    }
                                                else if (timer_numb[LevelNumber]==timer_numb1[LevelNumber])
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
            PlayerPrefs.SetString("TextTimeW" + LevelNumber, Timer_text.text);
            remember(); 
            Set_Timer_To_Zero1();
        }

    private void Timer_text_writer(){
        
        if (timer_numb_y[LevelNumber]>0)
            {
                if (timer_numb_d[LevelNumber]>=10)
                    {
                        if (timer_numb_h[LevelNumber]<10)
                            {
                                if (timer_numb_m[LevelNumber]<10)
                                    {
                                        if (timer_numb_s[LevelNumber]<10)
                                            {
                                                if (mil_sec_for_text[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":" +  timer_numb_d[LevelNumber] + ":0" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                                    }
                                                else if (mil_sec_for_text[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":" +  timer_numb_d[LevelNumber] + ":0" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                                    }
                                            }
                                        else if (timer_numb_s[LevelNumber]>=10)
                                            {
                                                if (mil_sec_for_text[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":" +  timer_numb_d[LevelNumber] + ":0" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                                    }
                                                else if (mil_sec_for_text[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":" + timer_numb_d[LevelNumber] + ":0" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                                    }
                                            }
                                    }                        
                                else if (timer_numb_m[LevelNumber]>=10)
                                    {
                                        if (timer_numb_s[LevelNumber]<10)
                                            {
                                                if (mil_sec_for_text[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":" + timer_numb_d[LevelNumber] + ":0" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                                    }
                                                else if (mil_sec_for_text[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":" + timer_numb_d[LevelNumber] + ":0" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                                    }
                                            }
                                        else if (timer_numb_s[LevelNumber]>=10)
                                            {
                                                if (mil_sec_for_text[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":" + timer_numb_d[LevelNumber] + ":0" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                                    }
                                                else if (mil_sec_for_text[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":" + timer_numb_d[LevelNumber] + ":0" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                                    }
                                            }
                                    }
                            }
                        else if (timer_numb_h[LevelNumber]>=10)
                            {
                                if (timer_numb_m[LevelNumber]<10)
                                    {
                                        if (timer_numb_s[LevelNumber]<10)
                                            {
                                                if (mil_sec_for_text[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":" + timer_numb_d[LevelNumber] + ":" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                                    }
                                                else if (mil_sec_for_text[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":" + timer_numb_d[LevelNumber] + ":" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                                    }
                                            }
                                        else if (timer_numb_s[LevelNumber]>=10)
                                            {
                                                if (mil_sec_for_text[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":" + timer_numb_d[LevelNumber] + ":" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                                    }
                                                else if (mil_sec_for_text[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":" + timer_numb_d[LevelNumber] + ":" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                                    }
                                            }
                                    }                        
                                else if (timer_numb_m[LevelNumber]>=10)
                                    {
                                        if (timer_numb_s[LevelNumber]<10)
                                            {
                                                if (mil_sec_for_text[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":" + timer_numb_d[LevelNumber] + ":" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                                    }
                                                else if (mil_sec_for_text[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":" + timer_numb_d[LevelNumber] + ":" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                                    }
                                            }
                                        else if (timer_numb_s[LevelNumber]>=10)
                                            {
                                                if (mil_sec_for_text[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":" + timer_numb_d[LevelNumber] + ":" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                                    }
                                                else if (mil_sec_for_text[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":" + timer_numb_d[LevelNumber] + ":" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                                    }
                                            }
                                    }
                            }
                    }
                else if (timer_numb_d[LevelNumber]>0)
                    {
                        if (timer_numb_h[LevelNumber]<10)
                            {
                                if (timer_numb_m[LevelNumber]<10)
                                    {
                                        if (timer_numb_s[LevelNumber]<10)
                                            {
                                                if (mil_sec_for_text[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":0" +  timer_numb_d[LevelNumber] + ":0" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                                    }
                                                else if (mil_sec_for_text[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":0" +  timer_numb_d[LevelNumber] + ":0" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                                    }
                                            }
                                        else if (timer_numb_s[LevelNumber]>=10)
                                            {
                                                if (mil_sec_for_text[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":0" +  timer_numb_d[LevelNumber] + ":0" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                                    }
                                                else if (mil_sec_for_text[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":0" + timer_numb_d[LevelNumber] + ":0" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                                    }
                                            }
                                    }                        
                                else if (timer_numb_m[LevelNumber]>=10)
                                    {
                                        if (timer_numb_s[LevelNumber]<10)
                                            {
                                                if (mil_sec_for_text[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":0" + timer_numb_d[LevelNumber] + ":0" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                                    }
                                                else if (mil_sec_for_text[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":0" + timer_numb_d[LevelNumber] + ":0" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                                    }
                                            }
                                        else if (timer_numb_s[LevelNumber]>=10)
                                            {
                                                if (mil_sec_for_text[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":0" + timer_numb_d[LevelNumber] + ":0" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                                    }
                                                else if (mil_sec_for_text[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":0" + timer_numb_d[LevelNumber] + ":0" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                                    }
                                            }
                                    }
                            }
                        else if (timer_numb_h[LevelNumber]>=10)
                            {
                                if (timer_numb_m[LevelNumber]<10)
                                    {
                                        if (timer_numb_s[LevelNumber]<10)
                                            {
                                                if (mil_sec_for_text[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":0" + timer_numb_d[LevelNumber] + ":" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                                    }
                                                else if (mil_sec_for_text[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":0" + timer_numb_d[LevelNumber] + ":" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                                    }
                                            }
                                        else if (timer_numb_s[LevelNumber]>=10)
                                            {
                                                if (mil_sec_for_text[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":0" + timer_numb_d[LevelNumber] + ":" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                                    }
                                                else if (mil_sec_for_text[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":0" + timer_numb_d[LevelNumber] + ":" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                                    }
                                            }
                                    }                        
                                else if (timer_numb_m[LevelNumber]>=10)
                                    {
                                        if (timer_numb_s[LevelNumber]<10)
                                            {
                                                if (mil_sec_for_text[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":0" + timer_numb_d[LevelNumber] + ":" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                                    }
                                                else if (mil_sec_for_text[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":0" + timer_numb_d[LevelNumber] + ":" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                                    }
                                            }
                                        else if (timer_numb_s[LevelNumber]>=10)
                                            {
                                                if (mil_sec_for_text[LevelNumber]<10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":0" + timer_numb_d[LevelNumber] + ":" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                                    }
                                                else if (mil_sec_for_text[LevelNumber]>=10)
                                                    {
                                                        Timer_text.text = timer_numb_y[LevelNumber] + ":0" + timer_numb_d[LevelNumber] + ":" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                                    }
                                            }
                                    }
                            }
                    }
            }
        else if (timer_numb_d[LevelNumber]>0)
            {
                if (timer_numb_h[LevelNumber]<10)
                    {
                        if (timer_numb_m[LevelNumber]<10)
                            {
                                if (timer_numb_s[LevelNumber]<10)
                                    {
                                        if (mil_sec_for_text[LevelNumber]<10)
                                            {
                                                Timer_text.text = timer_numb_d[LevelNumber] + ":0" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                            }
                                        else if (mil_sec_for_text[LevelNumber]>=10)
                                            {
                                                Timer_text.text = timer_numb_d[LevelNumber] + ":0" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                            }
                                    }
                                else if (timer_numb_s[LevelNumber]>=10)
                                    {
                                        if (mil_sec_for_text[LevelNumber]<10)
                                            {
                                                Timer_text.text = timer_numb_d[LevelNumber] + ":0" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                            }
                                        else if (mil_sec_for_text[LevelNumber]>=10)
                                            {
                                                Timer_text.text = timer_numb_d[LevelNumber] + ":0" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                            }
                                    }
                            }                        
                        else if (timer_numb_m[LevelNumber]>=10)
                            {
                                if (timer_numb_s[LevelNumber]<10)
                                    {
                                        if (mil_sec_for_text[LevelNumber]<10)
                                            {
                                                Timer_text.text = timer_numb_d[LevelNumber] + ":0" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                            }
                                        else if (mil_sec_for_text[LevelNumber]>=10)
                                            {
                                                Timer_text.text = timer_numb_d[LevelNumber] + ":0" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                            }
                                    }
                                else if (timer_numb_s[LevelNumber]>=10)
                                    {
                                        if (mil_sec_for_text[LevelNumber]<10)
                                            {
                                                Timer_text.text = timer_numb_d[LevelNumber] + ":0" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                            }
                                        else if (mil_sec_for_text[LevelNumber]>=10)
                                            {
                                                Timer_text.text = timer_numb_d[LevelNumber] + ":0" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                            }
                                    }
                            }
                    }
                else if (timer_numb_h[LevelNumber]>=10)
                    {
                        if (timer_numb_m[LevelNumber]<10)
                            {
                                if (timer_numb_s[LevelNumber]<10)
                                    {
                                        if (mil_sec_for_text[LevelNumber]<10)
                                            {
                                                Timer_text.text = timer_numb_d[LevelNumber] + ":" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                            }
                                        else if (mil_sec_for_text[LevelNumber]>=10)
                                            {
                                                Timer_text.text = timer_numb_d[LevelNumber] + ":" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                            }
                                    }
                                else if (timer_numb_s[LevelNumber]>=10)
                                    {
                                        if (mil_sec_for_text[LevelNumber]<10)
                                            {
                                                Timer_text.text = timer_numb_d[LevelNumber] + ":" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                            }
                                        else if (mil_sec_for_text[LevelNumber]>=10)
                                            {
                                                Timer_text.text = timer_numb_d[LevelNumber] + ":" +  timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                            }
                                    }
                            }                        
                        else if (timer_numb_m[LevelNumber]>=10)
                            {
                                if (timer_numb_s[LevelNumber]<10)
                                    {
                                        if (mil_sec_for_text[LevelNumber]<10)
                                            {
                                                Timer_text.text = timer_numb_d[LevelNumber] + ":" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                            }
                                        else if (mil_sec_for_text[LevelNumber]>=10)
                                            {
                                                Timer_text.text = timer_numb_d[LevelNumber] + ":" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                            }
                                    }
                                else if (timer_numb_s[LevelNumber]>=10)
                                    {
                                        if (mil_sec_for_text[LevelNumber]<10)
                                            {
                                                Timer_text.text = timer_numb_d[LevelNumber] + ":" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                            }
                                        else if (mil_sec_for_text[LevelNumber]>=10)
                                            {
                                                Timer_text.text = timer_numb_d[LevelNumber] + ":" + timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                            }
                                    }
                            }
                    }
            }
        else if (timer_numb_h[LevelNumber]>0)
            {
                if (timer_numb_m[LevelNumber]<10)
                    {
                        if (timer_numb_s[LevelNumber]<10)
                            {
                                if (mil_sec_for_text[LevelNumber]<10)
                                    {
                                        Timer_text.text = timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                    }
                                else if (mil_sec_for_text[LevelNumber]>=10)
                                    {
                                        Timer_text.text = timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                    }
                            }
                        else if (timer_numb_s[LevelNumber]>=10)
                            {
                                if (mil_sec_for_text[LevelNumber]<10)
                                    {
                                        Timer_text.text = timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                    }
                                else if (mil_sec_for_text[LevelNumber]>=10)
                                    {
                                        Timer_text.text = timer_numb_h[LevelNumber] + ":0" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                    }
                            }
                    }
                else if (timer_numb_m[LevelNumber]>=10)
                    {
                        if (timer_numb_s[LevelNumber]<10)
                            {
                                if (mil_sec_for_text[LevelNumber]<10)
                                    {
                                        Timer_text.text = timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                    }
                                else if (mil_sec_for_text[LevelNumber]>=10)
                                    {
                                        Timer_text.text = timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                    }
                            }
                        else if (timer_numb_s[LevelNumber]>=10)
                            {
                                if (mil_sec_for_text[LevelNumber]<10)
                                    {
                                        Timer_text.text = timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                                    }
                                else if (mil_sec_for_text[LevelNumber]>=10)
                                    {
                                        Timer_text.text = timer_numb_h[LevelNumber] + ":" + timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                                    }
                            }
                    }
            }
        else if (timer_numb_m[LevelNumber]>0)
            {
                if (timer_numb_s[LevelNumber]<10)
                    {
                        if (mil_sec_for_text[LevelNumber]<10)
                            {
                                Timer_text.text = timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                            }
                        else if (mil_sec_for_text[LevelNumber]>=10)
                            {
                                Timer_text.text = timer_numb_m[LevelNumber] + ":0" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                            }
                    }
                else if (timer_numb_s[LevelNumber]>=10)
                    {
                        if (mil_sec_for_text[LevelNumber]<10)
                            {
                                Timer_text.text = timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                            }
                        else if (mil_sec_for_text[LevelNumber]>=10)
                            {
                                Timer_text.text = timer_numb_m[LevelNumber] + ":" + timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                            }
                    }
            }
        else if (timer_numb_s[LevelNumber]>0)
            {
                if (mil_sec_for_text[LevelNumber]<10)
                    {
                        Timer_text.text = timer_numb_s[LevelNumber] + ":0" + mil_sec_for_text[LevelNumber];
                    }
                else if (mil_sec_for_text[LevelNumber]>=10)
                    {
                        Timer_text.text = timer_numb_s[LevelNumber] + ":" + mil_sec_for_text[LevelNumber];
                    }
            }
        else if (mil_sec_for_text[LevelNumber]>0)
            {
                Timer_text.text = "Really?";
            }
        }
        
    private void remember(){
        PlayerPrefs.SetInt("timer_numb_y" + LevelNumber, timer_numb_y[LevelNumber]);
        PlayerPrefs.SetInt("timer_numb_d" + LevelNumber, timer_numb_d[LevelNumber]);
        PlayerPrefs.SetInt("timer_numb_h" + LevelNumber, timer_numb_h[LevelNumber]);
        PlayerPrefs.SetInt("timer_numb_m" + LevelNumber, timer_numb_m[LevelNumber]);
        PlayerPrefs.SetInt("timer_numb_s" + LevelNumber, timer_numb_s[LevelNumber]);
        PlayerPrefs.SetFloat("timer_numb" + LevelNumber, timer_numb[LevelNumber]);
        PlayerPrefs.SetInt("mil_sec_for_text" + LevelNumber, mil_sec_for_text[LevelNumber]);
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
        PlayerPrefs.SetInt("timer_numb_Check" + LevelNumber, 1);
        timer_numb_CheckAmountC = PlayerPrefs.GetInt("timer_numb_CheckAmountC");
        timer_numb_CheckAmountH = PlayerPrefs.GetInt("timer_numb_CheckAmountH");
        if (LevelNumber>=100)
        {
            timer_numb_CheckAmountH++;
        }
        else if (LevelNumber<=99)
        {
            timer_numb_CheckAmountC++;
        }
        PlayerPrefs.SetInt("timer_numb_CheckAmountC", timer_numb_CheckAmountC);
        PlayerPrefs.SetInt("timer_numb_CheckAmountH", timer_numb_CheckAmountH);
        WinScreen.SetActive(true);
        other.gameObject.SetActive(false);
        }
    }
