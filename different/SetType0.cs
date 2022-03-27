using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetType0 : MonoBehaviour
{
    public int SetType;
    void Start()
    {
        PlayerPrefs.SetInt("SetType", 0);
    }
}
