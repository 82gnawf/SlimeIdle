using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMoney : MonoBehaviour
{
    public GameObject MoneyDisplay;

    public static int MoneyCount;
    public int InternalMoneyCount;

    private void Update() {
        InternalMoneyCount = MoneyCount;
        MoneyDisplay.GetComponent<Text>().text = "Money: " + InternalMoneyCount; //display
    }
}
