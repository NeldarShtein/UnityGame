using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeRelict : MonoBehaviour
{
    public int x;
    private void OnTriggerEnter(Collider other){
        x = UnityEngine.Random.Range(1, 60);
        if (x<=10)
        {
            Time.timeScale = 0.5f;
        }
        else if (x<=20)
        {
            Time.timeScale = 1f;
        }
        else if (x<=30)
        {
            Time.timeScale = 1.5f;
        }
        else if (x<=40)
        {
            Time.timeScale = 2f;
        }
        else if (x<=70)
        {
            Time.timeScale = 10f;
        }
    }

}
