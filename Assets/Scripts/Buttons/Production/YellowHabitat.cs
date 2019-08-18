using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class YellowHabitat : MonoBehaviour {
    // Start is called before the first frame update
    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject fakeText;
    public GameObject realText;
    public GameObject YellowHabStat;

    public int currentMoney;
    public static int unlockValue;
    public static int currentSlime;

    public static int YellowHabValue; //cost 
    public int displayYellowHabValue; //god im being trolled

    public static int YellowHabLevel; //level
    public static int YellowHabProduced; //slime produced

    public static double YellowHabPPS;

    void Update() {
        unlockValue = 10000;
        YellowHabValue = 10;
        YellowHabProduced = YellowHabLevel;
        YellowHabPPS = YellowHabProduced / 10;
        currentMoney = GlobalMoney.MoneyCount;
        currentSlime = GlobalSlime.yellowSlimeCount;

        if (YellowHabLevel == 0) {
            YellowHabStat.GetComponent<Text>().text = "Habitat Locked";
        }
        else {
            YellowHabStat.GetComponent<Text>().text = "Yellow Habitat: " + YellowHabLevel + " (" + Convert.ToInt32(YellowHabPPS) + " PPS)";
        }

        displayYellowHabValue = Convert.ToInt32(YellowHabValue);

        if (YellowHabLevel == 0) { //lvl statements
            fakeText.GetComponent<Text>().text = "Unlock Habitat - $" + unlockValue; //button display
            realText.GetComponent<Text>().text = "Unlock Habitat - $" + unlockValue;
        }
        else {
            fakeText.GetComponent<Text>().text = "Produce Slime - " + displayYellowHabValue + "Yellow Slimes";
            realText.GetComponent<Text>().text = "Produce Slime - " + displayYellowHabValue + "Yellow Slimes";
        }

        if (YellowHabLevel < 1) {
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
            if (currentSlime >= YellowHabValue) {
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





