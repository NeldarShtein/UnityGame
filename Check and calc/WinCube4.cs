using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinCube4 : MonoBehaviour
    {
    public string supT = "";
    public int XSizeAndT;
    public int YSizeAndT;
    public int Q_Win_CustT;
    public int[] Q_Win_CustTX = new int [200];
    public int[] Q_Win_CustTY = new int [200];

    public int DWB = 0;

    public string[,] TextTimeC5 = new string [200,200];

    public GameObject WinScreen;
    public Text moneyText;
    public Text Timer_text;

    public int[,] timer_numbT_CheckC = new int [200,200];
    public float[,] timer_numbT = new float [200,200];
    public int[,] timer_numbT_s = new int [200,200];
    public int[,] timer_numbT_m = new int [200,200];
    public int[,] timer_numbT_h = new int [200,200];
    public int[,] timer_numbT_d = new int [200,200];
    public int[,] timer_numbT_y = new int [200,200];
    public int[,] mil_sec_for_textT = new int [200,200];
    public float[,] timer_numbT1 = new float [200,200];
    public int[,] timer_numbT_s1 = new int [200,200];
    public int[,] timer_numbT_m1 = new int [200,200];
    public int[,] timer_numbT_h1 = new int [200,200];
    public int[,] timer_numbT_d1 = new int [200,200];
    public int[,] timer_numbT_y1 = new int [200,200];
    public int[,] mil_sec_for_textT1 = new int [200,200];

    public int timer_numbT1CH = 0;
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
            timer_numbT_CheckC[XSizeAndT,YSizeAndT] = PlayerPrefs.GetInt("timer_numbT_CheckC" + XSizeAndT + YSizeAndT);
            PlayerPrefs.SetFloat("runSpeed", 30f);
            PlayerPrefs.SetFloat("strafeSpeed", 15f);
                    
            if (timer_numbT_CheckC[XSizeAndT,YSizeAndT] == 0)
                {
                    Set_Timer_To_Zero();
                    Set_Timer_To_Zero1();
                }
            else if (timer_numbT_CheckC[XSizeAndT,YSizeAndT] == 1)
                {
                    Set_Timer_To_Zero1();
                }
            Time.timeScale = 1f;
        }
    void FixedUpdate(){
        if (timer_numbT1[XSizeAndT,YSizeAndT] > 31557600)
            {
                timer_numbT_y1[XSizeAndT,YSizeAndT]++;
                timer_numbT1[XSizeAndT,YSizeAndT] = timer_numbT1[XSizeAndT,YSizeAndT] - 31557600;
            }
        timer_numbT1[XSizeAndT,YSizeAndT] += Time.deltaTime;
        }
    private void Set_Timer_To_Zero(){
            PlayerPrefs.SetInt("timer_numbT_y" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbT_d" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbT_h" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbT_m" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbT_s" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetFloat("timer_numbT" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("mil_sec_for_textT" + XSizeAndT + YSizeAndT, 0);
        }
    private void Set_Timer_To_Zero1(){
            PlayerPrefs.SetInt("timer_numbT_y1" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbT_d1" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbT_h1" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbT_m1" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbT_s1" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetFloat("timer_numbT1" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("mil_sec_for_textT1" + XSizeAndT + YSizeAndT, 0);
        }
    private void Timer_Count_To_Normal(){
        timer_numbT1CH = 0;
        while (timer_numbT1[XSizeAndT,YSizeAndT] >= 86400)
            {
                timer_numbT_d1[XSizeAndT,YSizeAndT]++;
                if (timer_numbT1CH<4)
                {
                    if (timer_numbT_d1[XSizeAndT,YSizeAndT] == 365)
                    {
                        timer_numbT1CH++;
                        timer_numbT_d1[XSizeAndT,YSizeAndT] = timer_numbT_d1[XSizeAndT,YSizeAndT] - 365;
                        timer_numbT_y1[XSizeAndT,YSizeAndT]++;
                    }
                }
                else if (timer_numbT1CH==4)
                {   
                    if (timer_numbT_d1[XSizeAndT,YSizeAndT] == 366)
                    {
                        timer_numbT1CH-=4;
                        timer_numbT_d1[XSizeAndT,YSizeAndT] = timer_numbT_d1[XSizeAndT,YSizeAndT] - 366;
                        timer_numbT_y1[XSizeAndT,YSizeAndT]++;
                    }
                }
                timer_numbT1[XSizeAndT,YSizeAndT] = timer_numbT1[XSizeAndT,YSizeAndT] - 86400;      
            }
        while (timer_numbT1[XSizeAndT,YSizeAndT] >= 3600)
            {
                timer_numbT_h1[XSizeAndT,YSizeAndT]++;
                timer_numbT1[XSizeAndT,YSizeAndT] = timer_numbT1[XSizeAndT,YSizeAndT] -  3600;
            }
        while (timer_numbT1[XSizeAndT,YSizeAndT] >= 60)
            {
                timer_numbT_m1[XSizeAndT,YSizeAndT]++;
                timer_numbT1[XSizeAndT,YSizeAndT] = timer_numbT1[XSizeAndT,YSizeAndT] - 60;
            }
        while (timer_numbT1[XSizeAndT,YSizeAndT] >= 1)
            {
                timer_numbT_s1[XSizeAndT,YSizeAndT]++;
                timer_numbT1[XSizeAndT,YSizeAndT] = timer_numbT1[XSizeAndT,YSizeAndT] - 1;
            }
        x = timer_numbT1[XSizeAndT,YSizeAndT] *100;            
        while (x >= 1)
            {
                mil_sec_for_textT1[XSizeAndT,YSizeAndT]++;
                x--;
            }     
        }

  

    private void Timer_text_Check(){
        Timer_Count_To_Normal();
        if (timer_numbT_CheckC[XSizeAndT,YSizeAndT] == 0)
            {
                b();
            }
        else if (timer_numbT_CheckC[XSizeAndT,YSizeAndT] == 1)
            {   
                timer_numbT_y[XSizeAndT,YSizeAndT] = PlayerPrefs.GetInt("timer_numbT_y" + XSizeAndT + YSizeAndT);
                timer_numbT_d[XSizeAndT,YSizeAndT] = PlayerPrefs.GetInt("timer_numbT_d" + XSizeAndT + YSizeAndT);
                timer_numbT_h[XSizeAndT,YSizeAndT] = PlayerPrefs.GetInt("timer_numbT_h" + XSizeAndT + YSizeAndT);
                timer_numbT_m[XSizeAndT,YSizeAndT] = PlayerPrefs.GetInt("timer_numbT_m" + XSizeAndT + YSizeAndT);
                timer_numbT_s[XSizeAndT,YSizeAndT] = PlayerPrefs.GetInt("timer_numbT_s" + XSizeAndT + YSizeAndT);
                timer_numbT[XSizeAndT,YSizeAndT] = PlayerPrefs.GetFloat("timer_numbT" + XSizeAndT + YSizeAndT);
                Timer_compare();
            }
        }

    private void T0_And_T1_EQ2(){
            timer_numbT_s[XSizeAndT,YSizeAndT] = timer_numbT_s1[XSizeAndT,YSizeAndT];
            timer_numbT_m[XSizeAndT,YSizeAndT] = timer_numbT_m1[XSizeAndT,YSizeAndT];
            timer_numbT_h[XSizeAndT,YSizeAndT] = timer_numbT_h1[XSizeAndT,YSizeAndT];
            timer_numbT_d[XSizeAndT,YSizeAndT] = timer_numbT_d1[XSizeAndT,YSizeAndT];
            timer_numbT_y[XSizeAndT,YSizeAndT] = timer_numbT_y1[XSizeAndT,YSizeAndT];
            timer_numbT[XSizeAndT,YSizeAndT] = timer_numbT1[XSizeAndT,YSizeAndT];
            mil_sec_for_textT[XSizeAndT,YSizeAndT] = mil_sec_for_textT1[XSizeAndT,YSizeAndT];
        }

    private void Timer_compare(){
        if (timer_numbT_y[XSizeAndT,YSizeAndT]<timer_numbT_y1[XSizeAndT,YSizeAndT])
            {
                a();
            }
        else if (timer_numbT_y[XSizeAndT,YSizeAndT]>timer_numbT_y1[XSizeAndT,YSizeAndT])
            {
                b();
            }
        else if (timer_numbT_y[XSizeAndT,YSizeAndT]==timer_numbT_y1[XSizeAndT,YSizeAndT])
            {
                if (timer_numbT_d[XSizeAndT,YSizeAndT]<timer_numbT_d1[XSizeAndT,YSizeAndT])
                    {
                        a();
                    }        
                else if (timer_numbT_d[XSizeAndT,YSizeAndT]>timer_numbT_d1[XSizeAndT,YSizeAndT])
                    {
                        b();
                    }        
                else if (timer_numbT_d[XSizeAndT,YSizeAndT]==timer_numbT_d1[XSizeAndT,YSizeAndT])
                    {
                        if (timer_numbT_h[XSizeAndT,YSizeAndT]<timer_numbT_h1[XSizeAndT,YSizeAndT])
                            {
                                a();    
                            }
                        else if (timer_numbT_h[XSizeAndT,YSizeAndT]>timer_numbT_h1[XSizeAndT,YSizeAndT])
                            {
                                b();   
                            }
                        else if (timer_numbT_h[XSizeAndT,YSizeAndT]==timer_numbT_h1[XSizeAndT,YSizeAndT])
                            {
                                if (timer_numbT_m[XSizeAndT,YSizeAndT]<timer_numbT_m1[XSizeAndT,YSizeAndT])
                                    {
                                        a();       
                                    }
                                else if (timer_numbT_m[XSizeAndT,YSizeAndT]>timer_numbT_m1[XSizeAndT,YSizeAndT])
                                    {
                                        b();       
                                    }
                                else if (timer_numbT_m[XSizeAndT,YSizeAndT]==timer_numbT_m1[XSizeAndT,YSizeAndT])
                                    {
                                        if (timer_numbT_s[XSizeAndT,YSizeAndT]<timer_numbT_s1[XSizeAndT,YSizeAndT])
                                            {
                                                a();
                                            }
                                        else if (timer_numbT_s[XSizeAndT,YSizeAndT]>timer_numbT_s1[XSizeAndT,YSizeAndT])
                                            {
                                                b();       
                                            }
                                        else if (timer_numbT_s[XSizeAndT,YSizeAndT]==timer_numbT_s1[XSizeAndT,YSizeAndT])
                                            { 
                                                if (timer_numbT[XSizeAndT,YSizeAndT]<timer_numbT1[XSizeAndT,YSizeAndT])
                                                    {
                                                        a();
                                                    }
                                                else if (timer_numbT[XSizeAndT,YSizeAndT]>timer_numbT1[XSizeAndT,YSizeAndT])
                                                    {
                                                        b();       
                                                    }
                                                else if (timer_numbT[XSizeAndT,YSizeAndT]==timer_numbT1[XSizeAndT,YSizeAndT])
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
                            supT = "0" + XSizeAndT + " X " + "0" + YSizeAndT + "\tT\t" + Timer_text.text;
                        }
                    else if (YSizeAndT>99)
                        {
                            supT = "0" + XSizeAndT + " X " + YSizeAndT + "\tT\t" + Timer_text.text;
                        } 
                }
            else if (XSizeAndT>99)
                {
                    if (YSizeAndT<100)
                        {
                            supT = XSizeAndT + " X " + "0" + YSizeAndT + "\tT\t" + Timer_text.text;
                        }
                    else if (YSizeAndT>99)
                        {
                            supT = XSizeAndT + " X " + YSizeAndT + "\tT\t" + Timer_text.text;
                        } 
                }
            PlayerPrefs.SetString("supT", supT);
            XSizeAndT = PlayerPrefs.GetInt("XSizeAndT")-1;
            YSizeAndT = PlayerPrefs.GetInt("YSizeAndT")-1;
            PlayerPrefs.SetString("TextTimeC4"+XSizeAndT+YSizeAndT, supT);
            Set_Timer_To_Zero1();
        }

    private void Timer_text_writer(){
            if (timer_numbT_y[XSizeAndT,YSizeAndT]>0)
                {
                    if (timer_numbT_d[XSizeAndT,YSizeAndT]>=10)
                        {
                            if (timer_numbT_h[XSizeAndT,YSizeAndT]<10)
                                {
                                    if (timer_numbT_m[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (timer_numbT_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":" +  timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":" +  timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbT_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":" +  timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }                        
                                    else if (timer_numbT_m[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (timer_numbT_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbT_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }
                                }
                            else if (timer_numbT_h[XSizeAndT,YSizeAndT]>=10)
                                {
                                    if (timer_numbT_m[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (timer_numbT_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbT_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }                        
                                    else if (timer_numbT_m[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (timer_numbT_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbT_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }
                                }
                        }
                    else if (timer_numbT_d[XSizeAndT,YSizeAndT]>0)
                        {
                            if (timer_numbT_h[XSizeAndT,YSizeAndT]<10)
                                {
                                    if (timer_numbT_m[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (timer_numbT_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":0" +  timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":0" +  timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbT_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":0" +  timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }                        
                                    else if (timer_numbT_m[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (timer_numbT_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbT_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }
                                }
                            else if (timer_numbT_h[XSizeAndT,YSizeAndT]>=10)
                                {
                                    if (timer_numbT_m[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (timer_numbT_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbT_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }                        
                                    else if (timer_numbT_m[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (timer_numbT_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbT_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbT_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_d[XSizeAndT,YSizeAndT] + ":" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }
                                }
                        }
                }
            else if (timer_numbT_d[XSizeAndT,YSizeAndT]>0)
                {
                    if (timer_numbT_h[XSizeAndT,YSizeAndT]<10)
                        {
                            if (timer_numbT_m[XSizeAndT,YSizeAndT]<10)
                                {
                                    if (timer_numbT_s[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                    else if (timer_numbT_s[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                }                        
                            else if (timer_numbT_m[XSizeAndT,YSizeAndT]>=10)
                                {
                                    if (timer_numbT_s[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                    else if (timer_numbT_s[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbT_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                }
                        }
                    else if (timer_numbT_h[XSizeAndT,YSizeAndT]>=10)
                        {
                            if (timer_numbT_m[XSizeAndT,YSizeAndT]<10)
                                {
                                    if (timer_numbT_s[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbT_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbT_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                    else if (timer_numbT_s[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbT_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbT_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                }                        
                            else if (timer_numbT_m[XSizeAndT,YSizeAndT]>=10)
                                {
                                    if (timer_numbT_s[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbT_d[XSizeAndT,YSizeAndT] + ":" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbT_d[XSizeAndT,YSizeAndT] + ":" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                    else if (timer_numbT_s[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbT_d[XSizeAndT,YSizeAndT] + ":" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbT_d[XSizeAndT,YSizeAndT] + ":" + timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                }
                        }
                }
            else if (timer_numbT_h[XSizeAndT,YSizeAndT]>0)
                {
                    if (timer_numbT_m[XSizeAndT,YSizeAndT]<10)
                        {
                            if (timer_numbT_s[XSizeAndT,YSizeAndT]<10)
                                {
                                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                        {
                                            Timer_text.text = timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                        }
                                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            Timer_text.text = timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                        }
                                }
                            else if (timer_numbT_s[XSizeAndT,YSizeAndT]>=10)
                                {
                                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                        {
                                            Timer_text.text = timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                        }
                                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            Timer_text.text = timer_numbT_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                        }
                                }
                        }
                    else if (timer_numbT_m[XSizeAndT,YSizeAndT]>=10)
                        {
                            if (timer_numbT_s[XSizeAndT,YSizeAndT]<10)
                                {
                                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                        {
                                            Timer_text.text = timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                        }
                                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            Timer_text.text = timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                        }
                                }
                            else if (timer_numbT_s[XSizeAndT,YSizeAndT]>=10)
                                {
                                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                        {
                                            Timer_text.text = timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                        }
                                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            Timer_text.text = timer_numbT_h[XSizeAndT,YSizeAndT] + ":" + timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                        }
                                }
                        }
                }
            else if (timer_numbT_m[XSizeAndT,YSizeAndT]>0)
                {
                    if (timer_numbT_s[XSizeAndT,YSizeAndT]<10)
                        {
                            if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                {
                                    Timer_text.text = timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                }
                            else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                {
                                    Timer_text.text = timer_numbT_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                }
                        }
                    else if (timer_numbT_s[XSizeAndT,YSizeAndT]>=10)
                        {
                            if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                                {
                                    Timer_text.text = timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                }
                            else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                                {
                                    Timer_text.text = timer_numbT_m[XSizeAndT,YSizeAndT] + ":" + timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                                }
                        }
                }
            else if (timer_numbT_s[XSizeAndT,YSizeAndT]>0)
                {
                    if (mil_sec_for_textT[XSizeAndT,YSizeAndT]<10)
                        {
                            Timer_text.text = timer_numbT_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                        }
                    else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>=10)
                        {
                            Timer_text.text = timer_numbT_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textT[XSizeAndT,YSizeAndT];
                        }
                }
            else if (mil_sec_for_textT[XSizeAndT,YSizeAndT]>0)
                {
                    Timer_text.text = "Really?";
                }
        }
        
    private void remember(){
            PlayerPrefs.SetInt("timer_numbT_y" + XSizeAndT + YSizeAndT, timer_numbT_y[XSizeAndT,YSizeAndT]);
            PlayerPrefs.SetInt("timer_numbT_d" + XSizeAndT + YSizeAndT, timer_numbT_d[XSizeAndT,YSizeAndT]);
            PlayerPrefs.SetInt("timer_numbT_h" + XSizeAndT + YSizeAndT, timer_numbT_h[XSizeAndT,YSizeAndT]);
            PlayerPrefs.SetInt("timer_numbT_m" + XSizeAndT + YSizeAndT, timer_numbT_m[XSizeAndT,YSizeAndT]);
            PlayerPrefs.SetInt("timer_numbT_s" + XSizeAndT + YSizeAndT, timer_numbT_s[XSizeAndT,YSizeAndT]);
            PlayerPrefs.SetFloat("timer_numbT" + XSizeAndT + YSizeAndT, timer_numbT[XSizeAndT,YSizeAndT]);
            PlayerPrefs.SetInt("mil_sec_for_textT" + XSizeAndT + YSizeAndT, mil_sec_for_textT[XSizeAndT,YSizeAndT]);
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
        if (timer_numbT_CheckC[XSizeAndT,YSizeAndT] == 0)
            {
                XSizeAndT = PlayerPrefs.GetInt("XSizeAndT")-1;
                YSizeAndT = PlayerPrefs.GetInt("YSizeAndT")-1;
                Q_Win_CustT = PlayerPrefs.GetInt("Q_Win_CustT");
                Q_Win_CustTX[Q_Win_CustT] = XSizeAndT;
                Q_Win_CustTY[Q_Win_CustT] = YSizeAndT;
                PlayerPrefs.SetInt("Q_Win_CustTX"+Q_Win_CustT, Q_Win_CustTX[Q_Win_CustT]);
                PlayerPrefs.SetInt("Q_Win_CustTY"+Q_Win_CustT, Q_Win_CustTY[Q_Win_CustT]);
                PlayerPrefs.SetInt("timer_numbT_CheckC" + XSizeAndT + YSizeAndT, 1);
                Q_Win_CustT++;
                PlayerPrefs.SetInt("Q_Win_CustT", Q_Win_CustT);
            }
        XSizeAndT = PlayerPrefs.GetInt("XSizeAndT");
        YSizeAndT = PlayerPrefs.GetInt("YSizeAndT");
        if (XSizeAndT<100)
            {
                if (YSizeAndT<100)
                    {
                        supT = "0" + XSizeAndT + " X " + "0" + YSizeAndT + "\tT\t" + Timer_text.text;
                    }
                else if (YSizeAndT>99)
                    {
                        supT = "0" + XSizeAndT + " X " + YSizeAndT + "\tT\t" + Timer_text.text;
                    } 
            }
        else if (XSizeAndT>99)
            {
                if (YSizeAndT<100)
                    {
                        supT = XSizeAndT + " X " + "0" + YSizeAndT + "\tT\t" + Timer_text.text;
                    }
                else if (YSizeAndT>99)
                    {
                        supT = XSizeAndT + " X " + YSizeAndT + "\tT\t" + Timer_text.text;
                    } 
            }
        PlayerPrefs.SetString("supT", supT);

        Set_Timer_To_Zero1();
        WinScreen.SetActive(true);
        other.gameObject.SetActive(false);
        }
}
