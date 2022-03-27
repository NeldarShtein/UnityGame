using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetType1 : MonoBehaviour
{
    public int SetType;
    void Start()
    {
        PlayerPrefs.SetInt("SetType", 1);
    }
}
