using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopChange : MonoBehaviour

{
    public int[] figure = new int[10];
    public int[] color_material = new int[10];

    public int g = 0;
    public int h = 0;
    public int ShopN;
    public int ShopN2;

    public int skinNChange=0;
    
    public GameObject [] SkinOBJ;
    public GameObject [] SkinOBJ2;
    public GameObject [] SkinOBJ3;
    public GameObject [] SkinOBJ4;
    public GameObject [] SkinOBJ5;
    public GameObject [] SkinOBJ6;
    public GameObject [] SkinOBJ7;

    public Text ShopNText;
    public Text ShopNText2;

    public Text moneyText;
    public int money;

    private void Start()
    { 
        Time.timeScale = 1f;

        skinNChange = PlayerPrefs.GetInt("skinNChange");

        if (skinNChange == 0)
            {
                ShopN = 0;
                ShopN2 = 0;
            }
        else if (skinNChange == 1)
            {
                ShopN = PlayerPrefs.GetInt("ShopN");
                ShopN2 = PlayerPrefs.GetInt("ShopN2");
            }
        SkinOBJ[ShopN].SetActive(true);
        SkinOBJ2[ShopN2].SetActive(true);
        SkinOBJ3[ShopN].SetActive(true);
        SkinOBJ4[ShopN2].SetActive(true);
        SkinOBJ5[ShopN2].SetActive(true);
        SkinOBJ6[ShopN2].SetActive(true);
        SkinOBJ7[ShopN2].SetActive(true);
        ShopNText.text = "IN USE";
        ShopNText2.text = "IN USE";
        h = ShopN;
        PlayerPrefs.SetInt("h", h);
        g = ShopN2;
        PlayerPrefs.SetInt("g", g);
    }

    public void ShopNEXTC()
        {
            SkinOBJ2[g].SetActive(false);
            SkinOBJ4[g].SetActive(false);
            SkinOBJ5[g].SetActive(false);
            SkinOBJ6[g].SetActive(false);
            SkinOBJ7[g].SetActive(false);
            if (g == 9)
                {
                    PlayerPrefs.SetInt("g", 9);
                }
            else if (g < 9)
                {
                    g++;
                }
            PlayerPrefs.SetInt("g", g);
            color_material[g] = PlayerPrefs.GetInt("color_material"+g);
            SkinOBJ2[g].SetActive(true);
            SkinOBJ4[g].SetActive(true);
            SkinOBJ5[g].SetActive(true);
            SkinOBJ6[g].SetActive(true);
            SkinOBJ7[g].SetActive(true);
            if (color_material[g] == 0)
            {
                ShopNText2.text = "PRICE: " + g*50;
            }
            else if (color_material[g] == 1)
            {
                ShopNText2.text = "IN USE";
            }
            else if (color_material[g] == 2)
            {
                ShopNText2.text = "READY TO USE";
            }
        }
    public void ShopNEXTF()
        {
            SkinOBJ[h].SetActive(false);
            SkinOBJ3[h].SetActive(false);
            if (h == 3)
                {
                    PlayerPrefs.SetInt("h", 3);
                }
            else if (h < 3)
                {
                    h++;
                }
            PlayerPrefs.SetInt("h", h);
            figure[h] = PlayerPrefs.GetInt("figure"+h);
            SkinOBJ[h].SetActive(true);
            SkinOBJ3[h].SetActive(true);
            if (figure[h] == 0)
            {
                ShopNText.text = "PRICE: " + h*500;
            }
            else if (figure[h] == 1)
            {
                ShopNText.text = "IN USE";
            }
            else if (figure[h] == 2)
            {
                ShopNText.text = "READY TO USE";
            }
        }
    public void ShopPREVIOUSC()
        {
            SkinOBJ2[g].SetActive(false);
            SkinOBJ4[g].SetActive(false);
            SkinOBJ5[g].SetActive(false);
            SkinOBJ6[g].SetActive(false);
            SkinOBJ7[g].SetActive(false);
            if (g == 0)
                {
                    PlayerPrefs.SetInt("g", 0);
                }
            else if (g > 0)
                {
                    g--;
                }
            PlayerPrefs.SetInt("g", g);
            color_material[g] = PlayerPrefs.GetInt("color_material"+g);
            SkinOBJ2[g].SetActive(true);
            SkinOBJ4[g].SetActive(true);
            SkinOBJ5[g].SetActive(true);
            SkinOBJ6[g].SetActive(true);
            SkinOBJ7[g].SetActive(true);
            if (color_material[g] == 0)
            {
                ShopNText2.text = "PRICE: " + g*50;
            }
            else if (color_material[g] == 1)
            {
                ShopNText2.text = "IN USE";
            }
            else if (color_material[g] == 2)
            {
                ShopNText2.text = "READY TO USE";
            }
        }
    public void ShopPREVIOUSF()
        {
            SkinOBJ[h].SetActive(false);
            SkinOBJ3[h].SetActive(false);
            if (h == 0)
                {
                    PlayerPrefs.SetInt("h", 0);
                }
            else if (h > 0)
                {
                    h--;
                }
            PlayerPrefs.SetInt("h", h);
            figure[h] = PlayerPrefs.GetInt("figure"+h);
            SkinOBJ[h].SetActive(true);
            SkinOBJ3[h].SetActive(true);
            if (figure[h] == 0)
            {
                ShopNText.text = "PRICE: " + h*500;
            }
            else if (figure[h] == 1)
            {
                ShopNText.text = "IN USE";
            }
            else if (figure[h] == 2)
            {
                ShopNText.text = "READY TO USE";
            }
        }
    public void ShopBuyColor()
    {
        money = PlayerPrefs.GetInt("money");
        if (color_material[g] == 0)
            {
                if (money>=g*50)
                {
                    money = money - g*50;
                    PlayerPrefs.SetInt("money", money);
                    moneyText.text = "Balance: " + money;
                    color_material[g] = 2;
                    PlayerPrefs.SetInt("color_material"+g, 2);
                    ShopNText2.text = "READY TO USE";
                }
            }
        else if (color_material[g] == 2)
        {
            ShopN2 = PlayerPrefs.GetInt("ShopN2");
            PlayerPrefs.SetInt("g", g);
            PlayerPrefs.SetInt("color_material"+ShopN2, 2);
            PlayerPrefs.SetInt("color_material"+g, 1);
            PlayerPrefs.SetInt("ShopN2", g);
            ShopNText2.text = "IN USE";
            PlayerPrefs.SetInt("skinNChange", 1);
            
        }
    }
    public void ShopBuyFig()
    {
        money = PlayerPrefs.GetInt("money");
        if (figure[h] == 0)
            {
                if (money>=h*500)
                {
                    money = money - h*500;
                    PlayerPrefs.SetInt("money", money);
                    moneyText.text = "Balance: " + money;
                    figure[h] = 2;
                    PlayerPrefs.SetInt("figure"+h, 2);
                    ShopNText.text = "READY TO USE";
                }
            }
        else if (figure[h] == 2)
        {
            ShopN = PlayerPrefs.GetInt("ShopN");
            PlayerPrefs.SetInt("h", h);
            PlayerPrefs.SetInt("figure"+ShopN, 2);
            PlayerPrefs.SetInt("figure"+h, 1);
            PlayerPrefs.SetInt("ShopN", h);
            ShopNText.text = "IN USE";
            PlayerPrefs.SetInt("skinNChange", 1);
        }
    }
}