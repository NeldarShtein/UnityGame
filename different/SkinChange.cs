using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinChange : MonoBehaviour

{
    [SerializeField] int SkinN;
    [SerializeField] int skinNChange;
    public Text SkinNText;

    public GameObject [] SkinOBJ;
    public GameObject NTB;

    [SerializeField] bool s1;
    [SerializeField] bool s2;
    [SerializeField] bool s3;
    [SerializeField] bool s4;
    [SerializeField] bool s5;
    [SerializeField] bool s6;
    [SerializeField] bool s7;
    [SerializeField] bool s8;
    [SerializeField] bool s9;
    [SerializeField] bool s10;

    private void Start()
    {
        SkinN = PlayerPrefs.GetInt("SkinN");
        skinNChange = PlayerPrefs.GetInt("skinNChange");
        Time.timeScale = 1f;

        s1 = PlayerPrefs.GetInt("s1") == 1 ? true:false;
        s2 = PlayerPrefs.GetInt("s2") == 1 ? true:false;
        s3 = PlayerPrefs.GetInt("s3") == 1 ? true:false;
        s4 = PlayerPrefs.GetInt("s4") == 1 ? true:false;
        s5 = PlayerPrefs.GetInt("s5") == 1 ? true:false;
        s6 = PlayerPrefs.GetInt("s6") == 1 ? true:false;
        s7 = PlayerPrefs.GetInt("s7") == 1 ? true:false;
        s8 = PlayerPrefs.GetInt("s8") == 1 ? true:false;
        s9 = PlayerPrefs.GetInt("s9") == 1 ? true:false;
        s10 = PlayerPrefs.GetInt("s10") == 1 ? true:false;
        
        SkinOBJ[SkinN].SetActive(true);
        NTB.SetActive(true);
        Check();
        UpdSN();
    }

    
    void Check(){
        if (SkinN == 1 && s1)
            {
              NTB.SetActive(false);
            }
        else if (SkinN == 2 && s2)
            {
              NTB.SetActive(false);
            }
        else if (SkinN == 3 && s3)
            {
              NTB.SetActive(false);
            }
        else if (SkinN == 4 && s4)
            {
              NTB.SetActive(false);
            }
        else if (SkinN == 5 && s5)
            {
              NTB.SetActive(false);
            }
        else if (SkinN == 6 && s6)
            {
              NTB.SetActive(false);
            }
        else if (SkinN == 7 && s7)
           {
              NTB.SetActive(false);
            }
        else if (SkinN == 8 && s8)
            {
              NTB.SetActive(false);
            }
        else if (SkinN == 9 && s9)
            {
              NTB.SetActive(false);
            }
        else if (SkinN == 10 && s10)
            {
              NTB.SetActive(false);
            }
        else
            {
              NTB.SetActive(true);
            }
            
        UpdSN();
    }

    public void ChangeSkin(){
        if (SkinN == 1 && s1)
            {
              skinNChange = 1;
              PlayerPrefs.SetInt("skinNChange", skinNChange);
            }
        else if (SkinN == 2 && s2)
            {
              skinNChange = 2;
              PlayerPrefs.SetInt("skinNChange", skinNChange);
            }
        else if (SkinN == 3 && s3)
            {
              skinNChange = 3;
              PlayerPrefs.SetInt("skinNChange", skinNChange);
            }
        else if (SkinN == 4 && s4)
            {
              skinNChange = 4;
              PlayerPrefs.SetInt("skinNChange", skinNChange);
            }
        else if (SkinN == 5 && s5)
            {
              skinNChange = 5;
              PlayerPrefs.SetInt("skinNChange", skinNChange);
            }
        else if (SkinN == 6 && s6)
            {
              skinNChange = 6;
              PlayerPrefs.SetInt("skinNChange", skinNChange);
            }
        else if (SkinN == 7 && s7)
            {
              skinNChange = 7;
              PlayerPrefs.SetInt("skinNChange", skinNChange);
            }
        else if (SkinN == 8 && s8)
            {
              skinNChange = 8;
              PlayerPrefs.SetInt("skinNChange", skinNChange);
            }
        else if (SkinN == 9 && s9)
            {
              skinNChange = 9;
              PlayerPrefs.SetInt("skinNChange", skinNChange);
            }
        else if (SkinN == 10 && s10)
            {
              skinNChange = 10;
              PlayerPrefs.SetInt("skinNChange", skinNChange);
            }
            
        UpdSN();
    }


    public void SkinNEXT()
    {
        SkinN++;
        if (SkinN == 11)
        {
            SkinN = 10;
            SkinNText.text = "SKIN " + SkinN;
        }
        
        if (SkinN == 0)
        {
            SkinN = 1;
            SkinNText.text = "SKIN " + SkinN;
        }

        for (int i = 0; i < 11; i++)
        {
            SkinOBJ[i].SetActive(false);
        }
        SkinOBJ[SkinN].SetActive(true);
        Check();
        UpdSN();
    }
    public void SkinPREVIOUS()
    {
        SkinN = SkinN-1;
        if (SkinN == 11)
        {
            SkinN = 10;
            SkinNText.text = "SKIN " + SkinN;
        }
        
        if (SkinN == 0)
        {
            SkinN = 1;
            SkinNText.text = "SKIN " + SkinN;
        }

        for (int i = 0; i < 11; i++)
        {
            SkinOBJ[i].SetActive(false);
        }
        SkinOBJ[SkinN].SetActive(true);
        Check();
        UpdSN();
    }
    void UpdSN()
    {
        SkinNText.text = "SKIN " + SkinN;
        PlayerPrefs.SetInt("SkinN", SkinN);
    }
}
