using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stats : MonoBehaviour

{
    public int Level;
    public int SpeedLV;
    public int DistanceLV;
    public int JumpLV;
    public Text LevelText;
    public Text SpeedLVText;
    public Text DistanceLVText;
    public Text JumpLVText;
    public Text pointsText;
    public int points;
    public int TotMonAm;

    private void Start()
    {
        points = PlayerPrefs.GetInt("points");
        TotMonAm = PlayerPrefs.GetInt("TotMonAm");
        Level = PlayerPrefs.GetInt("Level");
        SpeedLV = PlayerPrefs.GetInt("SpeedLV");
        DistanceLV = PlayerPrefs.GetInt("DistanceLV");
        JumpLV = PlayerPrefs.GetInt("JumpLV");
        TextUpd();
    }
    
    void SetStats()
    {
        PlayerPrefs.SetInt("points", points);
        PlayerPrefs.SetInt("TotMonAm", TotMonAm);
        PlayerPrefs.SetInt("Level", Level);
        PlayerPrefs.SetInt("SpeedLV", SpeedLV);
        PlayerPrefs.SetInt("DistanceLV", DistanceLV);
        PlayerPrefs.SetInt("JumpLV", JumpLV);
    }

    public void PointsInc()
    {
        Level++;
        points++;    
        SetStats(); 
        TextUpd();    
    }

    public void SpeedInc()
    {
        if (points>=1)
        {
            SpeedLV++;
            points = points-1;
            SetStats();
            TextUpd();
        }
    }
        public void SpeedInc5()
    {
        if (points>=5)
        {
            SpeedLV=SpeedLV+5;
            points = points-5;
            SetStats();
            TextUpd();
        }
    }
        public void SpeedInc10()
    {
        if (points>=10)
        {
            SpeedLV=SpeedLV+10;
            points = points-10;
            SetStats();
            TextUpd();
        }
    }

    public void DistanceInc()
    {
        if (points>=1)
        {
            DistanceLV++;
            points = points-1;
            SetStats();
            TextUpd();
        }
    }
    public void DistanceInc5()
    {
        if (points>=5)
        {
            DistanceLV=DistanceLV+5;
            points = points-5;
            SetStats();
            TextUpd();
        }
    }
    public void DistanceInc10()
    {
        if (points>=10)
        {
            DistanceLV=DistanceLV+10;
            points = points-10;
            SetStats();
            TextUpd();
        }
    }
    public void JumpInc()
    {
        if (points>=1)
        {
            JumpLV++;
            points = points-1;
            SetStats();
            TextUpd();
        }
    }
    public void JumpInc5()
    {
        if (points>=5)
        {
            JumpLV=JumpLV+5;
            points = points-5;
            SetStats();
            TextUpd();
        }
    }
    public void JumpInc10()
    {
        if (points>=10)
        {
            JumpLV=JumpLV+10;
            points = points-10;
            SetStats();
            TextUpd();
        }
    }

    public void Reset_ALL()
    {
        points = points + SpeedLV + DistanceLV + JumpLV - 3;
        SpeedLV = 1;
        DistanceLV = 1;
        JumpLV = 1;
        SetStats();
        TextUpd();
    }

    public void DeletePoints()
    {
        Level = 1;
        points = 0;
        SpeedLV = 1;
        DistanceLV = 1;
        JumpLV = 1;
        SetStats();
        TextUpd();
    }
    void TextUpd(){
        while (TotMonAm >= Level*Level*2)
        {
            Level++;
            points++;    
            SetStats();
        }
        LevelText.text = "Level " + Level;
        SpeedLVText.text = SpeedLV + "LV";
        DistanceLVText.text = DistanceLV + "LV";
        JumpLVText.text = JumpLV + "LV";
        pointsText.text = "Free points: " + points;
    }
    
}
