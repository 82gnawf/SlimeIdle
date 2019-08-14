using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class GlobalGreenSeller : MonoBehaviour {


    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject fakeText;
    public GameObject realText;
    public GameObject SellerStat;

    public int currentMoney;
    public static double SellerValue = 20; //cost of seller
    public int displaySellerValue; 
    public static int SellerLevel = 0; //level of seller
    public static int SellerSPS; //sps of seller
    public static int SellerRate = 1; //rate that seller sells at

    void Update () {
        SellerValue = 20 * Math.Pow(10, SellerLevel);
        currentMoney = GlobalMoney.MoneyCount;
        SellerStat.GetComponent<Text>().text = "Seller Lvl." + SellerLevel + " (" + SellerSPS + " SPS)";
        displaySellerValue = Convert.ToInt32(SellerValue);

        if (SellerLevel == 0) { //lvl statements
            fakeText.GetComponent<Text>().text = "Hire Seller - $" + displaySellerValue; //button display
            realText.GetComponent<Text>().text = "Hire Seller - $" + displaySellerValue;
        }
        else {
            fakeText.GetComponent<Text>().text = "Upgrade Seller - $" + displaySellerValue;
            realText.GetComponent<Text>().text = "Upgrade Seller - $" + displaySellerValue;
        }

        if (currentMoney >= SellerValue) {
            fakeButton.SetActive(false); //deactivate fake
            realButton.SetActive(true);  //activate real
        }
        else {
            realButton.SetActive(false); //deactivate real
            fakeButton.SetActive(true);  //activate fake
        }

	}
}
