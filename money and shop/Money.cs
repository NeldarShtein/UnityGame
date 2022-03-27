using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public int RotationCoin;
    public GameObject MoneyCoin;
    
    public int MoneyPerLevel;

    private void OnTriggerEnter(Collider other){
        MoneyPerLevel = PlayerPrefs.GetInt("MoneyPerLevel");
        MoneyPerLevel++;
        PlayerPrefs.SetInt("MoneyPerLevel", MoneyPerLevel);
        MoneyCoin.SetActive(false);
    }

    void Start()
    {
        RotationCoin = PlayerPrefs.GetInt("RotationCoin");
        MoneyPerLevel = PlayerPrefs.GetInt("MoneyPerLevel");
    }

    void FixedUpdate()
    {
        if (RotationCoin==0)
        {
            transform.Rotate(new Vector3(0,0,45)*Time.deltaTime);
        }
    }
}
