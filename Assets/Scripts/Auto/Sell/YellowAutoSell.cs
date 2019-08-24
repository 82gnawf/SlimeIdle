using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class YellowAutoSell : MonoBehaviour {

    public bool YellowSlimeAutoSell = false; //bool for yellow auto sell
    public int YellowSell;

    void Update() {
        YellowSell = GlobalYellowSeller.SellerLevel * GlobalYellowSeller.SellerRate; //sells at 1 slime per second

        if (YellowSlimeAutoSell == false) {
            YellowSlimeAutoSell = true;
            StartCoroutine(SellYellowSlime()); //starts IEnumerator SellSlime()
        }
    }

    IEnumerator SellYellowSlime() {
        if (GlobalSlime.yellowSlimeCount > 0 && GlobalSlime.yellowSlimeCount < YellowSell) {
            GlobalMoney.MoneyCount += (GlobalMoney.yellowWorth * GlobalSlime.yellowSlimeCount);
            GlobalSlime.yellowSlimeCount -= GlobalSlime.yellowSlimeCount;
            yield return new WaitForSeconds(GlobalYellowSeller.SellerRate); //waits for (x) seconds
            YellowSlimeAutoSell = false; //resets the bool
        }
        else if (GlobalSlime.yellowSlimeCount > 0) {
            GlobalSlime.yellowSlimeCount -= YellowSell;
            GlobalMoney.MoneyCount += (GlobalMoney.yellowWorth * YellowSell); 
            yield return new WaitForSeconds(GlobalYellowSeller.SellerRate); //waits for (x) seconds
            YellowSlimeAutoSell = false; //resets the bool
        }
        else {
            yield return new WaitForSeconds(GlobalYellowSeller.SellerRate); //waits for (x) seconds
            YellowSlimeAutoSell = false; //resets the bool }
        }
    }
}


