using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellButton : MonoBehaviour {

    public int tempSlime;
    GameObject SlimePanelType;

	public void ButtonClick1 () {
        if (GlobalSlime.SlimeCount > 0) {
            GlobalSlime.SlimeCount -= 1; //reduces slime amount
            SlimePanelType = gameObject.GetComponentInParent<GameObject>();
            GlobalMoney.MoneyCount += GlobalMoney.greenWorth; //get money per slime sold
            GlobalMoney.MoneyForPrestige += 2;
        }
    }

    public void ButtonClick10() {
        if (GlobalSlime.SlimeCount >= 10) {
            GlobalSlime.SlimeCount -= 10; 
            GlobalMoney.MoneyCount += GlobalMoney.greenWorth * 10; 
            GlobalMoney.MoneyForPrestige += 2;
        }
    }

    public void ButtonClick100() {
        if (GlobalSlime.SlimeCount >= 100) {
            GlobalSlime.SlimeCount -= 100; 
            GlobalMoney.MoneyCount += GlobalMoney.greenWorth * 100;
            GlobalMoney.MoneyForPrestige += 2;
        }
    }

    public void ButtonClickMax() {
        tempSlime = GlobalSlime.SlimeCount;
        GlobalSlime.SlimeCount = 0; 
        GlobalMoney.MoneyCount += GlobalMoney.greenWorth * tempSlime;
        GlobalMoney.MoneyForPrestige += 2;
    }
}
