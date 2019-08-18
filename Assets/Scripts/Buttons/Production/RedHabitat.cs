using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class RedHabitat : MonoBehaviour {
    // Start is called before the first frame update
    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject fakeText;
    public GameObject realText;
    public GameObject RedHabStat;

    public int currentMoney;
    public static int unlockValue;
    public static int currentSlime;

    public static int RedHabValue; //cost 
    public int displayRedHabValue; //god im being trolled

    public static int RedHabLevel; //level
    public static int RedHabProduced; //slime produced

    public static double RedHabPPS;

    void Update() {
        unlockValue = 10000;
        RedHabValue = 10;
        RedHabProduced = RedHabLevel;
        RedHabPPS = RedHabProduced / 10;
        currentMoney = GlobalMoney.MoneyCount;
        currentSlime = GlobalSlime.redSlimeCount;

        if (RedHabLevel == 0) {
            RedHabStat.GetComponent<Text>().text = "Habitat Locked";
        }
        else {
            RedHabStat.GetComponent<Text>().text = "Red Habitat: " + RedHabLevel + " (" + Convert.ToInt32(RedHabPPS) + " PPS)";
        }

        displayRedHabValue = Convert.ToInt32(RedHabValue);

        if (RedHabLevel == 0) { //lvl statements
            fakeText.GetComponent<Text>().text = "Unlock Habitat - $" + unlockValue; //button display
            realText.GetComponent<Text>().text = "Unlock Habitat - $" + unlockValue;
        }
        else {
            fakeText.GetComponent<Text>().text = "Produce Slime - " + displayRedHabValue + "Red Slimes";
            realText.GetComponent<Text>().text = "Produce Slime - " + displayRedHabValue + "Red Slimes";
        }

        if (RedHabLevel < 1) {
            if (currentMoney >= unlockValue) {
                fakeButton.SetActive(false); //deactivate fake
                realButton.SetActive(true);  //activate real
            }
            else {
                realButton.SetActive(false); //deactivate real
                fakeButton.SetActive(true);  //activate fake
            }
        }
        else {
            if (currentSlime >= RedHabValue) {
                fakeButton.SetActive(false); //deactivate fake
                realButton.SetActive(true);  //activate real
            }
            else {
                realButton.SetActive(false); //deactivate real
                fakeButton.SetActive(true);  //activate fake
            }
        }



    }
}





