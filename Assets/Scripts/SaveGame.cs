using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour {

    public bool SavingGame = false;

    void Update() {
        if (SavingGame == false) {
            SavingGame = true;
            StartCoroutine(SaveValues()); //starts IEnumerator DamageSlime()
        }
    }

    IEnumerator SaveValues() {

        PlayerPrefs.SetInt("SavedSlimes", GlobalSlime.SlimeCount);
        PlayerPrefs.SetInt("SavedMoney", GlobalMoney.MoneyCount);
        PlayerPrefs.SetInt("SavedFigther", GlobalFighter.FighterLevel);
        PlayerPrefs.SetInt("SavedSeller", GlobalSeller.SellerLevel);

        yield return new WaitForSeconds(5); //waits for (x) seconds
        SavingGame = false; //resets the bool
    }

}