using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class GlobalKnight : MonoBehaviour {


    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject fakeText;
    public GameObject realText;
    public GameObject KnightStat;

    public int currentMoney;
    public static double KnightValue; //cost
    public int displayKnightValue; //god im being trolled
    public static int KnightLevel; //level

    public static double KnightDamage; //damage dealt
    public static float DamageRate;
    public static double CritDamage;
    public static float CritRate;

    public static float HitRate;

    public static double KnightDPS;

    void Update() {
        KnightValue = 200 * Math.Pow(1.5, KnightLevel);
        KnightDamage = 30 * Math.Pow(1.5, KnightLevel - 1);
        DamageRate = 100;
        CritDamage = KnightDamage * 2;
        CritRate = 0;
        HitRate = 1.5f;
        KnightDPS = KnightDamage/HitRate;
        currentMoney = GlobalMoney.MoneyCount;

        if (KnightLevel == 0) {
            KnightStat.GetComponent<Text>().text = "Knight Lvl.0";
        }
        else {
            KnightStat.GetComponent<Text>().text = "Knight Lvl." + KnightLevel + " (" + Convert.ToInt32(KnightDPS) + " DPS)";
        }

        displayKnightValue = Convert.ToInt32(KnightValue);

        if (KnightLevel == 0) { //lvl statements
            fakeText.GetComponent<Text>().text = "Hire Knight - $" + displayKnightValue; //button display
            realText.GetComponent<Text>().text = "Hire Knight - $" + displayKnightValue;
        }
        else {
            fakeText.GetComponent<Text>().text = "Upgrade Knight - $" + displayKnightValue;
            realText.GetComponent<Text>().text = "Upgrade Knight - $" + displayKnightValue;
        }

        if (currentMoney >= KnightValue) {
            fakeButton.SetActive(false); //deactivate fake
            realButton.SetActive(true);  //activate real
        }
        else {
            realButton.SetActive(false); //deactivate real
            fakeButton.SetActive(true);  //activate fake
        }


    }
}
