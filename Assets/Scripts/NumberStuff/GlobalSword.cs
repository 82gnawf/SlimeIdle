using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GlobalSword : MonoBehaviour
{
    public static double SwordDamage;
    public static double SwordRate;
    public static double SwordCrit;
    public static double SwordCritRate;

    public static double DamageCost;
    public static double RateCost;
    public static double CritCost;
    public static double CritRateCost;

    public static int DisplayDamage;
    public static int DisplayRate;
    public static int DisplayCrit;
    public static int DisplayCritRate;

    public static int SwordDamageLevel = 1;
    public static int SwordRateLevel = 1;
    public static int SwordCritLevel = 1;
    public static int SwordCritRateLevel = 1;

    public GameObject fakeDamageButton;
    public GameObject realDamageButton;
    public GameObject fakeDamageText;
    public GameObject realDamageText;
    public GameObject DamageStat;

    public GameObject fakeRateButton;
    public GameObject realRateButton;
    public GameObject fakeRateText;
    public GameObject realRateText;
    public GameObject RateStat;

    public GameObject fakeCritButton;
    public GameObject realCritButton;
    public GameObject fakeCritText;
    public GameObject realCritText;
    public GameObject CritStat;

    public GameObject fakeCritRateButton;
    public GameObject realCritRateButton;
    public GameObject fakeCritRateText;
    public GameObject realCritRateText;
    public GameObject CritRateStat;

    public int currentMoney;

    private void Update() {

        SwordDamage = 4 + SwordDamageLevel; //sword damage increase by 1 per upgrade
        SwordRate = 100 + ((SwordRateLevel - 1) * 10); //sword rate increases by 10% per upgrade
        SwordCrit = (SwordCritLevel + 1) * SwordDamage; //crit dmg increase by 100% of the dmg per upgrade
        SwordCritRate = SwordCritRateLevel; //crit rate increases by 1% per upgrade

        DamageCost = 10 * Math.Pow(1.2, SwordDamageLevel - 1);
        RateCost = 100 * Math.Pow(1.2, SwordRateLevel - 1);
        CritCost = 200 * Math.Pow(1.2, SwordCritLevel - 1);
        CritRateCost = 500 * Math.Pow(1.2, SwordCritRateLevel - 1);

        DisplayDamage = Convert.ToInt32(DamageCost);
        DisplayRate = Convert.ToInt32(RateCost);
        DisplayCrit = Convert.ToInt32(CritCost);
        DisplayCritRate = Convert.ToInt32(CritRateCost);

        fakeDamageText.GetComponent<Text>().text = "Upgrade DMG: $" + DisplayDamage;
        realDamageText.GetComponent<Text>().text = "Upgrade DMG: $" + DisplayDamage;
        DamageStat.GetComponent<Text>().text = "DMG: " + SwordDamage;

        fakeRateText.GetComponent<Text>().text = "Upgrade Hit Rate: $" + DisplayRate;
        realRateText.GetComponent<Text>().text = "Upgrade Hit Rate: $" + DisplayRate;
        RateStat.GetComponent<Text>().text = "Hit Rate: " + SwordRate;

        fakeCritText.GetComponent<Text>().text = "Upgrade Crit. DMG: $" + DisplayCrit;
        realCritText.GetComponent<Text>().text = "Upgrade Crit. DMG: $" + DisplayCrit;
        CritStat.GetComponent<Text>().text = "Crit. DMG: " + SwordCrit;

        fakeCritRateText.GetComponent<Text>().text = "Upgrade Crit. Rate: $" + DisplayCritRate;
        realCritRateText.GetComponent<Text>().text = "Upgrade Crit. Rate: $" + DisplayCritRate;
        CritRateStat.GetComponent<Text>().text = "Crit. Rate: " + SwordCritRate;

        currentMoney = GlobalMoney.MoneyCount;

        if (currentMoney >= DamageCost) {
            fakeDamageButton.SetActive(false); //deactivate fake
            realDamageButton.SetActive(true);  //activate real
        }
        else {
            realDamageButton.SetActive(false); //deactivate real
            fakeDamageButton.SetActive(true);  //activate fake
        }

        if (currentMoney >= RateCost) {
            fakeRateButton.SetActive(false); //deactivate fake
            realRateButton.SetActive(true);  //activate real
        }
        else {
            realRateButton.SetActive(false); //deactivate real
            fakeRateButton.SetActive(true);  //activate fake
        }

        if (currentMoney >= CritCost) {
            fakeCritButton.SetActive(false); //deactivate fake
            realCritButton.SetActive(true);  //activate real
        }
        else {
            realCritButton.SetActive(false); //deactivate real
            fakeCritButton.SetActive(true);  //activate fake
        }

        if (currentMoney >= CritRateCost) {
            fakeCritRateButton.SetActive(false); //deactivate fake
            realCritRateButton.SetActive(true);  //activate real
        }
        else {
            realCritRateButton.SetActive(false); //deactivate real
            fakeCritRateButton.SetActive(true);  //activate fake
        }

    }
}
