using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chank1 : MonoBehaviour
{
    public int x;
    public GameObject obj;
    private void OnTriggerEnter(Collider collision){
        if (collision.gameObject.tag == "Player")
        {
            x++;
            if (x==5)
            {
                obj.GetComponent <Renderer> ().material.color= Color.green;
            }
            else if (x==8)
            {
                obj.GetComponent <Renderer> ().material.color= Color.red;
            }
            else if (x==10)
            {
                Destroy(obj);
            }
        }
    }
}
