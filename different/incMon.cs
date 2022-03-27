using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class incMon : MonoBehaviour
{    
    public Text moneyText;
    public int money;
    public int TotMonAm;

    void Start()
    {
        money = PlayerPrefs.GetInt("money");
        moneyText.text = "Balance: " + money;
    }

    public void MoneyInc()
    {
        money = PlayerPrefs.GetInt("money") + 50;
        PlayerPrefs.SetInt("money", money);
        moneyText.text = "Balance: " + money;
        TotMonAm = PlayerPrefs.GetInt("TotMonAm");
        TotMonAm = TotMonAm + 50;       
        PlayerPrefs.SetInt("TotMonAm", TotMonAm);
    }
}
