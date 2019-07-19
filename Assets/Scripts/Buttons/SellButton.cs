using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellButton : MonoBehaviour {

	public void ButtonClick () {
        if (GlobalSlime.SlimeCount == 0) {
            
        }
        else {
            GlobalSlime.SlimeCount -= 1; //reduces slime amount
            GlobalMoney.MoneyCount += 2; //get money per slime sold
        }
    }
}
