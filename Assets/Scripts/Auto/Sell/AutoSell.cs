using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class AutoSell : MonoBehaviour {

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
            GlobalMoney.MoneyCount += (2 * GlobalSlime.greenSlimeCount);
            GlobalSlime.greenSlimeCount -= GlobalSlime.greenSlimeCount;
            yield return new WaitForSeconds(1); //waits for (x) seconds
            GreenSlimeAutoSell = false; //resets the bool
        }
        else if (GlobalSlime.greenSlimeCount > 0) {
            GlobalSlime.greenSlimeCount -= GreenSell;
            GlobalMoney.MoneyCount += (2 * GreenSell); //should be value of slime TODO
            yield return new WaitForSeconds(1); //waits for (x) seconds
            GreenSlimeAutoSell = false; //resets the bool
        }
        else {
            yield return new WaitForSeconds(1); //waits for (x) seconds
            GreenSlimeAutoSell = false; //resets the bool }
        }
    }
}
