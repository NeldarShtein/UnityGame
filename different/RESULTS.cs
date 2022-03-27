using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RESULTS : MonoBehaviour
{
    public Text [] RESULTSText;
    public int RESULTS_Quant;
    public string[] RESULTS_Text = new string [200];
    public int b = 0;
    public int d = 0;
    public int x = 0;
    public int y = 0;

    void Start()
    {
        y = 0;
        b = 0;
        d = 0;
        x = PlayerPrefs.GetInt("RESULTS_Quant");
        while (x>=20)
        {
            y++;
            x=x-20;
        }
        PlayerPrefs.SetInt("y", y);
        PlayerPrefs.SetInt("x", x);
        for (int i = 0; i < 20; i++)
        {
            d = b*20+i;
            RESULTSText[i].text = PlayerPrefs.GetString("RESULTS_Text"+d);
        }
    }

    public void next_Res(){
        if (b==y)
        {
            for (int i = 0; i < 20; i++)
                {
                    d = b*20+i;
                    RESULTSText[i].text = PlayerPrefs.GetString("RESULTS_Text"+d);
                }
        }
        else if (b<y)
        {
            b++;
            for (int i = 0; i < 20; i++)
                {
                    d = b*20+i;
                    RESULTSText[i].text = PlayerPrefs.GetString("RESULTS_Text"+d);
                }
        }
    }
    public void prev_Res(){
        if (b==0)
        {
            for (int i = 0; i < 20; i++)
                {
                    d = b*20+i;
                    RESULTSText[i].text = PlayerPrefs.GetString("RESULTS_Text"+d);
                }
        }
        else if (b>0)
        {
            b--;
            for (int i = 0; i < 20; i++)
                {
                    d = b*20+i;
                    RESULTSText[i].text = PlayerPrefs.GetString("RESULTS_Text"+d);
                }
        }
        
    }
}
