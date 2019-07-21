using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellButton : MonoBehaviour {

    public int tempSlime;

    //green
	public void GreenButtonClick1 () {
        if (GlobalSlime.greenSlimeCount > 0) {
            GlobalSlime.greenSlimeCount -= 1; //reduces slime amount
            GlobalMoney.MoneyCount += GlobalMoney.greenWorth; //get money per slime sold
            GlobalMoney.MoneyForPrestige += 2;
        }
    }
    public void GreenButtonClick10() {
        if (GlobalSlime.greenSlimeCount >= 10) {
            GlobalSlime.greenSlimeCount -= 10; 
            GlobalMoney.MoneyCount += GlobalMoney.greenWorth * 10; 
            GlobalMoney.MoneyForPrestige += 2;
        }
    }
    public void GreenButtonClick100() {
        if (GlobalSlime.greenSlimeCount >= 100) {
            GlobalSlime.greenSlimeCount -= 100; 
            GlobalMoney.MoneyCount += GlobalMoney.greenWorth * 100;
            GlobalMoney.MoneyForPrestige += 2;
        }
    }
    public void GreenButtonClickMax() {
        tempSlime = GlobalSlime.greenSlimeCount;
        GlobalSlime.greenSlimeCount = 0; 
        GlobalMoney.MoneyCount += GlobalMoney.greenWorth * tempSlime;
        GlobalMoney.MoneyForPrestige += 2;
    }
}
