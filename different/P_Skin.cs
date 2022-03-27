using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_Skin : MonoBehaviour
{
    public GameObject [] SkinOBJ_PF;
    public GameObject [] SkinOBJ_Pc1;
    public GameObject [] SkinOBJ_Pc2;
    public GameObject [] SkinOBJ_Pc3;
    public GameObject [] SkinOBJ_Pc4;

    public int ShopN;
    public int ShopN2;

    private void Start()
        {
            ShopN = PlayerPrefs.GetInt("ShopN");//0-3
            ShopN2 = PlayerPrefs.GetInt("ShopN2");//0-9
        
            SkinOBJ_PF[ShopN].SetActive(true);
            if (ShopN==0)
                {
                    SkinOBJ_Pc1[ShopN].SetActive(true);
                }
            else if (ShopN==1)
                {
                    SkinOBJ_Pc2[ShopN2].SetActive(true);
                }
            else if (ShopN==2)
                {
                    SkinOBJ_Pc3[ShopN2].SetActive(true);
                }
            else if (ShopN==3)
                {
                    SkinOBJ_Pc4[ShopN2].SetActive(true);
                }
            Time.timeScale = 1f;
        }
}
