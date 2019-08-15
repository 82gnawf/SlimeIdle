using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAssassin : MonoBehaviour {


    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject fakeText;
    public GameObject realText;
    public GameObject AssassinStat;

    public int currentMoney;
    public static double AssassinValue; //cost
    public int displayAssassinValue; //god im being trolled
    public static int AssassinLevel; //level
    public static double AssassinDamage; //damage dealt

    public static double AssassinDPS;

    void Update() {
        AssassinValue = 1000 * Math.Pow(1.5, AssassinLevel);
        AssassinDamage = 50 * Math.Pow(1.5, AssassinLevel - 1);
        AssassinDPS = AssassinDamage;
        currentMoney = GlobalMoney.MoneyCount;

        if (AssassinLevel == 0) {
            AssassinStat.GetComponent<Text>().text = "Assassin Lvl.0";
        }
        else {
            AssassinStat.GetComponent<Text>().text = "Assassin Lvl." + AssassinLevel + " (" + Convert.ToInt32(AssassinDPS) + " DPS)";
        }

        displayAssassinValue = Convert.ToInt32(AssassinValue);

        if (AssassinLevel == 0) { //lvl statements
            fakeText.GetComponent<Text>().text = "Hire Assassin - $" + displayAssassinValue; //button display
            realText.GetComponent<Text>().text = "Hire Assassin - $" + displayAssassinValue;
        }
        else {
            fakeText.GetComponent<Text>().text = "Upgrade Assassin - $" + displayAssassinValue;
            realText.GetComponent<Text>().text = "Upgrade Assassin - $" + displayAssassinValue;
        }

        if (currentMoney >= AssassinValue) {
            fakeButton.SetActive(false); //deactivate fake
            realButton.SetActive(true);  //activate real
        }
        else {
            realButton.SetActive(false); //deactivate real
            fakeButton.SetActive(true);  //activate fake
        }


    }
}
