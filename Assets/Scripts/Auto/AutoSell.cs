using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class AutoSell : MonoBehaviour {

    public bool SlimeAutoSell = false; //bool for auto sell
    public static int SlimeSell;
    public int InternalSell;

    void Update() {
        SlimeSell = GlobalSeller.SellerLevel * GlobalSeller.SellerRate; //sells at 1 slime per second
        InternalSell = SlimeSell;

        if (SlimeAutoSell == false) {
            SlimeAutoSell = true;
            StartCoroutine(SellSlime()); //starts IEnumerator SellSlime()
        }
    }
    IEnumerator SellSlime() {
        if (GlobalSlime.SlimeCount > 0 && GlobalSlime.SlimeCount < InternalSell) {
            GlobalMoney.MoneyCount += (2 * GlobalSlime.SlimeCount);
            GlobalSlime.SlimeCount -= GlobalSlime.SlimeCount;
            yield return new WaitForSeconds(1); //waits for (x) seconds
            SlimeAutoSell = false; //resets the bool
        }
        else if (GlobalSlime.SlimeCount > 0) {
            GlobalSlime.SlimeCount -= InternalSell;
            GlobalMoney.MoneyCount += (2 * InternalSell); //should be value of slime TODO
            yield return new WaitForSeconds(1); //waits for (x) seconds
            SlimeAutoSell = false; //resets the bool
        }
        else {
            yield return new WaitForSeconds(1); //waits for (x) seconds
            SlimeAutoSell = false; //resets the bool }
        }
    }
}
