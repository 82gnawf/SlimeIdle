using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PurchaseButton : MonoBehaviour {

    public GameObject AutoDamage;
    public GameObject AutoSell;

    public void StartAutoDamage() {
        AutoDamage.SetActive(true);
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalFighter.FighterValue);
        GlobalFighter.turnOffButton = true;
        GlobalFighter.FighterLevel += 1;
        GlobalFighter.FighterDPS += 1;
    }

    public void StartAutoSell() {
        AutoSell.SetActive(true);
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalSeller.SellerValue);
        GlobalSeller.turnOffButton = true;
        GlobalSeller.SellerLevel += 1;
        GlobalSeller.SellerSPS += 1;
    }
}
