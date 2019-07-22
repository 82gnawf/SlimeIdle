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

    public static int greenWorth = 2;
    public static int blueWorth = 4;
    public static int redWorth = 5;

    public int intGreenWorth;
    public int intBlueWorth;
    public int intRedWorth;

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
    }
}
