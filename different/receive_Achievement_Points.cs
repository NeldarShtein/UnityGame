using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class receive_Achievement_Points : MonoBehaviour
{
    
    public int[] Star_was_Received = new int [25];
    public int AchNumb;
    public int Star;
    public GameObject AchiveOBJ2;

    public void Star_was_ReceivedF(){
        Star = PlayerPrefs.GetInt("Star");
        if (AchNumb>=21)
            {
                Star=Star+90;
                PlayerPrefs.SetInt("Star", Star);
                PlayerPrefs.SetInt("Star_was_Received"+AchNumb, 1);
                AchiveOBJ2.SetActive(false);
            }
        else if (AchNumb>=17)
            {
                Star=Star+50;
                PlayerPrefs.SetInt("Star", Star);
                PlayerPrefs.SetInt("Star_was_Received"+AchNumb, 1);
                AchiveOBJ2.SetActive(false);
            }
        else if (AchNumb>=15)
            {
                Star=Star+20;
                PlayerPrefs.SetInt("Star", Star);
                PlayerPrefs.SetInt("Star_was_Received"+AchNumb, 1);
                AchiveOBJ2.SetActive(false);
            }
        else if (AchNumb>=0)
            {
                Star++;
                PlayerPrefs.SetInt("Star", Star);
                PlayerPrefs.SetInt("Star_was_Received"+AchNumb, 1);
                AchiveOBJ2.SetActive(false);
            }
    }

}
