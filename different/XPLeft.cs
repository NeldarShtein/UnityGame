using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPLeft : MonoBehaviour
{
    public Text XpText;
    public int TotMonAm;
    private int x = 1;
    private int y = 0;

    
    void Start()
    {
        TotMonAm = PlayerPrefs.GetInt("TotMonAm");
        while (y > -5)
            {
                if (TotMonAm >= x*x*2)
                    {
                        y = x*x*2;
                    }
                else if (TotMonAm < x*x*2)
                    {
                        TotMonAm=TotMonAm-y;
                        y = x*x*2-y;
                        XpText.text = TotMonAm + "/" + y;
                        y = -10;
                    }
                x++;
            }
    }
}
