using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour{

    public GameObject FighterAutoDamage;
    public GameObject ArcherAutoDamage;
    public GameObject WarriorAutoDamage;

    public GameObject AutoSell;

    public int greenSavedSlimes;
    public int blueSavedSlimes;
    public int redSavedSlimes;
    public int yellowSavedSlimes;
    public int orangeSavedSlimes;
    public int savedMoney;
    public int savedFighter;
    public int savedArcher;
    public int savedWarrior;
    public int savedGreenSeller;
    public int savedDamage;
    public int savedRate;
    public int savedCrit;
    public int savedCritRate;
    public int savedHp;
    public int savedTempHp;
    public int savedSpawn;
    public int savedLevelCount;
    public int savedXpCount;

    public static bool spriteInit;

    void Start()
    {
        //currency
        greenSavedSlimes = PlayerPrefs.GetInt("greenSavedSlimes");
        GlobalSlime.greenSlimeCount = greenSavedSlimes;
        blueSavedSlimes = PlayerPrefs.GetInt("blueSavedSlimes");
        GlobalSlime.blueSlimeCount = blueSavedSlimes;
        redSavedSlimes = PlayerPrefs.GetInt("redSavedSlimes");
        GlobalSlime.redSlimeCount = redSavedSlimes;
        yellowSavedSlimes = PlayerPrefs.GetInt("yellowSavedSlimes");
        GlobalSlime.yellowSlimeCount = yellowSavedSlimes;
        orangeSavedSlimes = PlayerPrefs.GetInt("orangeSavedSlimes");
        GlobalSlime.orangeSlimeCount = orangeSavedSlimes;
        savedMoney = PlayerPrefs.GetInt("SavedMoney");
        GlobalMoney.MoneyCount = savedMoney;

        //units
        savedFighter = PlayerPrefs.GetInt("SavedFigther");
        GlobalFighter.FighterLevel = savedFighter;
        savedArcher = PlayerPrefs.GetInt("SavedArcher");
        GlobalArcher.ArcherLevel = savedArcher;
        savedWarrior = PlayerPrefs.GetInt("SavedWarrior");
        GlobalWarrior.WarriorLevel = savedWarrior;
        savedGreenSeller = PlayerPrefs.GetInt("SavedGreenSeller");
        GlobalGreenSeller.SellerLevel = savedGreenSeller;

        //sword
        savedDamage = PlayerPrefs.GetInt("SavedDamage");
        GlobalSword.SwordDamageLevel = savedDamage;
        savedRate = PlayerPrefs.GetInt("SavedRate");
        GlobalSword.SwordRateLevel = savedDamage;
        savedCrit = PlayerPrefs.GetInt("SavedCrit");
        GlobalSword.SwordCritLevel = savedDamage;
        savedCritRate = PlayerPrefs.GetInt("SavedCritRate");
        GlobalSword.SwordCritRateLevel = savedDamage;

        //hp stuff
        savedHp = PlayerPrefs.GetInt("SavedHp");
        if (savedHp == 0) { //wont spawn at level 0 anymore
                savedHp = 10;
            }
        GlobalHp.SlimeHp = savedHp;
        savedTempHp = PlayerPrefs.GetInt("SavedTempHp");
        if (savedTempHp == 0) { //wont spawn at level 0 anymore
            savedTempHp = 10;
        }
        GlobalHp.TempHp = savedTempHp;
        savedSpawn = PlayerPrefs.GetInt("SavedSpawn");
        if (savedSpawn == 0) {
            savedSpawn = 1;
        }
        GlobalHp.slimeSpawn = savedSpawn;


        spriteInit = false; 

        //xp
        savedLevelCount = PlayerPrefs.GetInt("SavedLevelCount");
        if (savedLevelCount == 0) { //wont spawn at level 0 anymore
            savedLevelCount = 1;
        }
        GlobalXp.LevelCount = savedLevelCount;
        savedXpCount = PlayerPrefs.GetInt("SavedXpCount");
        GlobalXp.XpCount = savedXpCount;

        //autodmg checker
        if (GlobalFighter.FighterLevel > 0) { 
            FighterAutoDamage.SetActive(true);
        }
        if (GlobalArcher.ArcherLevel > 0) {
            ArcherAutoDamage.SetActive(true);
        }
        if (GlobalWarrior.WarriorLevel > 0) {
            WarriorAutoDamage.SetActive(true);
        }
        if (GlobalGreenSeller.SellerLevel > 0) {
            AutoSell.SetActive(true);
        }

    }

}
