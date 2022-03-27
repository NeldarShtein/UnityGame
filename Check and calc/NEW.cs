using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NEW : MonoBehaviour
{
    public int ContinuePrevGame;
    public GameObject ContButton;

    public int[] figure = new int[10];
    public int[] color_material = new int[10];

    public int[] Star_was_Received = new int [25];
    public int[] Achivement_Status = new int [25];
    public int Star=15;

    public int Level=1;
    public int SpeedLV=1;
    public int DistanceLV=1;
    public int JumpLV=1;
    public int points=0;
    public int skinNChange;
    public int g = 0;
    public int h = 0;
    public int x = 0;
    public int ShopN;
    public int ShopN2;
    
    public int TotMonAm=0;

    public int RESULTS_Quant;
    public int RESULTS_QuantM;
    public string[] RESULTS_Text = new string [200];

    public string[] TextTimeWT = new string [100];
    public string[] TextTimeWA = new string [100];
    public string[] TextTimeW = new string [200];

    public int[] timer_numb_Check = new int [200];
    public int[] timer_numbA_Check = new int [100];
    public int[] timer_numbT_CheckT = new int [100];

    public string LoadSceneName = "";
    public int LevelNumber = 0;
    public int[] LevelNumberN = new int[10];
    public int[] LevelNumberNA = new int[5];
    public int[] LevelNumberNT = new int[5];
    public int MoneyPerLevel = 0;
    public int money = 0;

    public int musicN = 0;
    public int DWB = 0;

    public int[,] timer_numbC_CheckC = new int [200,200];
    public int[,] timer_numbH_CheckC = new int [200,200];
    public int[,] timer_numbA_CheckC = new int [200,200];
    public int[,] timer_numbT_CheckC = new int [200,200];

    public int Q_Win_CustC;
    public int Q_Win_CustH;
    public int Q_Win_CustA;
    public int Q_Win_CustT;

    public int[] Q_Win_CustCX = new int [200];
    public int[] Q_Win_CustCY = new int [200];
    public int[] Q_Win_CustHX = new int [200];
    public int[] Q_Win_CustHY = new int [200];
    public int[] Q_Win_CustAX = new int [200];
    public int[] Q_Win_CustAY = new int [200];
    public int[] Q_Win_CustTX = new int [200];
    public int[] Q_Win_CustTY = new int [200];

    public string[,] TextTimeC2 = new string [200,200];
    public string[,] TextTimeC3 = new string [200,200];
    public string[,] TextTimeC4 = new string [200,200];
    public string[,] TextTimeC5 = new string [200,200];

    public int timer_numb_CheckAmountC;
    public int timer_numb_CheckAmountH;
    public int timer_numbT_CheckTAmount;
    public int timer_numbAT_CheckAmount;

    void Start()
    {
        ContinuePrevGame = PlayerPrefs.GetInt("ContinuePrevGame");
        if (ContinuePrevGame == 1)
        {
            ContButton.SetActive(false);
        }
        else if (ContinuePrevGame > 1)
        {
            ContButton.SetActive(true);
        }
        else if (ContinuePrevGame<1)
        {
            LoadSceneButtonNEW();
        }

    }

    public void LoadSceneButtonNEW()
    {
        Q_Win_CustC = PlayerPrefs.GetInt("Q_Win_CustC");
        Q_Win_CustH = PlayerPrefs.GetInt("Q_Win_CustH");
        Q_Win_CustA = PlayerPrefs.GetInt("Q_Win_CustA");
        Q_Win_CustT = PlayerPrefs.GetInt("Q_Win_CustT");
        while (Q_Win_CustC>0)
        {
            Q_Win_CustC--;
            Q_Win_CustCX[Q_Win_CustC] = PlayerPrefs.GetInt("Q_Win_CustCX" + Q_Win_CustC);
            Q_Win_CustCY[Q_Win_CustC] = PlayerPrefs.GetInt("Q_Win_CustCY" + Q_Win_CustC);
            PlayerPrefs.SetInt("timer_numbC_CheckC" + Q_Win_CustCX[Q_Win_CustC] + Q_Win_CustCY[Q_Win_CustC], 0);
            PlayerPrefs.SetString("TextTimeC2" + Q_Win_CustCX[Q_Win_CustC] + Q_Win_CustCY[Q_Win_CustC], " ");
            PlayerPrefs.SetInt("Q_Win_CustC", Q_Win_CustC);
        }
        while (Q_Win_CustH>0)
        {
            Q_Win_CustH--;
            Q_Win_CustHX[Q_Win_CustH] = PlayerPrefs.GetInt("Q_Win_CustHX" + Q_Win_CustH);
            Q_Win_CustHY[Q_Win_CustH] = PlayerPrefs.GetInt("Q_Win_CustHY" + Q_Win_CustH);
            PlayerPrefs.SetInt("timer_numbH_CheckC" + Q_Win_CustHX[Q_Win_CustH] + Q_Win_CustHY[Q_Win_CustH], 0);
            PlayerPrefs.SetString("TextTimeC3" + Q_Win_CustHX[Q_Win_CustH] + Q_Win_CustHY[Q_Win_CustH], " ");
            PlayerPrefs.SetInt("Q_Win_CustH", Q_Win_CustH);
        }
        while (Q_Win_CustA>0)
        {
            Q_Win_CustA--;
            Q_Win_CustAX[Q_Win_CustA] = PlayerPrefs.GetInt("Q_Win_CustAX" + Q_Win_CustA);
            Q_Win_CustAY[Q_Win_CustA] = PlayerPrefs.GetInt("Q_Win_CustAY" + Q_Win_CustA);
            PlayerPrefs.SetInt("timer_numbA_CheckC" + Q_Win_CustAX[Q_Win_CustA] + Q_Win_CustAY[Q_Win_CustA], 0);
            PlayerPrefs.SetString("TextTimeC4" + Q_Win_CustAX[Q_Win_CustA] + Q_Win_CustAY[Q_Win_CustA], " ");
            PlayerPrefs.SetInt("Q_Win_CustA", Q_Win_CustA);
        }
        while (Q_Win_CustT>0)
        {
            Q_Win_CustT--;
            Q_Win_CustTX[Q_Win_CustT] = PlayerPrefs.GetInt("Q_Win_CustTX" + Q_Win_CustT);
            Q_Win_CustTY[Q_Win_CustT] = PlayerPrefs.GetInt("Q_Win_CustTY" + Q_Win_CustT);
            PlayerPrefs.SetInt("timer_numbT_CheckC" + Q_Win_CustTX[Q_Win_CustT] + Q_Win_CustTY[Q_Win_CustT], 0);
            PlayerPrefs.SetString("TextTimeC5" + Q_Win_CustTX[Q_Win_CustT] + Q_Win_CustTY[Q_Win_CustT], " ");
            PlayerPrefs.SetInt("Q_Win_CustT", Q_Win_CustT);
        }

        PlayerPrefs.SetInt("ContinuePrevGame", 0);
        for (int i = 0; i < 10; i++)
        {
            PlayerPrefs.SetInt("LevelNumberN"+i, 0);
            PlayerPrefs.SetInt("figure"+i, 0);
            PlayerPrefs.SetInt("color_material"+i, 0);
        }
        PlayerPrefs.SetInt("figure"+0, 1);
        PlayerPrefs.SetInt("color_material"+0, 1);

        RESULTS_Quant = PlayerPrefs.GetInt("RESULTS_Quant");
        RESULTS_QuantM = PlayerPrefs.GetInt("RESULTS_QuantM");
        if (RESULTS_QuantM==1)
            {
                for (int i = 0; i < 200; i++)
                {
                    PlayerPrefs.SetString("RESULTS_Text" + i, "");
                }
            }
        else if (RESULTS_QuantM==0)
            {
                while (RESULTS_Quant>0)
                    {
                        RESULTS_Quant--;
                        PlayerPrefs.SetString("RESULTS_Text" + RESULTS_Quant, "");
                    }
            }
        PlayerPrefs.SetInt("RESULTS_Quant", 0);
        PlayerPrefs.SetInt("RESULTS_QuantM", 0);
        for (int i = 0; i < 100; i++)
        {
            PlayerPrefs.SetString("TextTimeWT" + i, "");
            PlayerPrefs.SetString("TextTimeWA" + i, "");
        }
        for (int i = 0; i < 200; i++)
        {
            PlayerPrefs.SetString("TextTimeW" + i, "");
            PlayerPrefs.SetString("RESULTS_Text" + i, "");
        }

        for (int i = 0; i < 5; i++)
            {
                PlayerPrefs.SetInt("LevelNumberNA"+i, 0);
                PlayerPrefs.SetInt("LevelNumberNH"+i, 0);
            }

        timer_numb_CheckAmountC = PlayerPrefs.GetInt("timer_numb_CheckAmountC");
        timer_numb_CheckAmountH = PlayerPrefs.GetInt("timer_numb_CheckAmountH");
        timer_numbT_CheckTAmount = PlayerPrefs.GetInt("timer_numbT_CheckTAmount");
        timer_numbAT_CheckAmount = PlayerPrefs.GetInt("timer_numbAT_CheckAmount");
        while (timer_numb_CheckAmountC>0)
            {
                timer_numb_CheckAmountC--;
                PlayerPrefs.SetInt("timer_numb_Check"+timer_numb_CheckAmountC, 0);
                PlayerPrefs.SetInt("timer_numb_CheckAmountC", timer_numb_CheckAmountC);
            }
        while (timer_numb_CheckAmountH>0)
            {
                timer_numb_CheckAmountH--;
                x = 100+timer_numb_CheckAmountH;
                PlayerPrefs.SetInt("timer_numb_Check"+x, 0);
                PlayerPrefs.SetInt("timer_numb_CheckAmountH", timer_numb_CheckAmountH);
            }
        while (timer_numbT_CheckTAmount>0)
            {
                timer_numbT_CheckTAmount--;
                PlayerPrefs.SetInt("timer_numbT_CheckT"+timer_numbT_CheckTAmount, 0);
                PlayerPrefs.SetInt("timer_numbT_CheckTAmount", timer_numbT_CheckTAmount);
            }
        while (timer_numbAT_CheckAmount>0)
            {
                timer_numbAT_CheckAmount--;
                PlayerPrefs.SetInt("timer_numbA_Check"+timer_numbAT_CheckAmount, 0);
                PlayerPrefs.SetInt("timer_numbAT_CheckAmount", timer_numbAT_CheckAmount);
            }

        for (int i = 0; i < 25; i++)
        {
            PlayerPrefs.SetInt("Achivement_Status"+i, 0);
            PlayerPrefs.SetInt("Star_was_Received"+i, 0);
        }

        PlayerPrefs.SetInt("Star", Star);
        PlayerPrefs.SetInt("LevelNumber", LevelNumber);

        PlayerPrefs.SetInt("g", g);
        PlayerPrefs.SetInt("h", h);
        PlayerPrefs.SetInt("skinNChange", 0);
        PlayerPrefs.SetInt("ShopN2", ShopN2);
        PlayerPrefs.SetInt("ShopN", ShopN);
        
        PlayerPrefs.SetInt("TotMonAm", TotMonAm);

        PlayerPrefs.SetInt("MoneyPerLevel", MoneyPerLevel);
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("musicN", musicN);
        PlayerPrefs.SetInt("DWB", DWB);

        PlayerPrefs.SetInt("points", points);
        PlayerPrefs.SetInt("Level", Level);
        PlayerPrefs.SetInt("SpeedLV", SpeedLV);
        PlayerPrefs.SetInt("DistanceLV", DistanceLV);
        PlayerPrefs.SetInt("JumpLV", JumpLV);

        Time.timeScale = 1f;

        SceneManager.LoadScene(LoadSceneName, LoadSceneMode.Single);
    }
}
