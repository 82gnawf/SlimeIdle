using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class OrangeAutoSell : MonoBehaviour {

    public bool OrangeSlimeAutoSell = false; //bool for orange auto sell
    public int OrangeSell;

    void Update() {
        OrangeSell = GlobalOrangeSeller.SellerLevel * GlobalOrangeSeller.SellerRate; //sells at 1 slime per second

        if (OrangeSlimeAutoSell == false) {
            OrangeSlimeAutoSell = true;
            StartCoroutine(SellOrangeSlime()); //starts IEnumerator SellSlime()
        }
    }

    IEnumerator SellOrangeSlime() {
        if (GlobalSlime.orangeSlimeCount > 0 && GlobalSlime.orangeSlimeCount < OrangeSell) {
            GlobalMoney.MoneyCount += (GlobalMoney.orangeWorth * GlobalSlime.orangeSlimeCount);
            GlobalSlime.orangeSlimeCount -= GlobalSlime.orangeSlimeCount;
            yield return new WaitForSeconds(1); //waits for (x) seconds
            OrangeSlimeAutoSell = false; //resets the bool
        }
        else if (GlobalSlime.orangeSlimeCount > 0) {
            GlobalSlime.orangeSlimeCount -= OrangeSell;
            GlobalMoney.MoneyCount += (GlobalMoney.orangeWorth * OrangeSell);
            yield return new WaitForSeconds(1); //waits for (x) seconds
            OrangeSlimeAutoSell = false; //resets the bool
        }
        else {
            yield return new WaitForSeconds(1); //waits for (x) seconds
            OrangeSlimeAutoSell = false; //resets the bool }
        }
    }
}


