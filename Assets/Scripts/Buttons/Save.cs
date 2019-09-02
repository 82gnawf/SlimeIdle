using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Save : MonoBehaviour
{

    public void SaveGame() {
        SavingGame();
    }

    public static void SavingGame() {
        //currency
        PlayerPrefs.SetInt("greenSavedSlimes", GlobalSlime.greenSlimeCount);
        PlayerPrefs.SetInt("blueSavedSlimes", GlobalSlime.blueSlimeCount);
        PlayerPrefs.SetInt("redSavedSlimes", GlobalSlime.redSlimeCount);
        PlayerPrefs.SetInt("yellowSavedSlimes", GlobalSlime.yellowSlimeCount);
        PlayerPrefs.SetInt("orangeSavedSlimes", GlobalSlime.orangeSlimeCount);
        PlayerPrefs.SetInt("purpleSavedSlimes", GlobalSlime.purpleSlimeCount);
        PlayerPrefs.SetInt("whiteSavedSlimes", GlobalSlime.whiteSlimeCount);
        PlayerPrefs.SetInt("blackSavedSlimes", GlobalSlime.blackSlimeCount);
        PlayerPrefs.SetInt("SavedMoney", GlobalMoney.MoneyCount);
        //units
        PlayerPrefs.SetInt("SavedFigther", GlobalFighter.FighterLevel);
        PlayerPrefs.SetInt("SavedArcher", GlobalArcher.ArcherLevel);
        PlayerPrefs.SetInt("SavedWarrior", GlobalWarrior.WarriorLevel);
        PlayerPrefs.SetInt("SavedKnight", GlobalKnight.KnightLevel);
        PlayerPrefs.SetInt("SavedAssassin", GlobalAssassin.AssassinLevel);

        //sellers
        PlayerPrefs.SetInt("SavedGreenSeller", GlobalGreenSeller.SellerLevel);
        PlayerPrefs.SetInt("SavedBlueSeller", GlobalBlueSeller.SellerLevel);
        PlayerPrefs.SetInt("SavedRedSeller", GlobalRedSeller.SellerLevel);
        PlayerPrefs.SetInt("SavedYellowSeller", GlobalYellowSeller.SellerLevel);
        PlayerPrefs.SetInt("SavedOrangeSeller", GlobalOrangeSeller.SellerLevel);

        //sword
        PlayerPrefs.SetInt("SavedDamage", GlobalSword.SwordDamageLevel);
        PlayerPrefs.SetInt("SavedRate", GlobalSword.SwordRateLevel);
        PlayerPrefs.SetInt("SavedCrit", GlobalSword.SwordCritLevel);
        PlayerPrefs.SetInt("SavedCritRate", GlobalSword.SwordCritRateLevel);

        //prod
        PlayerPrefs.SetInt("SavedGreenHab", GreenHabitat.GreenHabLevel);
        PlayerPrefs.SetInt("SavedBlueHab", BlueHabitat.BlueHabLevel);
        PlayerPrefs.SetInt("SavedRedHab", RedHabitat.RedHabLevel);
        PlayerPrefs.SetInt("SavedYellowHab", YellowHabitat.YellowHabLevel);
        PlayerPrefs.SetInt("SavedOrangeHab", OrangeHabitat.OrangeHabLevel);

        //hp
        PlayerPrefs.SetInt("SavedHp", Convert.ToInt32(GlobalHp.SlimeHp));
        PlayerPrefs.SetInt("SavedTempHp", Convert.ToInt32(GlobalHp.TempHp));
        PlayerPrefs.SetInt("SavedSpawn", GlobalHp.slimeSpawn);

        //xp
        PlayerPrefs.SetInt("SavedXpCount", GlobalXp.XpCount);
        PlayerPrefs.SetInt("SavedLevelCount", GlobalXp.LevelCount);

        //unlock
        PlayerPrefs.SetInt("SavedSlimeSeen", SlimeUnlockNumber.SlimeSeen);

        Debug.Log("Game Saved");
    }
}
