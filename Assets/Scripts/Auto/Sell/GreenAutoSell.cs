using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class GreenAutoSell : MonoBehaviour {

    public bool GreenSlimeAutoSell = false; //bool for green auto sell
    public int GreenSell;

    void Update() {
        GreenSell = GlobalGreenSeller.SellerLevel * GlobalGreenSeller.SellerRate; //sells at 1 slime per second

        if (GreenSlimeAutoSell == false) {
            GreenSlimeAutoSell = true;
            StartCoroutine(SellGreenSlime()); //starts IEnumerator SellSlime()
        }
    }

    IEnumerator SellGreenSlime() {
        if (GlobalSlime.greenSlimeCount > 0 && GlobalSlime.greenSlimeCount < GreenSell) {
            GlobalMoney.MoneyCount += (GlobalMoney.greenWorth * GlobalSlime.greenSlimeCount);
            GlobalSlime.greenSlimeCount -= GlobalSlime.greenSlimeCount;
            yield return new WaitForSeconds(GlobalGreenSeller.SellerRate); //waits for (x) seconds
            GreenSlimeAutoSell = false; //resets the bool
        }
        else if (GlobalSlime.greenSlimeCount > 0) {
            GlobalSlime.greenSlimeCount -= GreenSell;
            GlobalMoney.MoneyCount += (GlobalMoney.greenWorth * GreenSell); 
            yield return new WaitForSeconds(GlobalGreenSeller.SellerRate); //waits for (x) seconds
            GreenSlimeAutoSell = false; //resets the bool
        }
        else {
            yield return new WaitForSeconds(GlobalGreenSeller.SellerRate); //waits for (x) seconds
            GreenSlimeAutoSell = false; //resets the bool }
        }
    }
}
