using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinCube1 : MonoBehaviour
    {
    public string s = "";
    public int XSizeAndT;
    public int YSizeAndT;
    public int Q_Win_CustC;
    public int[] Q_Win_CustCX = new int [200];
    public int[] Q_Win_CustCY = new int [200];

    public int DWB = 0;

    public string[,] TextTimeC2 = new string [200,200];
    
    public GameObject WinScreen;
    public Text moneyText;
    public Text Timer_text;

    public int[,] timer_numbC_CheckC = new int [200,200];
    public float[,] timer_numbC = new float [200,200];
    public int[,] timer_numbC_s = new int [200,200];
    public int[,] timer_numbC_m = new int [200,200];
    public int[,] timer_numbC_h = new int [200,200];
    public int[,] timer_numbC_d = new int [200,200];
    public int[,] timer_numbC_y = new int [200,200];
    public int[,] mil_sec_for_textC = new int [200,200];
    public float[,] timer_numbC1 = new float [200,200];
    public int[,] timer_numbC_s1 = new int [200,200];
    public int[,] timer_numbC_m1 = new int [200,200];
    public int[,] timer_numbC_h1 = new int [200,200];
    public int[,] timer_numbC_d1 = new int [200,200];
    public int[,] timer_numbC_y1 = new int [200,200];
    public int[,] mil_sec_for_textC1 = new int [200,200];

    public int timer_numbC1CH = 0;
    public int MoneyPerLevel;
    public int money;
    public int TotMonAm;
    public float x = 0;

    public float runSpeed = 30f;
    public float strafeSpeed= 15f;
    
    public int ContinuePrevGame;
    public int i = 0;

    void Start(){
            XSizeAndT = PlayerPrefs.GetInt("XSizeAndT")-1;
            YSizeAndT = PlayerPrefs.GetInt("YSizeAndT")-1;
            DWB = PlayerPrefs.GetInt("DWB");
            timer_numbC_CheckC[XSizeAndT,YSizeAndT] = PlayerPrefs.GetInt("timer_numbC_CheckC" + XSizeAndT + YSizeAndT);
            PlayerPrefs.SetFloat("runSpeed", 30f);
            PlayerPrefs.SetFloat("strafeSpeed", 15f);
                    
            if (timer_numbC_CheckC[XSizeAndT,YSizeAndT] == 0)
                {
                    Set_Timer_To_Zero();
                    Set_Timer_To_Zero1();
                }
            else if (timer_numbC_CheckC[XSizeAndT,YSizeAndT] == 1)
                {
                    Set_Timer_To_Zero1();
                }
            Time.timeScale = 1f;
        }
    void FixedUpdate(){
        if (timer_numbC1[XSizeAndT,YSizeAndT] > 31557600)
            {
                timer_numbC_y1[XSizeAndT,YSizeAndT]++;
                timer_numbC1[XSizeAndT,YSizeAndT] = timer_numbC1[XSizeAndT,YSizeAndT] - 31557600;
            }
        timer_numbC1[XSizeAndT,YSizeAndT] += Time.deltaTime;
        }
    private void Set_Timer_To_Zero(){
            PlayerPrefs.SetInt("timer_numbC_y" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbC_d" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbC_h" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbC_m" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbC_s" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetFloat("timer_numbC" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("mil_sec_for_textC" + XSizeAndT + YSizeAndT, 0);
        }
    private void Set_Timer_To_Zero1(){
            PlayerPrefs.SetInt("timer_numbC_y1" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbC_d1" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbC_h1" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbC_m1" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbC_s1" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetFloat("timer_numbC1" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("mil_sec_for_textC1" + XSizeAndT + YSizeAndT, 0);
        }
    private void Timer_Count_To_Normal(){
        timer_numbC1CH = 0;
        while (timer_numbC1[XSizeAndT,YSizeAndT] >= 86400)
            {
                timer_numbC_d1[XSizeAndT,YSizeAndT]++;
                if (timer_numbC1CH<4)
                {
                    if (timer_numbC_d1[XSizeAndT,YSizeAndT] == 365)
                    {
                        timer_numbC1CH++;
                        timer_numbC_d1[XSizeAndT,YSizeAndT] = timer_numbC_d1[XSizeAndT,YSizeAndT] - 365;
                        timer_numbC_y1[XSizeAndT,YSizeAndT]++;
                    }
                }
                else if (timer_numbC1CH==4)
                {   
                    if (timer_numbC_d1[XSizeAndT,YSizeAndT] == 366)
                    {
                        timer_numbC1CH-=4;
                        timer_numbC_d1[XSizeAndT,YSizeAndT] = timer_numbC_d1[XSizeAndT,YSizeAndT] - 366;
                        timer_numbC_y1[XSizeAndT,YSizeAndT]++;
                    }
                }
                timer_numbC1[XSizeAndT,YSizeAndT] = timer_numbC1[XSizeAndT,YSizeAndT] - 86400;      
            }
        while (timer_numbC1[XSizeAndT,YSizeAndT] >= 3600)
            {
                timer_numbC_h1[XSizeAndT,YSizeAndT]++;
                timer_numbC1[XSizeAndT,YSizeAndT] = timer_numbC1[XSizeAndT,YSizeAndT] -  3600;
            }
        while (timer_numbC1[XSizeAndT,YSizeAndT] >= 60)
            {
                timer_numbC_m1[XSizeAndT,YSizeAndT]++;
                timer_numbC1[XSizeAndT,YSizeAndT] = timer_numbC1[XSizeAndT,YSizeAndT] - 60;
            }
        while (timer_numbC1[XSizeAndT,YSizeAndT] >= 1)
            {
                timer_numbC_s1[XSizeAndT,YSizeAndT]++;
                timer_numbC1[XSizeAndT,YSizeAndT] = timer_numbC1[XSizeAndT,YSizeAndT] - 1;
            }
        x = timer_numbC1[XSizeAndT,YSizeAndT] *100;            
        while (x >= 1)
            {
                mil_sec_for_textC1[XSizeAndT,YSizeAndT]++;
                x--;
            }     
        }
    private void Timer_text_Check(){
        Timer_Count_To_Normal();
        if (timer_numbC_CheckC[XSizeAndT,YSizeAndT] == 0)
            {
                b();
            }
        else if (timer_numbC_CheckC[XSizeAndT,YSizeAndT] == 1)
            {   
                timer_numbC_y[XSizeAndT,YSizeAndT] = PlayerPrefs.GetInt("timer_numbC_y" + XSizeAndT + YSizeAndT);
                timer_numbC_d[XSizeAndT,YSizeAndT] = PlayerPrefs.GetInt("timer_numbC_d" + XSizeAndT + YSizeAndT);
                timer_numbC_h[XSizeAndT,YSizeAndT] = PlayerPrefs.GetInt("timer_numbC_h" + XSizeAndT + YSizeAndT);
                timer_numbC_m[XSizeAndT,YSizeAndT] = PlayerPrefs.GetInt("timer_numbC_m" + XSizeAndT + YSizeAndT);
                timer_numbC_s[XSizeAndT,YSizeAndT] = PlayerPrefs.GetInt("timer_numbC_s" + XSizeAndT + YSizeAndT);
                timer_numbC[XSizeAndT,YSizeAndT] = PlayerPrefs.GetFloat("timer_numbC" + XSizeAndT + YSizeAndT);
                Timer_compare();
            }
        }

    private void T0_And_T1_EQ2(){
            timer_numbC_s[XSizeAndT,YSizeAndT] = timer_numbC_s1[XSizeAndT,YSizeAndT];
            timer_numbC_m[XSizeAndT,YSizeAndT] = timer_numbC_m1[XSizeAndT,YSizeAndT];
            timer_numbC_h[XSizeAndT,YSizeAndT] = timer_numbC_h1[XSizeAndT,YSizeAndT];
            timer_numbC_d[XSizeAndT,YSizeAndT] = timer_numbC_d1[XSizeAndT,YSizeAndT];
            timer_numbC_y[XSizeAndT,YSizeAndT] = timer_numbC_y1[XSizeAndT,YSizeAndT];
            timer_numbC[XSizeAndT,YSizeAndT] = timer_numbC1[XSizeAndT,YSizeAndT];
            mil_sec_for_textC[XSizeAndT,YSizeAndT] = mil_sec_for_textC1[XSizeAndT,YSizeAndT];
        }

    private void Timer_compare(){
        if (timer_numbC_y[XSizeAndT,YSizeAndT]<timer_numbC_y1[XSizeAndT,YSizeAndT])
            {
                a();
            }
        else if (timer_numbC_y[XSizeAndT,YSizeAndT]>timer_numbC_y1[XSizeAndT,YSizeAndT])
            {
                b();
            }
        else if (timer_numbC_y[XSizeAndT,YSizeAndT]==timer_numbC_y1[XSizeAndT,YSizeAndT])
            {
                if (timer_numbC_d[XSizeAndT,YSizeAndT]<timer_numbC_d1[XSizeAndT,YSizeAndT])
                    {
                        a();
                    }        
                else if (timer_numbC_d[XSizeAndT,YSizeAndT]>timer_numbC_d1[XSizeAndT,YSizeAndT])
                    {
                        b();
                    }        
                else if (timer_numbC_d[XSizeAndT,YSizeAndT]==timer_numbC_d1[XSizeAndT,YSizeAndT])
                    {
                        if (timer_numbC_h[XSizeAndT,YSizeAndT]<timer_numbC_h1[XSizeAndT,YSizeAndT])
                            {
                                a();    
                            }
                        else if (timer_numbC_h[XSizeAndT,YSizeAndT]>timer_numbC_h1[XSizeAndT,YSizeAndT])
                            {
                                b();   
                            }
                        else if (timer_numbC_h[XSizeAndT,YSizeAndT]==timer_numbC_h1[XSizeAndT,YSizeAndT])
                            {
                                if (timer_numbC_m[XSizeAndT,YSizeAndT]<timer_numbC_m1[XSizeAndT,YSizeAndT])
                                    {
                                        a();       
                                    }
                                else if (timer_numbC_m[XSizeAndT,YSizeAndT]>timer_numbC_m1[XSizeAndT,YSizeAndT])
                                    {
                                        b();       
                                    }
                                else if (timer_numbC_m[XSizeAndT,YSizeAndT]==timer_numbC_m1[XSizeAndT,YSizeAndT])
                                    {
                                        if (timer_numbC_s[XSizeAndT,YSizeAndT]<timer_numbC_s1[XSizeAndT,YSizeAndT])
                                            {
                                                a();
                                            }
                                        else if (timer_numbC_s[XSizeAndT,YSizeAndT]>timer_numbC_s1[XSizeAndT,YSizeAndT])
                                            {
                                                b();       
                                            }
                                        else if (timer_numbC_s[XSizeAndT,YSizeAndT]==timer_numbC_s1[XSizeAndT,YSizeAndT])
                                            { 
                                                if (timer_numbC[XSizeAndT,YSizeAndT]<timer_numbC1[XSizeAndT,YSizeAndT])
                                                    {
                                                        a();
                                                    }
                                                else if (timer_numbC[XSizeAndT,YSizeAndT]>timer_numbC1[XSizeAndT,YSizeAndT])
                                                    {
                                                        b();       
                                                    }
                                                else if (timer_numbC[XSizeAndT,YSizeAndT]==timer_numbC1[XSizeAndT,YSizeAndT])
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
            remember();
            XSizeAndT = PlayerPrefs.GetInt("XSizeAndT");
            YSizeAndT = PlayerPrefs.GetInt("YSizeAndT");
            if (XSizeAndT<100)
                {
                    if (YSizeAndT<100)
                        {
                            s = "0" + XSizeAndT + " X " + "0" + YSizeAndT + "\tC\t" + Timer_text.text;
                        }
                    else if (YSizeAndT>99)
                        {
                            s = "0" + XSizeAndT + " X " + YSizeAndT + "\tC\t" + Timer_text.text;
                        } 
                }
            else if (XSizeAndT>99)
                {
                    if (YSizeAndT<100)
                        {
                            s = XSizeAndT + " X " + "0" + YSizeAndT + "\tC\t" + Timer_text.text;
                        }
                    else if (YSizeAndT>99)
                        {
                            s = XSizeAndT + " X " + YSizeAndT + "\tC\t" + Timer_text.text;
                        } 
                }
            PlayerPrefs.SetString("s", s);
            XSizeAndT = PlayerPrefs.GetInt("XSizeAndT")-1;
            YSizeAndT = PlayerPrefs.GetInt("YSizeAndT")-1;
            PlayerPrefs.SetString("TextTimeC2"+XSizeAndT+YSizeAndT, s);
            Set_Timer_To_Zero1();
        }

    private void Timer_text_writer(){
            if (timer_numbC_y[XSizeAndT,YSizeAndT]>0)
                {
                    if (timer_numbC_d[XSizeAndT,YSizeAndT]>=10)
                        {
                            if (timer_numbC_h[XSizeAndT,YSizeAndT]<10)
                                {
                                    if (timer_numbC_m[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (timer_numbC_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":" +  timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":" +  timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbC_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":" +  timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }                        
                                    else if (timer_numbC_m[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (timer_numbC_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbC_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }
                                }
                            else if (timer_numbC_h[XSizeAndT,YSizeAndT]>=10)
                                {
                                    if (timer_numbC_m[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (timer_numbC_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbC_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }                        
                                    else if (timer_numbC_m[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (timer_numbC_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbC_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }
                                }
                        }
                    else if (timer_numbC_d[XSizeAndT,YSizeAndT]>0)
                        {
                            if (timer_numbC_h[XSizeAndT,YSizeAndT]<10)
                                {
                                    if (timer_numbC_m[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (timer_numbC_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":0" +  timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":0" +  timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbC_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":0" +  timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }                        
                                    else if (timer_numbC_m[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (timer_numbC_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbC_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }
                                }
                            else if (timer_numbC_h[XSizeAndT,YSizeAndT]>=10)
                                {
                                    if (timer_numbC_m[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (timer_numbC_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbC_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }                        
                                    else if (timer_numbC_m[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (timer_numbC_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbC_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbC_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_d[XSizeAndT,YSizeAndT] + ":" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }
                                }
                        }
                }
            else if (timer_numbC_d[XSizeAndT,YSizeAndT]>0)
                {
                    if (timer_numbC_h[XSizeAndT,YSizeAndT]<10)
                        {
                            if (timer_numbC_m[XSizeAndT,YSizeAndT]<10)
                                {
                                    if (timer_numbC_s[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                    else if (timer_numbC_s[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                }                        
                            else if (timer_numbC_m[XSizeAndT,YSizeAndT]>=10)
                                {
                                    if (timer_numbC_s[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                    else if (timer_numbC_s[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbC_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                }
                        }
                    else if (timer_numbC_h[XSizeAndT,YSizeAndT]>=10)
                        {
                            if (timer_numbC_m[XSizeAndT,YSizeAndT]<10)
                                {
                                    if (timer_numbC_s[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbC_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbC_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                    else if (timer_numbC_s[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbC_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbC_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                }                        
                            else if (timer_numbC_m[XSizeAndT,YSizeAndT]>=10)
                                {
                                    if (timer_numbC_s[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbC_d[XSizeAndT,YSizeAndT] + ":" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbC_d[XSizeAndT,YSizeAndT] + ":" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                    else if (timer_numbC_s[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbC_d[XSizeAndT,YSizeAndT] + ":" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbC_d[XSizeAndT,YSizeAndT] + ":" + timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                }
                        }
                }
            else if (timer_numbC_h[XSizeAndT,YSizeAndT]>0)
                {
                    if (timer_numbC_m[XSizeAndT,YSizeAndT]<10)
                        {
                            if (timer_numbC_s[XSizeAndT,YSizeAndT]<10)
                                {
                                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                        {
                                            Timer_text.text = timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                        }
                                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            Timer_text.text = timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                        }
                                }
                            else if (timer_numbC_s[XSizeAndT,YSizeAndT]>=10)
                                {
                                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                        {
                                            Timer_text.text = timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                        }
                                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            Timer_text.text = timer_numbC_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                        }
                                }
                        }
                    else if (timer_numbC_m[XSizeAndT,YSizeAndT]>=10)
                        {
                            if (timer_numbC_s[XSizeAndT,YSizeAndT]<10)
                                {
                                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                        {
                                            Timer_text.text = timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                        }
                                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            Timer_text.text = timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                        }
                                }
                            else if (timer_numbC_s[XSizeAndT,YSizeAndT]>=10)
                                {
                                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                        {
                                            Timer_text.text = timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                        }
                                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            Timer_text.text = timer_numbC_h[XSizeAndT,YSizeAndT] + ":" + timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                        }
                                }
                        }
                }
            else if (timer_numbC_m[XSizeAndT,YSizeAndT]>0)
                {
                    if (timer_numbC_s[XSizeAndT,YSizeAndT]<10)
                        {
                            if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                {
                                    Timer_text.text = timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                }
                            else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                {
                                    Timer_text.text = timer_numbC_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                }
                        }
                    else if (timer_numbC_s[XSizeAndT,YSizeAndT]>=10)
                        {
                            if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                                {
                                    Timer_text.text = timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                }
                            else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                                {
                                    Timer_text.text = timer_numbC_m[XSizeAndT,YSizeAndT] + ":" + timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                                }
                        }
                }
            else if (timer_numbC_s[XSizeAndT,YSizeAndT]>0)
                {
                    if (mil_sec_for_textC[XSizeAndT,YSizeAndT]<10)
                        {
                            Timer_text.text = timer_numbC_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                        }
                    else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>=10)
                        {
                            Timer_text.text = timer_numbC_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textC[XSizeAndT,YSizeAndT];
                        }
                }
            else if (mil_sec_for_textC[XSizeAndT,YSizeAndT]>0)
                {
                    Timer_text.text = "Really?";
                }
        }
        
    private void remember(){
            PlayerPrefs.SetInt("timer_numbC_y" + XSizeAndT + YSizeAndT, timer_numbC_y[XSizeAndT,YSizeAndT]);
            PlayerPrefs.SetInt("timer_numbC_d" + XSizeAndT + YSizeAndT, timer_numbC_d[XSizeAndT,YSizeAndT]);
            PlayerPrefs.SetInt("timer_numbC_h" + XSizeAndT + YSizeAndT, timer_numbC_h[XSizeAndT,YSizeAndT]);
            PlayerPrefs.SetInt("timer_numbC_m" + XSizeAndT + YSizeAndT, timer_numbC_m[XSizeAndT,YSizeAndT]);
            PlayerPrefs.SetInt("timer_numbC_s" + XSizeAndT + YSizeAndT, timer_numbC_s[XSizeAndT,YSizeAndT]);
            PlayerPrefs.SetFloat("timer_numbC" + XSizeAndT + YSizeAndT, timer_numbC[XSizeAndT,YSizeAndT]);
            PlayerPrefs.SetInt("mil_sec_for_textC" + XSizeAndT + YSizeAndT, mil_sec_for_textC[XSizeAndT,YSizeAndT]);
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

        PlayerPrefs.SetInt("DWB", 1);
        
        Timer_text_Check();
        if (timer_numbC_CheckC[XSizeAndT,YSizeAndT] == 0)
            {
                XSizeAndT = PlayerPrefs.GetInt("XSizeAndT")-1;
                YSizeAndT = PlayerPrefs.GetInt("YSizeAndT")-1;
                Q_Win_CustC = PlayerPrefs.GetInt("Q_Win_CustC");
                Q_Win_CustCX[Q_Win_CustC] = XSizeAndT;
                Q_Win_CustCY[Q_Win_CustC] = YSizeAndT;
                PlayerPrefs.SetInt("Q_Win_CustCX"+Q_Win_CustC, Q_Win_CustCX[Q_Win_CustC]);
                PlayerPrefs.SetInt("Q_Win_CustCY"+Q_Win_CustC, Q_Win_CustCY[Q_Win_CustC]);
                PlayerPrefs.SetInt("timer_numbC_CheckC" + XSizeAndT + YSizeAndT, 1);
                Q_Win_CustC++;
                PlayerPrefs.SetInt("Q_Win_CustC", Q_Win_CustC);
            }
        XSizeAndT = PlayerPrefs.GetInt("XSizeAndT");
        YSizeAndT = PlayerPrefs.GetInt("YSizeAndT");
        if (XSizeAndT<100)
            {
                if (YSizeAndT<100)
                    {
                        s = "0" + XSizeAndT + " X " + "0" + YSizeAndT + "\tC\t" + Timer_text.text;
                    }
                else if (YSizeAndT>99)
                    {
                        s = "0" + XSizeAndT + " X " + YSizeAndT + "\tC\t" + Timer_text.text;
                    } 
            }
        else if (XSizeAndT>99)
            {
                if (YSizeAndT<100)
                    {
                        s = XSizeAndT + " X " + "0" + YSizeAndT + "\tC\t" + Timer_text.text;
                    }
                else if (YSizeAndT>99)
                    {
                        s = XSizeAndT + " X " + YSizeAndT + "\tC\t" + Timer_text.text;
                    } 
            }
        PlayerPrefs.SetString("s", s);

        Set_Timer_To_Zero1();
        WinScreen.SetActive(true);
        other.gameObject.SetActive(false);
        }
}
