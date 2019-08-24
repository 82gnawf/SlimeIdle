using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class GlobalWarrior : MonoBehaviour {


    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject fakeText;
    public GameObject realText;
    public GameObject WarriorStat;

    public int currentMoney;
    public static double WarriorValue; //cost
    public int displayWarriorValue; //god im being trolled
    public static int WarriorLevel; //level

    public static double WarriorDamage; //damage dealt
    public static float DamageRate;
    public static double CritDamage;
    public static float CritRate;

    public static float HitRate;

    public static double WarriorDPS;

    void Update() {
        WarriorValue = 100 * Math.Pow(1.5, WarriorLevel);
        WarriorDamage = 10 * Math.Pow(1.5, WarriorLevel - 1);
        DamageRate = 100;
        CritDamage = WarriorDamage*2;
        CritRate = 0;
        HitRate = 0.8f;
        WarriorDPS = WarriorDamage/HitRate;
        currentMoney = GlobalMoney.MoneyCount;

        if (WarriorLevel == 0) {
            WarriorStat.GetComponent<Text>().text = "Warrior Lvl.0";
        }
        else {
            WarriorStat.GetComponent<Text>().text = "Lvl." + WarriorLevel + " (" + Convert.ToInt32(WarriorDPS) + " DPS)";
        }

        displayWarriorValue = Convert.ToInt32(WarriorValue);

        if (WarriorLevel == 0) { //lvl statements
            fakeText.GetComponent<Text>().text = "Hire Warrior - $" + displayWarriorValue; //button display
            realText.GetComponent<Text>().text = "Hire Warrior - $" + displayWarriorValue;
        }
        else {
            fakeText.GetComponent<Text>().text = "Upgrade Warrior - $" + displayWarriorValue;
            realText.GetComponent<Text>().text = "Upgrade Warrior - $" + displayWarriorValue;
        }

        if (currentMoney >= WarriorValue) {
            fakeButton.SetActive(false); //deactivate fake
            realButton.SetActive(true);  //activate real
        }
        else {
            realButton.SetActive(false); //deactivate real
            fakeButton.SetActive(true);  //activate fake
        }

     
    }
}



