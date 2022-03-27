using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetType2 : MonoBehaviour
{
    public int SetType;
    void Start()
    {
        PlayerPrefs.SetInt("SetType", 2);
    }
}
