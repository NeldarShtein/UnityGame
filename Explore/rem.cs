using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rem : MonoBehaviour
{
    public GameObject obj;
    private void OnTriggerEnter(Collider collision){
        Destroy(obj);
    }
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0,45,0)*Time.deltaTime);
    }
}
