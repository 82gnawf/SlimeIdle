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

    //blue
    public void BlueButtonClick1() {
        if (GlobalSlime.blueSlimeCount > 0) {
            GlobalSlime.blueSlimeCount -= 1; //reduces slime amount
            GlobalMoney.MoneyCount += GlobalMoney.blueWorth; //get money per slime sold
            GlobalMoney.MoneyForPrestige += 2;
        }
    }
    public void BlueButtonClick10() {
        if (GlobalSlime.blueSlimeCount >= 10) {
            GlobalSlime.blueSlimeCount -= 10;
            GlobalMoney.MoneyCount += GlobalMoney.blueWorth * 10;
            GlobalMoney.MoneyForPrestige += 2;
        }
    }
    public void BlueButtonClick100() {
        if (GlobalSlime.blueSlimeCount >= 100) {
            GlobalSlime.blueSlimeCount -= 100;
            GlobalMoney.MoneyCount += GlobalMoney.blueWorth * 100;
            GlobalMoney.MoneyForPrestige += 2;
        }
    }
    public void BlueButtonClickMax() {
        tempSlime = GlobalSlime.blueSlimeCount;
        GlobalSlime.blueSlimeCount = 0;
        GlobalMoney.MoneyCount += GlobalMoney.blueWorth * tempSlime;
        GlobalMoney.MoneyForPrestige += 2;
    }

    //red
    public void RedButtonClick1() {
        if (GlobalSlime.redSlimeCount > 0) {
            GlobalSlime.redSlimeCount -= 1; //reduces slime amount
            GlobalMoney.MoneyCount += GlobalMoney.redWorth; //get money per slime sold
            GlobalMoney.MoneyForPrestige += 2;
        }
    }
    public void RedButtonClick10() {
        if (GlobalSlime.redSlimeCount >= 10) {
            GlobalSlime.redSlimeCount -= 10;
            GlobalMoney.MoneyCount += GlobalMoney.redWorth * 10;
            GlobalMoney.MoneyForPrestige += 2;
        }
    }
    public void RedButtonClick100() {
        if (GlobalSlime.redSlimeCount >= 100) {
            GlobalSlime.redSlimeCount -= 100;
            GlobalMoney.MoneyCount += GlobalMoney.redWorth * 100;
            GlobalMoney.MoneyForPrestige += 2;
        }
    }
    public void RedButtonClickMax() {
        tempSlime = GlobalSlime.redSlimeCount;
        GlobalSlime.redSlimeCount = 0;
        GlobalMoney.MoneyCount += GlobalMoney.redWorth * tempSlime;
        GlobalMoney.MoneyForPrestige += 2;
    }

}
