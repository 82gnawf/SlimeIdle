using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMoney : MonoBehaviour
{
    public GameObject MoneyDisplay;

    public static int MoneyCount;
    public int InternalMoneyCount;

    public static int greenWorth = 2;
    public static int blueWorth = 4;
    public static int redWorth = 5;

    public static int MoneyForPrestige;

    private void Update() {
        InternalMoneyCount = MoneyCount;
        MoneyDisplay.GetComponent<Text>().text = "Money: $" + InternalMoneyCount; //display
    }
}
