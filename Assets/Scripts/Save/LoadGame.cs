using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour{

    public GameObject AutoDamage;
    public GameObject AutoSell;

    public int savedSlimes;
    public int savedMoney;
    public int savedFighter;
    public int savedSeller;
    public int savedHp;
    public int savedLevelCount;
    public int savedXpCount;

    void Start()
    {
        savedSlimes = PlayerPrefs.GetInt("SavedSlimes");
        GlobalSlime.SlimeCount = savedSlimes;

        savedMoney = PlayerPrefs.GetInt("SavedMoney");
        GlobalMoney.MoneyCount = savedMoney;

        savedFighter = PlayerPrefs.GetInt("SavedFigther");
        GlobalFighter.FighterLevel = savedFighter; 

        savedSeller = PlayerPrefs.GetInt("SavedSeller");
        GlobalSeller.SellerLevel = savedSeller;

        savedHp = PlayerPrefs.GetInt("SavedHp");
        GlobalHp.SlimeHp = savedHp;

        savedLevelCount = PlayerPrefs.GetInt("SavedLevelCount");
        GlobalXp.LevelCount = savedLevelCount;

        savedXpCount = PlayerPrefs.GetInt("SavedXpCount");
        GlobalXp.XpCount = savedXpCount;

        if (GlobalFighter.FighterLevel > 0) {
            AutoDamage.SetActive(true);
        }
        if (GlobalSeller.SellerLevel > 0) {
            AutoSell.SetActive(true);
        }
    }

}
