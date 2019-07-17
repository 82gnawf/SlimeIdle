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
    public GameObject FigherStat;

    public int currentMoney;
    public static double FighterValue = 20; //cost of fighters
    public int displayFighterValue; //god im being trolled
    public static int FighterLevel; //level of fighter
    public static int FighterDamage = 4; //damage that fighter deals

    public static double FighterDPS;

    public static bool turnOffButton = false;

    void Update () {
        FighterValue = 20 * Math.Pow(1.5, FighterLevel);
        FighterDPS = FighterDamage * Math.Pow(1.5, FighterLevel - 1);
        currentMoney = GlobalMoney.MoneyCount;
        FigherStat.GetComponent<Text>().text = "Fighter Lvl." + FighterLevel + " (" + Convert.ToInt32(FighterDPS) + " DPS)";
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

        if (turnOffButton == true) {
            realButton.SetActive(false); //deactivate real
            fakeButton.SetActive(true);  //activate fake
            turnOffButton = false;
        }
	}
}
