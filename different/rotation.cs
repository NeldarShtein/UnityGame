using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotation : MonoBehaviour
{
    private int RotationCoin = 0;
    public Text RotationCoinText;

    private void Start()
    {
        RotationCoin = PlayerPrefs.GetInt("RotationCoin");
        if (RotationCoin == 0)
            {
                RotationCoinText.text = "Rotation: ON";
            }
        else if (RotationCoin  == 1)
            {
                RotationCoinText.text = "Rotation: OFF";
            }
    }
    public void RotationCoinInc()
    {
        RotationCoin = PlayerPrefs.GetInt("RotationCoin");
        if (RotationCoin == 0)
        {
            RotationCoin++;
            RotationCoinText.text = "Rotation: OFF";
            PlayerPrefs.SetInt("RotationCoin", RotationCoin);
        }
        else if (RotationCoin  == 1)
        {
            RotationCoin--;
            RotationCoinText.text = "Rotation: ON";
            PlayerPrefs.SetInt("RotationCoin", RotationCoin);
        }
    }
}
