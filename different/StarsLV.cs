using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StarsLV : MonoBehaviour
{
    public int Star;
    public GameObject [] AchiveOBJ2;
    public GameObject [] AchiveOBJ3;
    

    void Start()
    {
        Star = PlayerPrefs.GetInt("Star");
        if (Star>=10)
        {
            AchiveOBJ3[0].SetActive(true);
            AchiveOBJ2[0].SetActive(false);
        }
        else if (Star<=9)
        {
            AchiveOBJ3[0].SetActive(false);
            AchiveOBJ2[0].SetActive(true);
        }
        if (Star>=15)
        {
            AchiveOBJ3[1].SetActive(true);
            AchiveOBJ2[1].SetActive(false);
        }
        else if (Star<=14)
        {
            AchiveOBJ3[1].SetActive(false);
            AchiveOBJ2[1].SetActive(true);
        }
    }
}
