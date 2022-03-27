using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CUSTOM : MonoBehaviour
{
    public int XSizeAndT;
    public int YSizeAndT;

    public int DWB = 0;
    public int a = 0;
    public int g = 0;
    public int Type = 0;
    public string s = "";
    public string sup = "";
    public string supA = "";
    public string supT = "";

    public int RESULTS_Quant;
    public int RESULTS_QuantM;
    public string[] RESULTS_Text = new string [200];

    public int[] Global_x_size = new int [200];
    public int[] Global_y_size = new int [200];
    public int _x_size;
    public int _y_size;

    public Text XSizeAndTT;
    public Text YSizeAndTT;
    public Text TypeSizeAndTT;
    public string[,] TextTimeC2 = new string [200,200];
    public string[,] TextTimeC3 = new string [200,200];
    public string[,] TextTimeC4 = new string [200,200];
    public string[,] TextTimeC5 = new string [200,200];

    public Text Try;
    public int Star;

    void Start()
        {
            DWB = PlayerPrefs.GetInt("DWB");
            if (DWB==0)
                {
                    PlayerPrefs.SetInt("YSizeAndT", 20);
                    YSizeAndTT.text = "020";
                    PlayerPrefs.SetInt("Type", 0);
                    TypeSizeAndTT.text = "CLASSIC";
                    PlayerPrefs.SetInt("XSizeAndT", 20);
                    XSizeAndTT.text = "020";
                    a = PlayerPrefs.GetInt("XSizeAndT")-1;
                    g = PlayerPrefs.GetInt("YSizeAndT")-1;
                    Try.text = PlayerPrefs.GetString("TextTimeC2" + a + g);
                }
            else if (DWB==1)
                {
                    YSizeAndT = PlayerPrefs.GetInt("YSizeAndT")-1;
                    XSizeAndT = PlayerPrefs.GetInt("XSizeAndT")-1;
                    Type = PlayerPrefs.GetInt("Type");
                    RESULTS_Quant = PlayerPrefs.GetInt("RESULTS_Quant");
                    if (Type==0)
                    {
                        s = PlayerPrefs.GetString("s");
                        TextTimeC2[XSizeAndT, YSizeAndT] = s;
                        PlayerPrefs.SetString("RESULTS_Text"+RESULTS_Quant, s);
                    }
                    else if (Type==1)
                    {
                        sup = PlayerPrefs.GetString("sup");
                        TextTimeC2[XSizeAndT, YSizeAndT] = sup;
                        PlayerPrefs.SetString("RESULTS_Text"+RESULTS_Quant, sup);
                    }
                    else if (Type==2)
                    {
                        supA = PlayerPrefs.GetString("supA");
                        TextTimeC4[XSizeAndT, YSizeAndT] = supA;
                        PlayerPrefs.SetString("RESULTS_Text"+RESULTS_Quant, supA);
                    }
                    else if (Type==3)
                    {
                        supT = PlayerPrefs.GetString("supT");
                        TextTimeC5[XSizeAndT, YSizeAndT] = supT;
                        PlayerPrefs.SetString("RESULTS_Text"+RESULTS_Quant, supT);
                    }
                    
                    if (RESULTS_Quant==199)
                        {
                            PlayerPrefs.SetInt("RESULTS_Quant", 0);
                            PlayerPrefs.SetInt("RESULTS_QuantM", 1);
                            
                        }
                    else if (RESULTS_Quant<199)
                        {
                            RESULTS_Quant++;
                            PlayerPrefs.SetInt("RESULTS_Quant", RESULTS_Quant); 
                        }
                    
                    PlayerPrefs.SetInt("YSizeAndT", 20);
                    YSizeAndTT.text = "020";
                    PlayerPrefs.SetInt("Type", 0);
                    TypeSizeAndTT.text = "CLASSIC";
                    PlayerPrefs.SetInt("XSizeAndT", 20);
                    PlayerPrefs.SetInt("DWB", 0);
                    XSizeAndTT.text = "020"; 
                    a = PlayerPrefs.GetInt("XSizeAndT")-1;
                    g = PlayerPrefs.GetInt("YSizeAndT")-1;
                    Try.text = PlayerPrefs.GetString("TextTimeC2" + a + g);
                }
        }
    public void Try_text(){
            if (Type==0)
                {
                    a = PlayerPrefs.GetInt("XSizeAndT")-1;
                    g = PlayerPrefs.GetInt("YSizeAndT")-1;
                    Try.text = PlayerPrefs.GetString("TextTimeC2" + a + g);
                }
            else if (Type==1)
                {
                    a = PlayerPrefs.GetInt("XSizeAndT")-1;
                    g = PlayerPrefs.GetInt("YSizeAndT")-1;
                    Try.text = PlayerPrefs.GetString("TextTimeC3" + a + g);
                }
            else if (Type==2)
                {
                    a = PlayerPrefs.GetInt("XSizeAndT")-1;
                    g = PlayerPrefs.GetInt("YSizeAndT")-1;
                    Try.text = PlayerPrefs.GetString("TextTimeC4" + a + g);
                }
            else if (Type==3)
                {
                    a = PlayerPrefs.GetInt("XSizeAndT")-1;
                    g = PlayerPrefs.GetInt("YSizeAndT")-1;
                    Try.text = PlayerPrefs.GetString("TextTimeC5" + a + g);
                }
        }

    public void XSizeAndTInc1()
        {
            XSizeAndT = PlayerPrefs.GetInt("XSizeAndT");
            if (XSizeAndT<200)
                {
                    XSizeAndT = XSizeAndT + 1;
                    PlayerPrefs.SetInt("XSizeAndT", XSizeAndT);
                    if (XSizeAndT<100)
                        {
                            XSizeAndTT.text = "0" + XSizeAndT; 
                        }
                    else if (XSizeAndT>99)
                        {
                            XSizeAndTT.text = XSizeAndT+ " ";
                        }            
                }
            Try_text();     
        }
    public void YSizeAndTInc1()
        {
            YSizeAndT = PlayerPrefs.GetInt("YSizeAndT");
            if (YSizeAndT<200)
                {
                    YSizeAndT = YSizeAndT + 1;
                    PlayerPrefs.SetInt("YSizeAndT", YSizeAndT);
                    if (YSizeAndT<100)
                        {
                            YSizeAndTT.text = "0" + YSizeAndT; 
                        }
                    else if (YSizeAndT>99)
                        {
                            YSizeAndTT.text = YSizeAndT+ " ";
                        }            
                }
            Try_text();        
        }
    public void XSizeAndTInc10()
        {
            XSizeAndT = PlayerPrefs.GetInt("XSizeAndT");
            if (XSizeAndT<200)
                {
                    XSizeAndT = XSizeAndT + 10;
                    if (XSizeAndT>200)
                    {
                        XSizeAndT = 200;
                    }
                    PlayerPrefs.SetInt("XSizeAndT", XSizeAndT);
                    if (XSizeAndT<100)
                        {
                            XSizeAndTT.text = "0" + XSizeAndT; 
                        }
                    else if (XSizeAndT>99)
                        {
                            XSizeAndTT.text = XSizeAndT+ " ";
                        }            
                }     
            Try_text();   
        }
    public void YSizeAndTInc10()
        {
            YSizeAndT = PlayerPrefs.GetInt("YSizeAndT");
            if (YSizeAndT<200)
                {
                    YSizeAndT = YSizeAndT + 10;
                    if (YSizeAndT>200)
                    {
                        YSizeAndT = 200;
                    }
                    PlayerPrefs.SetInt("YSizeAndT", YSizeAndT);
                    if (YSizeAndT<100)
                        {
                            YSizeAndTT.text = "0" + YSizeAndT; 
                        }
                    else if (YSizeAndT>99)
                        {
                            YSizeAndTT.text = YSizeAndT+ " ";
                        }            
                }     
            Try_text();   
        }
    public void XSizeAndTInc100()
        {
            XSizeAndT = PlayerPrefs.GetInt("XSizeAndT");
            if (XSizeAndT<200)
                {
                    XSizeAndT = XSizeAndT + 100;
                    if (XSizeAndT>200)
                    {
                        XSizeAndT = 200;
                    }
                    PlayerPrefs.SetInt("XSizeAndT", XSizeAndT);
                    if (XSizeAndT<100)
                        {
                            XSizeAndTT.text = "0" + XSizeAndT; 
                        }
                    else if (XSizeAndT>99)
                        {
                            XSizeAndTT.text = XSizeAndT+ " ";
                        }            
                }     
            Try_text();   
        }
    public void YSizeAndTInc100()
        {
            YSizeAndT = PlayerPrefs.GetInt("YSizeAndT");
            if (YSizeAndT<200)
                {
                    YSizeAndT = YSizeAndT + 100;
                    if (YSizeAndT>200)
                    {
                        YSizeAndT = 200;
                    }
                    PlayerPrefs.SetInt("YSizeAndT", YSizeAndT);
                    if (YSizeAndT<100)
                        {
                            YSizeAndTT.text = "0" + YSizeAndT; 
                        }
                    else if (YSizeAndT>99)
                        {
                            YSizeAndTT.text = YSizeAndT+ " ";
                        }            
                }     
            Try_text();   
        }
    public void XSizeAndTDec1()
        {
            XSizeAndT = PlayerPrefs.GetInt("XSizeAndT");
            if (XSizeAndT>20)
                {
                    XSizeAndT = XSizeAndT - 1;
                    PlayerPrefs.SetInt("XSizeAndT", XSizeAndT);
                    if (XSizeAndT<100)
                        {
                            XSizeAndTT.text = "0" + XSizeAndT; 
                        }
                    else if (XSizeAndT>99)
                        {
                            XSizeAndTT.text = XSizeAndT+ " ";
                        }            
                }     
            Try_text();   
        }
    public void YSizeAndTDec1()
        {
            YSizeAndT = PlayerPrefs.GetInt("YSizeAndT");
            if (YSizeAndT>20)
                {
                    YSizeAndT = YSizeAndT - 1;
                    PlayerPrefs.SetInt("YSizeAndT", YSizeAndT);
                    if (YSizeAndT<100)
                        {
                            YSizeAndTT.text = "0" + YSizeAndT; 
                        }
                    else if (YSizeAndT>99)
                        {
                            YSizeAndTT.text = YSizeAndT+ " ";
                        }            
                }     
            Try_text();   
        }
    public void XSizeAndTDec10()
        {
            XSizeAndT = PlayerPrefs.GetInt("XSizeAndT");
            if (XSizeAndT>20)
                {
                    XSizeAndT = XSizeAndT - 10;
                    if (XSizeAndT<20)
                    {
                        XSizeAndT = 20;
                    }
                    PlayerPrefs.SetInt("XSizeAndT", XSizeAndT);
                    if (XSizeAndT<100)
                        {
                            XSizeAndTT.text = "0" + XSizeAndT; 
                        }
                    else if (XSizeAndT>99)
                        {
                            XSizeAndTT.text = XSizeAndT+ " ";
                        }            
                }     
            Try_text();   
        }
    public void YSizeAndTDec10()
        {
            YSizeAndT = PlayerPrefs.GetInt("YSizeAndT");
            if (YSizeAndT>20)
                {
                    YSizeAndT = YSizeAndT - 10;
                    if (YSizeAndT<20)
                    {
                        YSizeAndT = 20;
                    }
                    PlayerPrefs.SetInt("YSizeAndT", YSizeAndT);
                    if (YSizeAndT<100)
                        {
                            YSizeAndTT.text = "0" + YSizeAndT; 
                        }
                    else if (YSizeAndT>99)
                        {
                            YSizeAndTT.text = YSizeAndT+ " ";
                        }            
                }     
            Try_text();   
        }
    public void XSizeAndTDec100()
        {
            XSizeAndT = PlayerPrefs.GetInt("XSizeAndT");
            if (XSizeAndT>20)
                {
                    XSizeAndT = XSizeAndT - 100;
                    if (XSizeAndT<20)
                    {
                        XSizeAndT = 20;
                    }
                    PlayerPrefs.SetInt("XSizeAndT", XSizeAndT);
                    if (XSizeAndT<100)
                        {
                            XSizeAndTT.text = "0" + XSizeAndT; 
                        }
                    else if (XSizeAndT>99)
                        {
                            XSizeAndTT.text = XSizeAndT+ " ";
                        }            
                }     
            Try_text();   
        }
    public void YSizeAndTDec100()
        {
            YSizeAndT = PlayerPrefs.GetInt("YSizeAndT");
            if (YSizeAndT>20)
                {
                    YSizeAndT = YSizeAndT - 100;
                    if (YSizeAndT<20)
                    {
                        YSizeAndT = 20;
                    }
                    PlayerPrefs.SetInt("YSizeAndT", YSizeAndT);
                    if (YSizeAndT<100)
                        {
                            YSizeAndTT.text = "0" + YSizeAndT; 
                        }
                    else if (YSizeAndT>99)
                        {
                            YSizeAndTT.text = YSizeAndT+ " ";
                        }            
                }     
            Try_text();   
        }

    public void work(){
        XSizeAndT = PlayerPrefs.GetInt("XSizeAndT");
        YSizeAndT = PlayerPrefs.GetInt("YSizeAndT");
        Type = PlayerPrefs.GetInt("Type");
        PlayerPrefs.SetInt("_x_size", XSizeAndT);
        PlayerPrefs.SetInt("_y_size", YSizeAndT);
        PlayerPrefs.SetInt("Type", Type);
        if (Type==0)
            {
                SceneManager.LoadScene("Maze3DC", LoadSceneMode.Single);
            }
        else if (Type==1)
            {
                SceneManager.LoadScene("Maze3DCH", LoadSceneMode.Single);
            }
        else if (Type==2)
            {
                SceneManager.LoadScene("Maze3DCA", LoadSceneMode.Single);
            }
        else if (Type==3)
            {
                SceneManager.LoadScene("Maze3DCT", LoadSceneMode.Single);
            }
        }
    public void TypeINC(){
        Star = PlayerPrefs.GetInt("Star");
        Type = PlayerPrefs.GetInt("Type");
        if (Star<=10)
        {
            if (Type==1)
                {
                    Try_text(); 
                }
            else if (Type==0)
                {
                    Type++;
                    PlayerPrefs.SetInt("Type", Type);
                    TypeSizeAndTT.text = "HARD";
                    Try_text(); 
                }
        }
        else if (Star>=15)
        {
            if (Type==3)
                {
                    Try_text(); 
                }
            else if (Type==2)
                {
                    Type++;
                    PlayerPrefs.SetInt("Type", Type);
                    TypeSizeAndTT.text = "T_RECILIC";
                    Try_text(); 
                }
            else if (Type==1)
                {
                    Type++;
                    PlayerPrefs.SetInt("Type", Type);
                    TypeSizeAndTT.text = "ABOVE_T_V";
                    Try_text(); 
                }
            else if (Type==0)
                {
                    Type++;
                    PlayerPrefs.SetInt("Type", Type);
                    TypeSizeAndTT.text = "HARD";
                    Try_text(); 
                }
        }
        else if (Star>=10)
            {
                if (Type==2)
                    {
                        Try_text(); 
                    }
                else if (Type==1)
                    {
                        Type++;
                        PlayerPrefs.SetInt("Type", Type);
                        TypeSizeAndTT.text = "ABOVE_T_V";
                        Try_text(); 
                    }
                else if (Type==0)
                    {
                        Type++;
                        PlayerPrefs.SetInt("Type", Type);
                        TypeSizeAndTT.text = "HARD";
                    }
            }
            
        }
    public void TypeDec(){
        Star = PlayerPrefs.GetInt("Star");
        Type = PlayerPrefs.GetInt("Type");
        if (Star<=10)
            {
                if (Type==0)
                    {
                        Try_text(); 
                    }
                else if (Type==1)
                    {
                        Type--;
                        PlayerPrefs.SetInt("Type", Type);
                        TypeSizeAndTT.text = "CLASSIC";
                        Try_text();
                    }
            }
        else if (Star>=15)
            {
                if (Type==0)
                    {
                        Try_text(); 
                    }
                else if (Type==1)
                    {
                        Type--;
                        PlayerPrefs.SetInt("Type", Type);
                        TypeSizeAndTT.text = "CLASSIC";
                        Try_text(); 
                    }
                else if (Type==2)
                    {
                        Type--;
                        PlayerPrefs.SetInt("Type", Type);
                        TypeSizeAndTT.text = "HARD";
                        Try_text(); 
                    }
                else if (Type==3)
                    {
                        Type--;
                        PlayerPrefs.SetInt("Type", Type);
                        TypeSizeAndTT.text = "ABOVE_T_V";
                        Try_text(); 
                    }
            }
        else if (Star>=10)
            {
                if (Type==0)
                    {
                        Try_text(); 
                    }
                else if (Type==1)
                    {
                        Type--;
                        PlayerPrefs.SetInt("Type", Type);
                        TypeSizeAndTT.text = "CLASSIC";
                        Try_text(); 
                    }
                else if (Type==2)
                    {
                        Type--;
                        PlayerPrefs.SetInt("Type", Type);
                        TypeSizeAndTT.text = "HARD";
                        Try_text(); 
                    }
            }
        } 
} 