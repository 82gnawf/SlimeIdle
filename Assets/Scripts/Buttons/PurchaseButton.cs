using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PurchaseButton : MonoBehaviour {

    public GameObject AutoDamageFighter;
    public GameObject AutoDamageArcher;
    public GameObject AutoDamageWarrior;
    public GameObject AutoSell;

    public void StartAutoDamageFigther() {
        AutoDamageFighter.SetActive(true);
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalFighter.FighterValue);
        GlobalFighter.turnOffButton = true;
        GlobalFighter.FighterLevel += 1;
        GlobalFighter.FighterDamage += 1;
    }

    public void StartAutoDamageArcher() {
        AutoDamageArcher.SetActive(true);
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalArcher.ArcherValue);
        GlobalArcher.turnOffButton = true;
        GlobalArcher.ArcherLevel += 1;
        GlobalArcher.ArcherDamage += 1;
    }

    public void StartAutoDamageWarrior() {
        AutoDamageWarrior.SetActive(true);
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalWarrior.WarriorValue);
        GlobalWarrior.turnOffButton = true;
        GlobalWarrior.WarriorLevel += 1;
        GlobalWarrior.WarriorDamage += 1;
    }

    public void StartAutoSell() {
        AutoSell.SetActive(true);
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalSeller.SellerValue);
        GlobalSeller.turnOffButton = true;
        GlobalSeller.SellerLevel += 1;
        GlobalSeller.SellerSPS += 1;
    }
}
