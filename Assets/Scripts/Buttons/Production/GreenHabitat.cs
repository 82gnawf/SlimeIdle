using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GreenHabitat : MonoBehaviour {
    // Start is called before the first frame update
    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject fakeText;
    public GameObject realText;
    public GameObject GreenHabStat;

    public int currentMoney;
    public static int unlockValue;
    public static int currentSlime;

    public static int GreenHabValue; //cost 
    public int displayGreenHabValue; //god im being trolled

    public static int GreenHabLevel; //level
    public static int GreenHabProduced; //slime produced

    public static double GreenHabPPS;

    void Update() {
        unlockValue = 10000;
        GreenHabValue = 10;
        GreenHabProduced = GreenHabLevel;
        GreenHabPPS = GreenHabProduced/10;
        currentMoney = GlobalMoney.MoneyCount;
        currentSlime = GlobalSlime.greenSlimeCount;

        if (GreenHabLevel == 0) {
            GreenHabStat.GetComponent<Text>().text = "Habitat Locked";
        }
        else {
            GreenHabStat.GetComponent<Text>().text = "Green Habitat: " + GreenHabLevel + " (" + Convert.ToInt32(GreenHabPPS) + " PPS)";
        }

        displayGreenHabValue = Convert.ToInt32(GreenHabValue);

        if (GreenHabLevel == 0) { //lvl statements
            fakeText.GetComponent<Text>().text = "Unlock Habitat - $" + unlockValue; //button display
            realText.GetComponent<Text>().text = "Unlock Habitat - $" + unlockValue;
        }
        else {
            fakeText.GetComponent<Text>().text = "Produce Slime: \n" + displayGreenHabValue + " Green Slimes";
            realText.GetComponent<Text>().text = "Produce Slime: \n" + displayGreenHabValue + " Green Slimes";
        }

        if (GreenHabLevel < 1) {
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
            if (currentSlime >= GreenHabValue) {
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



