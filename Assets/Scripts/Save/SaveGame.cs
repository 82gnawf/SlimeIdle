using System.Collections;
using System.Collections.Generic;
using System;
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

        PlayerPrefs.SetInt("greenSavedSlimes", GlobalSlime.greenSlimeCount);
        PlayerPrefs.SetInt("blueSavedSlimes", GlobalSlime.blueSlimeCount);
        PlayerPrefs.SetInt("redSavedSlimes", GlobalSlime.redSlimeCount);
        PlayerPrefs.SetInt("SavedMoney", GlobalMoney.MoneyCount);
        PlayerPrefs.SetInt("SavedFigther", GlobalFighter.FighterLevel);
        PlayerPrefs.SetInt("SavedArcher", GlobalArcher.ArcherLevel);
        PlayerPrefs.SetInt("SavedSeller", GlobalSeller.SellerLevel);
        PlayerPrefs.SetInt("SavedHp", Convert.ToInt32(GlobalHp.SlimeHp));
        PlayerPrefs.SetInt("SavedTempHp", Convert.ToInt32(GlobalHp.TempHp));
        PlayerPrefs.SetInt("SavedSpawn", GlobalHp.slimeSpawn);
        PlayerPrefs.SetInt("SavedXpCount", GlobalXp.XpCount);
        PlayerPrefs.SetInt("SavedLevelCount", GlobalXp.LevelCount);

        yield return new WaitForSeconds(5); //waits for (x) seconds
        SavingGame = false; //resets the bool
    }

}