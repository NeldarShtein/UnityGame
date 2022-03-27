using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    public int musicN;
    public Text musicText;

    private void Start()
    {
        musicN = PlayerPrefs.GetInt("musicN");
        if (musicN != 0)
        {
            if (musicN != 1)
                {
                    musicN = 0;
                    PlayerPrefs.SetInt("musicN", musicN);
                }
        }
        if (musicN == 0)
            {
                musicText.text = "MUSIC: ON";
            }
        else if (musicN  == 1)
            {
                musicText.text = "MUSIC: OFF";
            }
    }
    public void MusicInc()
    {
        if (musicN == 0)
            {
                musicN++;
                musicText.text = "MUSIC: OFF";
            }
        else if (musicN  == 1)
            {
                musicN--;
                musicText.text = "MUSIC: ON";
            }  
        PlayerPrefs.SetInt("musicN", musicN);
    }
}