using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour
{
    
    public int ContinuePrevGame;

    void Start()
    {
        if (ContinuePrevGame==0)
        {
            ContinuePrevGame = PlayerPrefs.GetInt("ContinuePrevGame") + 1;
            PlayerPrefs.SetInt("ContinuePrevGame", ContinuePrevGame);
        }        
    }
}
