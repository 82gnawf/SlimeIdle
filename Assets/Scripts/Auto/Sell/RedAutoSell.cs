using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class RedAutoSell : MonoBehaviour {

    public bool RedSlimeAutoSell = false; //bool for red auto sell
    public int RedSell;

    void Update() {
        RedSell = GlobalRedSeller.SellerLevel * GlobalRedSeller.SellerRate; //sells at 1 slime per second

        if (RedSlimeAutoSell == false) {
            RedSlimeAutoSell = true;
            StartCoroutine(SellRedSlime()); //starts IEnumerator SellSlime()
        }
    }

    IEnumerator SellRedSlime() {
        if (GlobalSlime.redSlimeCount > 0 && GlobalSlime.redSlimeCount < RedSell) {
            GlobalMoney.MoneyCount += (GlobalMoney.redWorth * GlobalSlime.redSlimeCount);
            GlobalSlime.redSlimeCount -= GlobalSlime.redSlimeCount;
            yield return new WaitForSeconds(1); //waits for (x) seconds
            RedSlimeAutoSell = false; //resets the bool
        }
        else if (GlobalSlime.redSlimeCount > 0) {
            GlobalSlime.redSlimeCount -= RedSell;
            GlobalMoney.MoneyCount += (GlobalMoney.redWorth * RedSell); 
            yield return new WaitForSeconds(1); //waits for (x) seconds
            RedSlimeAutoSell = false; //resets the bool
        }
        else {
            yield return new WaitForSeconds(1); //waits for (x) seconds
            RedSlimeAutoSell = false; //resets the bool }
        }
    }
}


