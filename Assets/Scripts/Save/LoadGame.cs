using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour{

    public GameObject FighterAutoDamage;
    public GameObject ArcherAutoDamage;
    public GameObject WarriorAutoDamage;
    public GameObject KnightAutoDamage;
    public GameObject AssassinAutoDamage;

    public GameObject GreenAutoSell;
    public GameObject BlueAutoSell;
    public GameObject RedAutoSell;
    public GameObject YellowAutoSell;
    public GameObject OrangeAutoSell;

    public GameObject GreenSlimeProduction;

    public int greenSavedSlimes;
    public int blueSavedSlimes;
    public int redSavedSlimes;
    public int yellowSavedSlimes;
    public int orangeSavedSlimes;
    public int savedMoney;
    public int savedFighter;
    public int savedArcher;
    public int savedWarrior;
    public int savedKnight;
    public int savedAssassin;
    public int savedGreenSeller;
    public int savedBlueSeller;
    public int savedRedSeller;
    public int savedYellowSeller;
    public int savedOrangeSeller;
    public int savedDamage;
    public int savedRate;
    public int savedCrit;
    public int savedCritRate;
    public int savedGreenHab;
    public int savedBlueHab;
    public int savedRedHab;
    public int savedYellowHab;
    public int savedOrangeHab;
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
        savedKnight = PlayerPrefs.GetInt("SavedKnight");
        GlobalKnight.KnightLevel = savedKnight;
        savedAssassin = PlayerPrefs.GetInt("SavedAssassin");
        GlobalAssassin.AssassinLevel = savedAssassin;

        //sellers
        savedGreenSeller = PlayerPrefs.GetInt("SavedGreenSeller");
        GlobalGreenSeller.SellerLevel = savedGreenSeller;
        savedBlueSeller = PlayerPrefs.GetInt("SavedBlueSeller");
        GlobalBlueSeller.SellerLevel = savedBlueSeller;
        savedRedSeller = PlayerPrefs.GetInt("SavedRedSeller");
        GlobalRedSeller.SellerLevel = savedRedSeller;
        savedYellowSeller = PlayerPrefs.GetInt("SavedYellowSeller");
        GlobalYellowSeller.SellerLevel = savedYellowSeller;
        savedOrangeSeller = PlayerPrefs.GetInt("SavedOrangeSeller");
        GlobalOrangeSeller.SellerLevel = savedOrangeSeller;

        //sword
        savedDamage = PlayerPrefs.GetInt("SavedDamage");
        if (savedDamage == 0) {
            GlobalSword.SwordDamageLevel = 1;
        }
        else {
            GlobalSword.SwordDamageLevel = savedDamage;
        }
        savedRate = PlayerPrefs.GetInt("SavedRate");
        if (savedRate == 0) {
            GlobalSword.SwordRateLevel = 1;
        }
        else {
            GlobalSword.SwordRateLevel = savedRate;
        }
        savedCrit = PlayerPrefs.GetInt("SavedCrit");
        if (savedCrit == 0) {
            GlobalSword.SwordCritLevel = 1;
        }
        else {
            GlobalSword.SwordCritLevel = savedCrit;
        }
        savedCritRate = PlayerPrefs.GetInt("SavedCritRate");
        if (savedCritRate == 0) {
            GlobalSword.SwordCritRateLevel = 1;
        }
        else {
            GlobalSword.SwordCritRateLevel = savedCritRate;
        }

        //prod
        savedGreenHab = PlayerPrefs.GetInt("SavedGreenHab");
        GreenHabitat.GreenHabLevel = savedGreenHab;
        savedBlueHab = PlayerPrefs.GetInt("SavedBlueHab");
        BlueHabitat.BlueHabLevel = savedBlueHab;
        savedRedHab = PlayerPrefs.GetInt("SavedRedHab");
        RedHabitat.RedHabLevel = savedRedHab;
        savedYellowHab = PlayerPrefs.GetInt("SavedYellowHab");
        YellowHabitat.YellowHabLevel = savedYellowHab;
        savedOrangeHab = PlayerPrefs.GetInt("SavedOrangeHab");
        OrangeHabitat.OrangeHabLevel = savedOrangeHab;

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

        //auto checker
        if (GlobalFighter.FighterLevel > 0) { 
            FighterAutoDamage.SetActive(true);
        }
        if (GlobalArcher.ArcherLevel > 0) {
            ArcherAutoDamage.SetActive(true);
        }
        if (GlobalWarrior.WarriorLevel > 0) {
            WarriorAutoDamage.SetActive(true);
        }
        if (GlobalKnight.KnightLevel > 0) {
            KnightAutoDamage.SetActive(true);
        }
        if (GlobalAssassin.AssassinLevel > 0) {
            AssassinAutoDamage.SetActive(true);
        }
        if (GlobalGreenSeller.SellerLevel > 0) {
            GreenAutoSell.SetActive(true);
        }
        if (GlobalBlueSeller.SellerLevel > 0) {
            BlueAutoSell.SetActive(true);
        }
        if (GlobalRedSeller.SellerLevel > 0) {
            RedAutoSell.SetActive(true);
        }
        if (GlobalYellowSeller.SellerLevel > 0) {
            YellowAutoSell.SetActive(true);
        }
        if (GlobalOrangeSeller.SellerLevel > 0) {
            OrangeAutoSell.SetActive(true);
        }
    }

}
