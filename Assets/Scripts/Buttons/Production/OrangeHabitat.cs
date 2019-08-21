using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class OrangeHabitat : MonoBehaviour {
    // Start is called before the first frame update
    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject fakeText;
    public GameObject realText;
    public GameObject OrangeHabStat;

    public int currentMoney;
    public static int unlockValue;
    public static int currentSlime;

    public static int OrangeHabValue; //cost 
    public int displayOrangeHabValue; //god im being trolled

    public static int OrangeHabLevel; //level
    public static int OrangeHabProduced; //slime produced

    public static double OrangeHabPPS;

    void Update() {
        unlockValue = 10000;
        OrangeHabValue = 10;
        OrangeHabProduced = OrangeHabLevel;
        OrangeHabPPS = OrangeHabProduced / 10;
        currentMoney = GlobalMoney.MoneyCount;
        currentSlime = GlobalSlime.orangeSlimeCount;

        if (OrangeHabLevel == 0) {
            OrangeHabStat.GetComponent<Text>().text = "Habitat Locked";
        }
        else {
            OrangeHabStat.GetComponent<Text>().text = "Orange Habitat: " + OrangeHabLevel + " (" + Convert.ToInt32(OrangeHabPPS) + " PPS)";
        }

        displayOrangeHabValue = Convert.ToInt32(OrangeHabValue);

        if (OrangeHabLevel == 0) { //lvl statements
            fakeText.GetComponent<Text>().text = "Unlock Habitat - $" + unlockValue; //button display
            realText.GetComponent<Text>().text = "Unlock Habitat - $" + unlockValue;
        }
        else {
            fakeText.GetComponent<Text>().text = "Produce Slime: \n" + displayOrangeHabValue + " Orange Slimes";
            realText.GetComponent<Text>().text = "Produce Slime: \n" + displayOrangeHabValue + " Orange Slimes";
        }

        if (OrangeHabLevel < 1) {
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
            if (currentSlime >= OrangeHabValue) {
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





