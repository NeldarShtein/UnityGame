using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinRotation : MonoBehaviour
{
    public float speed = 5f;
    private Transform _rotator;

    private void Start(){
        
        Time.timeScale = 1f;
        _rotator = GetComponent<Transform>();
    }

    private void Update(){
        _rotator.Rotate(0, speed * Time.deltaTime, 0);
    }
}
