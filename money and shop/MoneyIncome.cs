using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoneyIncome : MonoBehaviour
{
    public int money;
    public Text moneyText;
    public int TotMonAm;

    private void Start()
    {
        money = PlayerPrefs.GetInt("money");
        TotMonAm = PlayerPrefs.GetInt("TotMonAm");
        moneyText.text = money.ToString(); 
    }

    public void MoneyInc()
    {
        money++;
        TotMonAm = TotMonAm + money;
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("TotMonAm", TotMonAm);
        moneyText.text = money.ToString();
    }
}
