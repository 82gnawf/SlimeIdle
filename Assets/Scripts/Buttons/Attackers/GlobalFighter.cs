using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class GlobalFighter : MonoBehaviour {


    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject fakeText;
    public GameObject realText;
    public GameObject FighterStat;

    public int currentMoney;
    public static double FighterValue; //cost 
    public int displayFighterValue; //god im being trolled
    public static int FighterLevel; //level
    public static double FighterDamage; //damage dealt

    public static double FighterDPS;

    void Update () {
        FighterValue = 20 * Math.Pow(1.5, FighterLevel);
        FighterDamage = 4 * Math.Pow(1.5, FighterLevel - 1);
        FighterDPS = FighterDamage;
        currentMoney = GlobalMoney.MoneyCount;

        if (FighterLevel == 0) {
            FighterStat.GetComponent<Text>().text = "Fighter Lvl.0";
        }
        else {
            FighterStat.GetComponent<Text>().text = "Fighter Lvl." + FighterLevel + " (" + Convert.ToInt32(FighterDPS) + " DPS)";
        }

        displayFighterValue = Convert.ToInt32(FighterValue);

        if (FighterLevel == 0) { //lvl statements
            fakeText.GetComponent<Text>().text = "Hire Fighter - $" + displayFighterValue; //button display
            realText.GetComponent<Text>().text = "Hire Fighter - $" + displayFighterValue;
        }
        else {
            fakeText.GetComponent<Text>().text = "Upgrade Fighter - $" + displayFighterValue;
            realText.GetComponent<Text>().text = "Upgrade Fighter - $" + displayFighterValue;
        }

        if (currentMoney >= FighterValue) {
            fakeButton.SetActive(false); //deactivate fake
            realButton.SetActive(true);  //activate real
        }
        else {
            realButton.SetActive(false); //deactivate real
            fakeButton.SetActive(true);  //activate fake
        }

        
	}
}
