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
            GlobalMoney.MoneyForPrestige += GlobalMoney.greenWorth;
        }
    }
    public void GreenButtonClick10() {
        if (GlobalSlime.greenSlimeCount >= 10) {
            GlobalSlime.greenSlimeCount -= 10; 
            GlobalMoney.MoneyCount += GlobalMoney.greenWorth * 10; 
            GlobalMoney.MoneyForPrestige += GlobalMoney.greenWorth;
        }
    }
    public void GreenButtonClick100() {
        if (GlobalSlime.greenSlimeCount >= 100) {
            GlobalSlime.greenSlimeCount -= 100; 
            GlobalMoney.MoneyCount += GlobalMoney.greenWorth * 100;
            GlobalMoney.MoneyForPrestige += GlobalMoney.greenWorth;
        }
    }
    public void GreenButtonClickMax() {
        tempSlime = GlobalSlime.greenSlimeCount;
        GlobalSlime.greenSlimeCount = 0; 
        GlobalMoney.MoneyCount += GlobalMoney.greenWorth * tempSlime;
        GlobalMoney.MoneyForPrestige += GlobalMoney.greenWorth;
    }

    //blue
    public void BlueButtonClick1() {
        if (GlobalSlime.blueSlimeCount > 0) {
            GlobalSlime.blueSlimeCount -= 1; //reduces slime amount
            GlobalMoney.MoneyCount += GlobalMoney.blueWorth; //get money per slime sold
            GlobalMoney.MoneyForPrestige += GlobalMoney.blueWorth;
        }
    }
    public void BlueButtonClick10() {
        if (GlobalSlime.blueSlimeCount >= 10) {
            GlobalSlime.blueSlimeCount -= 10;
            GlobalMoney.MoneyCount += GlobalMoney.blueWorth * 10;
            GlobalMoney.MoneyForPrestige += GlobalMoney.blueWorth;
        }
    }
    public void BlueButtonClick100() {
        if (GlobalSlime.blueSlimeCount >= 100) {
            GlobalSlime.blueSlimeCount -= 100;
            GlobalMoney.MoneyCount += GlobalMoney.blueWorth * 100;
            GlobalMoney.MoneyForPrestige += GlobalMoney.blueWorth;
        }
    }
    public void BlueButtonClickMax() {
        tempSlime = GlobalSlime.blueSlimeCount;
        GlobalSlime.blueSlimeCount = 0;
        GlobalMoney.MoneyCount += GlobalMoney.blueWorth * tempSlime;
        GlobalMoney.MoneyForPrestige += GlobalMoney.blueWorth;
    }

    //red
    public void RedButtonClick1() {
        if (GlobalSlime.redSlimeCount > 0) {
            GlobalSlime.redSlimeCount -= 1; //reduces slime amount
            GlobalMoney.MoneyCount += GlobalMoney.redWorth; //get money per slime sold
            GlobalMoney.MoneyForPrestige += GlobalMoney.redWorth;
        }
    }
    public void RedButtonClick10() {
        if (GlobalSlime.redSlimeCount >= 10) {
            GlobalSlime.redSlimeCount -= 10;
            GlobalMoney.MoneyCount += GlobalMoney.redWorth * 10;
            GlobalMoney.MoneyForPrestige += GlobalMoney.redWorth;
        }
    }
    public void RedButtonClick100() {
        if (GlobalSlime.redSlimeCount >= 100) {
            GlobalSlime.redSlimeCount -= 100;
            GlobalMoney.MoneyCount += GlobalMoney.redWorth * 100;
            GlobalMoney.MoneyForPrestige += GlobalMoney.redWorth;
        }
    }
    public void RedButtonClickMax() {
        tempSlime = GlobalSlime.redSlimeCount;
        GlobalSlime.redSlimeCount = 0;
        GlobalMoney.MoneyCount += GlobalMoney.redWorth * tempSlime;
        GlobalMoney.MoneyForPrestige += GlobalMoney.redWorth;
    }

    //yellow
    public void YellowButtonClick1() {
        if (GlobalSlime.yellowSlimeCount > 0) {
            GlobalSlime.yellowSlimeCount -= 1; //yellowuces slime amount
            GlobalMoney.MoneyCount += GlobalMoney.yellowWorth; //get money per slime sold
            GlobalMoney.MoneyForPrestige += GlobalMoney.yellowWorth;
        }
    }
    public void YellowButtonClick10() {
        if (GlobalSlime.yellowSlimeCount >= 10) {
            GlobalSlime.yellowSlimeCount -= 10;
            GlobalMoney.MoneyCount += GlobalMoney.yellowWorth * 10;
            GlobalMoney.MoneyForPrestige += GlobalMoney.yellowWorth;
        }
    }
    public void YellowButtonClick100() {
        if (GlobalSlime.yellowSlimeCount >= 100) {
            GlobalSlime.yellowSlimeCount -= 100;
            GlobalMoney.MoneyCount += GlobalMoney.yellowWorth * 100;
            GlobalMoney.MoneyForPrestige += GlobalMoney.yellowWorth;
        }
    }
    public void YellowButtonClickMax() {
        tempSlime = GlobalSlime.yellowSlimeCount;
        GlobalSlime.yellowSlimeCount = 0;
        GlobalMoney.MoneyCount += GlobalMoney.yellowWorth * tempSlime;
        GlobalMoney.MoneyForPrestige += GlobalMoney.yellowWorth;
    }

    //orange
    public void OrangeButtonClick1() {
        if (GlobalSlime.orangeSlimeCount > 0) {
            GlobalSlime.orangeSlimeCount -= 1; //orangeuces slime amount
            GlobalMoney.MoneyCount += GlobalMoney.orangeWorth; //get money per slime sold
            GlobalMoney.MoneyForPrestige += GlobalMoney.orangeWorth;
        }
    }
    public void OrangeButtonClick10() {
        if (GlobalSlime.orangeSlimeCount >= 10) {
            GlobalSlime.orangeSlimeCount -= 10;
            GlobalMoney.MoneyCount += GlobalMoney.orangeWorth * 10;
            GlobalMoney.MoneyForPrestige += GlobalMoney.orangeWorth;
        }
    }
    public void OrangeButtonClick100() {
        if (GlobalSlime.orangeSlimeCount >= 100) {
            GlobalSlime.orangeSlimeCount -= 100;
            GlobalMoney.MoneyCount += GlobalMoney.orangeWorth * 100;
            GlobalMoney.MoneyForPrestige += GlobalMoney.orangeWorth;
        }
    }
    public void OrangeButtonClickMax() {
        tempSlime = GlobalSlime.orangeSlimeCount;
        GlobalSlime.orangeSlimeCount = 0;
        GlobalMoney.MoneyCount += GlobalMoney.orangeWorth * tempSlime;
        GlobalMoney.MoneyForPrestige += GlobalMoney.orangeWorth;
    }

    //purple
    public void PurpleButtonClick1() {
        if (GlobalSlime.purpleSlimeCount > 0) {
            GlobalSlime.purpleSlimeCount -= 1; //purpleuces slime amount
            GlobalMoney.MoneyCount += GlobalMoney.purpleWorth; //get money per slime sold
            GlobalMoney.MoneyForPrestige += GlobalMoney.purpleWorth;
        }
    }
    public void PurpleButtonClick10() {
        if (GlobalSlime.purpleSlimeCount >= 10) {
            GlobalSlime.purpleSlimeCount -= 10;
            GlobalMoney.MoneyCount += GlobalMoney.purpleWorth * 10;
            GlobalMoney.MoneyForPrestige += GlobalMoney.purpleWorth;
        }
    }
    public void PurpleButtonClick100() {
        if (GlobalSlime.purpleSlimeCount >= 100) {
            GlobalSlime.purpleSlimeCount -= 100;
            GlobalMoney.MoneyCount += GlobalMoney.purpleWorth * 100;
            GlobalMoney.MoneyForPrestige += GlobalMoney.purpleWorth;
        }
    }
    public void PurpleButtonClickMax() {
        tempSlime = GlobalSlime.purpleSlimeCount;
        GlobalSlime.purpleSlimeCount = 0;
        GlobalMoney.MoneyCount += GlobalMoney.purpleWorth * tempSlime;
        GlobalMoney.MoneyForPrestige += GlobalMoney.purpleWorth;
    }

    //white
    public void WhiteButtonClick1() {
        if (GlobalSlime.whiteSlimeCount > 0) {
            GlobalSlime.whiteSlimeCount -= 1; //whiteuces slime amount
            GlobalMoney.MoneyCount += GlobalMoney.whiteWorth; //get money per slime sold
            GlobalMoney.MoneyForPrestige += GlobalMoney.whiteWorth;
        }
    }
    public void WhiteButtonClick10() {
        if (GlobalSlime.whiteSlimeCount >= 10) {
            GlobalSlime.whiteSlimeCount -= 10;
            GlobalMoney.MoneyCount += GlobalMoney.whiteWorth * 10;
            GlobalMoney.MoneyForPrestige += GlobalMoney.whiteWorth;
        }
    }
    public void WhiteButtonClick100() {
        if (GlobalSlime.whiteSlimeCount >= 100) {
            GlobalSlime.whiteSlimeCount -= 100;
            GlobalMoney.MoneyCount += GlobalMoney.whiteWorth * 100;
            GlobalMoney.MoneyForPrestige += GlobalMoney.whiteWorth;
        }
    }
    public void WhiteButtonClickMax() {
        tempSlime = GlobalSlime.whiteSlimeCount;
        GlobalSlime.whiteSlimeCount = 0;
        GlobalMoney.MoneyCount += GlobalMoney.whiteWorth * tempSlime;
        GlobalMoney.MoneyForPrestige += GlobalMoney.whiteWorth;
    }

    //black
    public void BlackButtonClick1() {
        if (GlobalSlime.blackSlimeCount > 0) {
            GlobalSlime.blackSlimeCount -= 1; //blackuces slime amount
            GlobalMoney.MoneyCount += GlobalMoney.blackWorth; //get money per slime sold
            GlobalMoney.MoneyForPrestige += GlobalMoney.blackWorth;
        }
    }
    public void BlackButtonClick10() {
        if (GlobalSlime.blackSlimeCount >= 10) {
            GlobalSlime.blackSlimeCount -= 10;
            GlobalMoney.MoneyCount += GlobalMoney.blackWorth * 10;
            GlobalMoney.MoneyForPrestige += GlobalMoney.blackWorth;
        }
    }
    public void BlackButtonClick100() {
        if (GlobalSlime.blackSlimeCount >= 100) {
            GlobalSlime.blackSlimeCount -= 100;
            GlobalMoney.MoneyCount += GlobalMoney.blackWorth * 100;
            GlobalMoney.MoneyForPrestige += GlobalMoney.blackWorth;
        }
    }
    public void BlackButtonClickMax() {
        tempSlime = GlobalSlime.blackSlimeCount;
        GlobalSlime.blackSlimeCount = 0;
        GlobalMoney.MoneyCount += GlobalMoney.blackWorth * tempSlime;
        GlobalMoney.MoneyForPrestige += GlobalMoney.blackWorth;
    }

}
