using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class BlueAutoSell : MonoBehaviour {

    public bool BlueSlimeAutoSell = false; //bool for blue auto sell
    public int BlueSell;

    void Update() {
        BlueSell = GlobalBlueSeller.SellerLevel * GlobalBlueSeller.SellerRate; //sells at 1 slime per second

        if (BlueSlimeAutoSell == false) {
            BlueSlimeAutoSell = true;
            StartCoroutine(SellBlueSlime()); //starts IEnumerator SellSlime()
        }
    }

    IEnumerator SellBlueSlime() {
        if (GlobalSlime.blueSlimeCount > 0 && GlobalSlime.blueSlimeCount < BlueSell) {
            GlobalMoney.MoneyCount += (GlobalMoney.blueWorth * GlobalSlime.blueSlimeCount);
            GlobalSlime.blueSlimeCount -= GlobalSlime.blueSlimeCount;
            yield return new WaitForSeconds(1); //waits for (x) seconds
            BlueSlimeAutoSell = false; //resets the bool
        }
        else if (GlobalSlime.blueSlimeCount > 0) {
            GlobalSlime.blueSlimeCount -= BlueSell;
            GlobalMoney.MoneyCount += (GlobalMoney.blueWorth * BlueSell);
            yield return new WaitForSeconds(1); //waits for (x) seconds
            BlueSlimeAutoSell = false; //resets the bool
        }
        else {
            yield return new WaitForSeconds(1); //waits for (x) seconds
            BlueSlimeAutoSell = false; //resets the bool }
        }
    }
}


