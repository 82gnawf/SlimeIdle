using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMoney : MonoBehaviour
{
    public GameObject MoneyDisplay;

    public static int MoneyCount;
    public int InternalMoneyCount;

    public GameObject greenPrice;
    public GameObject bluePrice;
    public GameObject redPrice;
    public GameObject yellowPrice;
    public GameObject orangePrice;
    public GameObject purplePrice;
    public GameObject whitePrice;
    public GameObject blackPrice;

    public static int greenWorth = 2;
    public static int blueWorth = 4;
    public static int redWorth = 6;
    public static int yellowWorth = 8;
    public static int orangeWorth = 10;
    public static int purpleWorth = 12;
    public static int whiteWorth = 20;
    public static int blackWorth = 50;

    public int intGreenWorth;
    public int intBlueWorth;
    public int intRedWorth;
    public int intYellowWorth;
    public int intOrangeWorth;
    public int intPurpleWorth;
    public int intWhiteWorth;
    public int intBlackWorth;

    public static int MoneyForPrestige;

    private void Update() {
        InternalMoneyCount = MoneyCount;
        MoneyDisplay.GetComponent<Text>().text = "Money: $" + InternalMoneyCount; //display

        intGreenWorth = greenWorth;
        greenPrice.GetComponent<Text>().text = "Value: $" + intGreenWorth;

        intBlueWorth = blueWorth;
        bluePrice.GetComponent<Text>().text = "Value: $" + intBlueWorth;

        intRedWorth = redWorth;
        redPrice.GetComponent<Text>().text = "Value: $" + intRedWorth;

        intYellowWorth = yellowWorth;
        yellowPrice.GetComponent<Text>().text = "Value: $" + intYellowWorth;

        intOrangeWorth = orangeWorth;
        orangePrice.GetComponent<Text>().text = "Value: $" + intOrangeWorth;

        intPurpleWorth = purpleWorth;
        purplePrice.GetComponent<Text>().text = "Value: $" + intPurpleWorth;

        intWhiteWorth = whiteWorth;
        whitePrice.GetComponent<Text>().text = "Value: $" + intWhiteWorth;

        intBlackWorth = blackWorth;
        blackPrice.GetComponent<Text>().text = "Value: $" + intBlackWorth;
    }
}
