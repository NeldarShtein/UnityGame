using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chank2 : MonoBehaviour
{
    public int x;
    private void OnTriggerEnter(Collider collision){
        if (collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0f;
        }
    }
}
