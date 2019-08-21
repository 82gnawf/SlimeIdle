using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BlueHabitat : MonoBehaviour {
    // Start is called before the first frame update
    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject fakeText;
    public GameObject realText;
    public GameObject BlueHabStat;

    public int currentMoney;
    public static int unlockValue;
    public static int currentSlime;

    public static int BlueHabValue; //cost 
    public int displayBlueHabValue; //god im being trolled

    public static int BlueHabLevel; //level
    public static int BlueHabProduced; //slime produced

    public static double BlueHabPPS;

    void Update() {
        unlockValue = 10000;
        BlueHabValue = 10;
        BlueHabProduced = BlueHabLevel;
        BlueHabPPS = BlueHabProduced / 10;
        currentMoney = GlobalMoney.MoneyCount;
        currentSlime = GlobalSlime.blueSlimeCount;

        if (BlueHabLevel == 0) {
            BlueHabStat.GetComponent<Text>().text = "Habitat Locked";
        }
        else {
            BlueHabStat.GetComponent<Text>().text = "Blue Habitat: " + BlueHabLevel + " (" + Convert.ToInt32(BlueHabPPS) + " PPS)";
        }

        displayBlueHabValue = Convert.ToInt32(BlueHabValue);

        if (BlueHabLevel == 0) { //lvl statements
            fakeText.GetComponent<Text>().text = "Unlock Habitat - $" + unlockValue; //button display
            realText.GetComponent<Text>().text = "Unlock Habitat - $" + unlockValue;
        }
        else {
            fakeText.GetComponent<Text>().text = "Produce Slime: \n" + displayBlueHabValue + " Blue Slimes";
            realText.GetComponent<Text>().text = "Produce Slime: \n" + displayBlueHabValue + " Blue Slimes";
        }

        if (BlueHabLevel < 1) {
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
            if (currentSlime >= BlueHabValue) {
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





