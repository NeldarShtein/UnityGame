using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinCube2 : MonoBehaviour
    {
    public string sup = "";
    public int XSizeAndT;
    public int YSizeAndT;
    public int Q_Win_CustH;
    public int[] Q_Win_CustHX = new int [200];
    public int[] Q_Win_CustHY = new int [200];

    public int DWB = 0;

    public string[,] TextTimeC3 = new string [200,200];

    public GameObject WinScreen;
    public Text moneyText;
    public Text Timer_text;

    public int[,] timer_numbH_CheckC = new int [200,200];
    public float[,] timer_numbH = new float [200,200];
    public int[,] timer_numbH_s = new int [200,200];
    public int[,] timer_numbH_m = new int [200,200];
    public int[,] timer_numbH_h = new int [200,200];
    public int[,] timer_numbH_d = new int [200,200];
    public int[,] timer_numbH_y = new int [200,200];
    public int[,] mil_sec_for_textH = new int [200,200];
    public float[,] timer_numbH1 = new float [200,200];
    public int[,] timer_numbH_s1 = new int [200,200];
    public int[,] timer_numbH_m1 = new int [200,200];
    public int[,] timer_numbH_h1 = new int [200,200];
    public int[,] timer_numbH_d1 = new int [200,200];
    public int[,] timer_numbH_y1 = new int [200,200];
    public int[,] mil_sec_for_textH1 = new int [200,200];

    public int timer_numbH1CH = 0;
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
            timer_numbH_CheckC[XSizeAndT,YSizeAndT] = PlayerPrefs.GetInt("timer_numbH_CheckC" + XSizeAndT + YSizeAndT);
            PlayerPrefs.SetFloat("runSpeed", 30f);
            PlayerPrefs.SetFloat("strafeSpeed", 15f);
                    
            if (timer_numbH_CheckC[XSizeAndT,YSizeAndT] == 0)
                {
                    Set_Timer_To_Zero();
                    Set_Timer_To_Zero1();
                }
            else if (timer_numbH_CheckC[XSizeAndT,YSizeAndT] == 1)
                {
                    Set_Timer_To_Zero1();
                }
            Time.timeScale = 1f;
        }
    void FixedUpdate(){
        if (timer_numbH1[XSizeAndT,YSizeAndT] > 31557600)
            {
                timer_numbH_y1[XSizeAndT,YSizeAndT]++;
                timer_numbH1[XSizeAndT,YSizeAndT] = timer_numbH1[XSizeAndT,YSizeAndT] - 31557600;
            }
        timer_numbH1[XSizeAndT,YSizeAndT] += Time.deltaTime;
        }
    private void Set_Timer_To_Zero(){
            PlayerPrefs.SetInt("timer_numbH_y" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbH_d" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbH_h" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbH_m" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbH_s" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetFloat("timer_numbH" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("mil_sec_for_textH" + XSizeAndT + YSizeAndT, 0);
        }
    private void Set_Timer_To_Zero1(){
            PlayerPrefs.SetInt("timer_numbH_y1" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbH_d1" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbH_h1" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbH_m1" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("timer_numbH_s1" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetFloat("timer_numbH1" + XSizeAndT + YSizeAndT, 0);
            PlayerPrefs.SetInt("mil_sec_for_textH1" + XSizeAndT + YSizeAndT, 0);
        }
    private void Timer_Count_To_Normal(){
        timer_numbH1CH = 0;
        while (timer_numbH1[XSizeAndT,YSizeAndT] >= 86400)
            {
                timer_numbH_d1[XSizeAndT,YSizeAndT]++;
                if (timer_numbH1CH<4)
                {
                    if (timer_numbH_d1[XSizeAndT,YSizeAndT] == 365)
                    {
                        timer_numbH1CH++;
                        timer_numbH_d1[XSizeAndT,YSizeAndT] = timer_numbH_d1[XSizeAndT,YSizeAndT] - 365;
                        timer_numbH_y1[XSizeAndT,YSizeAndT]++;
                    }
                }
                else if (timer_numbH1CH==4)
                {   
                    if (timer_numbH_d1[XSizeAndT,YSizeAndT] == 366)
                    {
                        timer_numbH1CH-=4;
                        timer_numbH_d1[XSizeAndT,YSizeAndT] = timer_numbH_d1[XSizeAndT,YSizeAndT] - 366;
                        timer_numbH_y1[XSizeAndT,YSizeAndT]++;
                    }
                }
                timer_numbH1[XSizeAndT,YSizeAndT] = timer_numbH1[XSizeAndT,YSizeAndT] - 86400;      
            }
        while (timer_numbH1[XSizeAndT,YSizeAndT] >= 3600)
            {
                timer_numbH_h1[XSizeAndT,YSizeAndT]++;
                timer_numbH1[XSizeAndT,YSizeAndT] = timer_numbH1[XSizeAndT,YSizeAndT] -  3600;
            }
        while (timer_numbH1[XSizeAndT,YSizeAndT] >= 60)
            {
                timer_numbH_m1[XSizeAndT,YSizeAndT]++;
                timer_numbH1[XSizeAndT,YSizeAndT] = timer_numbH1[XSizeAndT,YSizeAndT] - 60;
            }
        while (timer_numbH1[XSizeAndT,YSizeAndT] >= 1)
            {
                timer_numbH_s1[XSizeAndT,YSizeAndT]++;
                timer_numbH1[XSizeAndT,YSizeAndT] = timer_numbH1[XSizeAndT,YSizeAndT] - 1;
            }
        x = timer_numbH1[XSizeAndT,YSizeAndT] *100;            
        while (x >= 1)
            {
                mil_sec_for_textH1[XSizeAndT,YSizeAndT]++;
                x--;
            }     
        }

  

    private void Timer_text_Check(){
        Timer_Count_To_Normal();
        if (timer_numbH_CheckC[XSizeAndT,YSizeAndT] == 0)
            {
                b();
            }
        else if (timer_numbH_CheckC[XSizeAndT,YSizeAndT] == 1)
            {   
                timer_numbH_y[XSizeAndT,YSizeAndT] = PlayerPrefs.GetInt("timer_numbH_y" + XSizeAndT + YSizeAndT);
                timer_numbH_d[XSizeAndT,YSizeAndT] = PlayerPrefs.GetInt("timer_numbH_d" + XSizeAndT + YSizeAndT);
                timer_numbH_h[XSizeAndT,YSizeAndT] = PlayerPrefs.GetInt("timer_numbH_h" + XSizeAndT + YSizeAndT);
                timer_numbH_m[XSizeAndT,YSizeAndT] = PlayerPrefs.GetInt("timer_numbH_m" + XSizeAndT + YSizeAndT);
                timer_numbH_s[XSizeAndT,YSizeAndT] = PlayerPrefs.GetInt("timer_numbH_s" + XSizeAndT + YSizeAndT);
                timer_numbH[XSizeAndT,YSizeAndT] = PlayerPrefs.GetFloat("timer_numbH" + XSizeAndT + YSizeAndT);
                Timer_compare();
            }
        }

    private void T0_And_T1_EQ2(){
            timer_numbH_s[XSizeAndT,YSizeAndT] = timer_numbH_s1[XSizeAndT,YSizeAndT];
            timer_numbH_m[XSizeAndT,YSizeAndT] = timer_numbH_m1[XSizeAndT,YSizeAndT];
            timer_numbH_h[XSizeAndT,YSizeAndT] = timer_numbH_h1[XSizeAndT,YSizeAndT];
            timer_numbH_d[XSizeAndT,YSizeAndT] = timer_numbH_d1[XSizeAndT,YSizeAndT];
            timer_numbH_y[XSizeAndT,YSizeAndT] = timer_numbH_y1[XSizeAndT,YSizeAndT];
            timer_numbH[XSizeAndT,YSizeAndT] = timer_numbH1[XSizeAndT,YSizeAndT];
            mil_sec_for_textH[XSizeAndT,YSizeAndT] = mil_sec_for_textH1[XSizeAndT,YSizeAndT];
        }

    private void Timer_compare(){
        if (timer_numbH_y[XSizeAndT,YSizeAndT]<timer_numbH_y1[XSizeAndT,YSizeAndT])
            {
                a();
            }
        else if (timer_numbH_y[XSizeAndT,YSizeAndT]>timer_numbH_y1[XSizeAndT,YSizeAndT])
            {
                b();
            }
        else if (timer_numbH_y[XSizeAndT,YSizeAndT]==timer_numbH_y1[XSizeAndT,YSizeAndT])
            {
                if (timer_numbH_d[XSizeAndT,YSizeAndT]<timer_numbH_d1[XSizeAndT,YSizeAndT])
                    {
                        a();
                    }        
                else if (timer_numbH_d[XSizeAndT,YSizeAndT]>timer_numbH_d1[XSizeAndT,YSizeAndT])
                    {
                        b();
                    }        
                else if (timer_numbH_d[XSizeAndT,YSizeAndT]==timer_numbH_d1[XSizeAndT,YSizeAndT])
                    {
                        if (timer_numbH_h[XSizeAndT,YSizeAndT]<timer_numbH_h1[XSizeAndT,YSizeAndT])
                            {
                                a();    
                            }
                        else if (timer_numbH_h[XSizeAndT,YSizeAndT]>timer_numbH_h1[XSizeAndT,YSizeAndT])
                            {
                                b();   
                            }
                        else if (timer_numbH_h[XSizeAndT,YSizeAndT]==timer_numbH_h1[XSizeAndT,YSizeAndT])
                            {
                                if (timer_numbH_m[XSizeAndT,YSizeAndT]<timer_numbH_m1[XSizeAndT,YSizeAndT])
                                    {
                                        a();       
                                    }
                                else if (timer_numbH_m[XSizeAndT,YSizeAndT]>timer_numbH_m1[XSizeAndT,YSizeAndT])
                                    {
                                        b();       
                                    }
                                else if (timer_numbH_m[XSizeAndT,YSizeAndT]==timer_numbH_m1[XSizeAndT,YSizeAndT])
                                    {
                                        if (timer_numbH_s[XSizeAndT,YSizeAndT]<timer_numbH_s1[XSizeAndT,YSizeAndT])
                                            {
                                                a();
                                            }
                                        else if (timer_numbH_s[XSizeAndT,YSizeAndT]>timer_numbH_s1[XSizeAndT,YSizeAndT])
                                            {
                                                b();       
                                            }
                                        else if (timer_numbH_s[XSizeAndT,YSizeAndT]==timer_numbH_s1[XSizeAndT,YSizeAndT])
                                            { 
                                                if (timer_numbH[XSizeAndT,YSizeAndT]<timer_numbH1[XSizeAndT,YSizeAndT])
                                                    {
                                                        a();
                                                    }
                                                else if (timer_numbH[XSizeAndT,YSizeAndT]>timer_numbH1[XSizeAndT,YSizeAndT])
                                                    {
                                                        b();       
                                                    }
                                                else if (timer_numbH[XSizeAndT,YSizeAndT]==timer_numbH1[XSizeAndT,YSizeAndT])
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
                            sup = "0" + XSizeAndT + " X " + "0" + YSizeAndT + "\tH\t" + Timer_text.text;
                        }
                    else if (YSizeAndT>99)
                        {
                            sup = "0" + XSizeAndT + " X " + YSizeAndT + "\tH\t" + Timer_text.text;
                        } 
                }
            else if (XSizeAndT>99)
                {
                    if (YSizeAndT<100)
                        {
                            sup = XSizeAndT + " X " + "0" + YSizeAndT + "\tH\t" + Timer_text.text;
                        }
                    else if (YSizeAndT>99)
                        {
                            sup = XSizeAndT + " X " + YSizeAndT + "\tH\t" + Timer_text.text;
                        } 
                }
            PlayerPrefs.SetString("sup", sup);
            XSizeAndT = PlayerPrefs.GetInt("XSizeAndT")-1;
            YSizeAndT = PlayerPrefs.GetInt("YSizeAndT")-1;
            PlayerPrefs.SetString("TextTimeC3"+XSizeAndT+YSizeAndT, sup);
            Set_Timer_To_Zero1();
        }

    private void Timer_text_writer(){
            if (timer_numbH_y[XSizeAndT,YSizeAndT]>0)
                {
                    if (timer_numbH_d[XSizeAndT,YSizeAndT]>=10)
                        {
                            if (timer_numbH_h[XSizeAndT,YSizeAndT]<10)
                                {
                                    if (timer_numbH_m[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (timer_numbH_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":" +  timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":" +  timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbH_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":" +  timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }                        
                                    else if (timer_numbH_m[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (timer_numbH_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbH_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }
                                }
                            else if (timer_numbH_h[XSizeAndT,YSizeAndT]>=10)
                                {
                                    if (timer_numbH_m[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (timer_numbH_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbH_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }                        
                                    else if (timer_numbH_m[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (timer_numbH_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbH_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }
                                }
                        }
                    else if (timer_numbH_d[XSizeAndT,YSizeAndT]>0)
                        {
                            if (timer_numbH_h[XSizeAndT,YSizeAndT]<10)
                                {
                                    if (timer_numbH_m[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (timer_numbH_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":0" +  timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":0" +  timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbH_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":0" +  timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }                        
                                    else if (timer_numbH_m[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (timer_numbH_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbH_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }
                                }
                            else if (timer_numbH_h[XSizeAndT,YSizeAndT]>=10)
                                {
                                    if (timer_numbH_m[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (timer_numbH_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbH_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }                        
                                    else if (timer_numbH_m[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (timer_numbH_s[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                            else if (timer_numbH_s[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                        {
                                                            Timer_text.text = timer_numbH_y[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_d[XSizeAndT,YSizeAndT] + ":" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                        }
                                                }
                                        }
                                }
                        }
                }
            else if (timer_numbH_d[XSizeAndT,YSizeAndT]>0)
                {
                    if (timer_numbH_h[XSizeAndT,YSizeAndT]<10)
                        {
                            if (timer_numbH_m[XSizeAndT,YSizeAndT]<10)
                                {
                                    if (timer_numbH_s[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                    else if (timer_numbH_s[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                }                        
                            else if (timer_numbH_m[XSizeAndT,YSizeAndT]>=10)
                                {
                                    if (timer_numbH_s[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                    else if (timer_numbH_s[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbH_d[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                }
                        }
                    else if (timer_numbH_h[XSizeAndT,YSizeAndT]>=10)
                        {
                            if (timer_numbH_m[XSizeAndT,YSizeAndT]<10)
                                {
                                    if (timer_numbH_s[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbH_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbH_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                    else if (timer_numbH_s[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbH_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbH_d[XSizeAndT,YSizeAndT] + ":" +  timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                }                        
                            else if (timer_numbH_m[XSizeAndT,YSizeAndT]>=10)
                                {
                                    if (timer_numbH_s[XSizeAndT,YSizeAndT]<10)
                                        {
                                            if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbH_d[XSizeAndT,YSizeAndT] + ":" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbH_d[XSizeAndT,YSizeAndT] + ":" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                    else if (timer_numbH_s[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                                {
                                                    Timer_text.text = timer_numbH_d[XSizeAndT,YSizeAndT] + ":" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                }
                                            else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                                {
                                                    Timer_text.text = timer_numbH_d[XSizeAndT,YSizeAndT] + ":" + timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                                }
                                        }
                                }
                        }
                }
            else if (timer_numbH_h[XSizeAndT,YSizeAndT]>0)
                {
                    if (timer_numbH_m[XSizeAndT,YSizeAndT]<10)
                        {
                            if (timer_numbH_s[XSizeAndT,YSizeAndT]<10)
                                {
                                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                        {
                                            Timer_text.text = timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                        }
                                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            Timer_text.text = timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                        }
                                }
                            else if (timer_numbH_s[XSizeAndT,YSizeAndT]>=10)
                                {
                                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                        {
                                            Timer_text.text = timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                        }
                                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            Timer_text.text = timer_numbH_h[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                        }
                                }
                        }
                    else if (timer_numbH_m[XSizeAndT,YSizeAndT]>=10)
                        {
                            if (timer_numbH_s[XSizeAndT,YSizeAndT]<10)
                                {
                                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                        {
                                            Timer_text.text = timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                        }
                                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            Timer_text.text = timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                        }
                                }
                            else if (timer_numbH_s[XSizeAndT,YSizeAndT]>=10)
                                {
                                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                        {
                                            Timer_text.text = timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                        }
                                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                        {
                                            Timer_text.text = timer_numbH_h[XSizeAndT,YSizeAndT] + ":" + timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                        }
                                }
                        }
                }
            else if (timer_numbH_m[XSizeAndT,YSizeAndT]>0)
                {
                    if (timer_numbH_s[XSizeAndT,YSizeAndT]<10)
                        {
                            if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                {
                                    Timer_text.text = timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                }
                            else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                {
                                    Timer_text.text = timer_numbH_m[XSizeAndT,YSizeAndT] + ":0" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                }
                        }
                    else if (timer_numbH_s[XSizeAndT,YSizeAndT]>=10)
                        {
                            if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                                {
                                    Timer_text.text = timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                }
                            else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                                {
                                    Timer_text.text = timer_numbH_m[XSizeAndT,YSizeAndT] + ":" + timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                                }
                        }
                }
            else if (timer_numbH_s[XSizeAndT,YSizeAndT]>0)
                {
                    if (mil_sec_for_textH[XSizeAndT,YSizeAndT]<10)
                        {
                            Timer_text.text = timer_numbH_s[XSizeAndT,YSizeAndT] + ":0" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                        }
                    else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>=10)
                        {
                            Timer_text.text = timer_numbH_s[XSizeAndT,YSizeAndT] + ":" + mil_sec_for_textH[XSizeAndT,YSizeAndT];
                        }
                }
            else if (mil_sec_for_textH[XSizeAndT,YSizeAndT]>0)
                {
                    Timer_text.text = "Really?";
                }
        }
        
    private void remember(){
            PlayerPrefs.SetInt("timer_numbH_y" + XSizeAndT + YSizeAndT, timer_numbH_y[XSizeAndT,YSizeAndT]);
            PlayerPrefs.SetInt("timer_numbH_d" + XSizeAndT + YSizeAndT, timer_numbH_d[XSizeAndT,YSizeAndT]);
            PlayerPrefs.SetInt("timer_numbH_h" + XSizeAndT + YSizeAndT, timer_numbH_h[XSizeAndT,YSizeAndT]);
            PlayerPrefs.SetInt("timer_numbH_m" + XSizeAndT + YSizeAndT, timer_numbH_m[XSizeAndT,YSizeAndT]);
            PlayerPrefs.SetInt("timer_numbH_s" + XSizeAndT + YSizeAndT, timer_numbH_s[XSizeAndT,YSizeAndT]);
            PlayerPrefs.SetFloat("timer_numbH" + XSizeAndT + YSizeAndT, timer_numbH[XSizeAndT,YSizeAndT]);
            PlayerPrefs.SetInt("mil_sec_for_textH" + XSizeAndT + YSizeAndT, mil_sec_for_textH[XSizeAndT,YSizeAndT]);
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
        
        if (timer_numbH_CheckC[XSizeAndT,YSizeAndT] == 0)
            {
                XSizeAndT = PlayerPrefs.GetInt("XSizeAndT")-1;
                YSizeAndT = PlayerPrefs.GetInt("YSizeAndT")-1;
                Q_Win_CustH = PlayerPrefs.GetInt("Q_Win_CustH");
                Q_Win_CustHX[Q_Win_CustH] = XSizeAndT;
                Q_Win_CustHY[Q_Win_CustH] = YSizeAndT;
                PlayerPrefs.SetInt("Q_Win_CustHX"+Q_Win_CustH, Q_Win_CustHX[Q_Win_CustH]);
                PlayerPrefs.SetInt("Q_Win_CustHY"+Q_Win_CustH, Q_Win_CustHY[Q_Win_CustH]);
                PlayerPrefs.SetInt("timer_numbH_CheckC" + XSizeAndT + YSizeAndT, 1);
                Q_Win_CustH++;
                PlayerPrefs.SetInt("Q_Win_CustH", Q_Win_CustH);
            }
        XSizeAndT = PlayerPrefs.GetInt("XSizeAndT");
        YSizeAndT = PlayerPrefs.GetInt("YSizeAndT");
        if (XSizeAndT<100)
            {
                if (YSizeAndT<100)
                    {
                        sup = "0" + XSizeAndT + " X " + "0" + YSizeAndT + "\tH\t" + Timer_text.text;
                    }
                else if (YSizeAndT>99)
                    {
                        sup = "0" + XSizeAndT + " X " + YSizeAndT + "\tH\t" + Timer_text.text;
                    } 
            }
        else if (XSizeAndT>99)
            {
                if (YSizeAndT<100)
                    {
                        sup = XSizeAndT + " X " + "0" + YSizeAndT + "\tH\t" + Timer_text.text;
                    }
                else if (YSizeAndT>99)
                    {
                        sup = XSizeAndT + " X " + YSizeAndT + "\tH\t" + Timer_text.text;
                    } 
            }
        PlayerPrefs.SetString("sup", sup);

        Set_Timer_To_Zero1();
        WinScreen.SetActive(true);
        other.gameObject.SetActive(false);
        }
}
