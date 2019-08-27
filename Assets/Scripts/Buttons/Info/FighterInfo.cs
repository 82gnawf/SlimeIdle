using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FighterInfo : MonoBehaviour
{
    public int pageNum;
    public string unit;
    public int damage;
    public int damageRate;
    public int critDamage;
    public int critRate;
    public float hitRate;
    public string special; //unused for tier I

    public GameObject UnitImage;
    public GameObject FighterLabel;
    public GameObject Stats;

    public Sprite Fighter;
    public Sprite Archer;
    public Sprite Warrior;
    public Sprite Knight;
    public Sprite Assassin;

    public Button LeftButton;
    public Button RightButton;

    public void open() {
        pageNum = 1;
    }

    public void left() {
        pageNum--;
    }

    public void right() {
        pageNum++;
    }

    public void checkInteractable() {
        if (pageNum == 1) {
            LeftButton.interactable = false;
        }
        else if (pageNum == 5) { // 5 fighters
            RightButton.interactable = false;
        }
        else {
            LeftButton.interactable = true;
            RightButton.interactable = true;
        }
    }

    public void checkPage() {
        switch(pageNum) {
            case 1:
                UnitImage.GetComponent<Image>().sprite = Fighter;
                unit = "Fighter";
                damage = Convert.ToInt32(GlobalFighter.FighterDamage);
                damageRate = Convert.ToInt32(GlobalFighter.DamageRate);
                critDamage = Convert.ToInt32(GlobalFighter.CritDamage);
                critRate = Convert.ToInt32(GlobalFighter.CritRate);
                hitRate = GlobalFighter.HitRate;
                break;
            case 2:
                UnitImage.GetComponent<Image>().sprite = Archer;
                unit = "Archer";
                damage = Convert.ToInt32(GlobalArcher.ArcherDamage);
                damageRate = Convert.ToInt32(GlobalArcher.DamageRate);
                critDamage = Convert.ToInt32(GlobalArcher.CritDamage);
                critRate = Convert.ToInt32(GlobalArcher.CritRate);
                hitRate = GlobalArcher.HitRate;
                break;
            case 3:
                UnitImage.GetComponent<Image>().sprite = Warrior;
                unit = "Warrior";
                damage = Convert.ToInt32(GlobalWarrior.WarriorDamage);
                damageRate = Convert.ToInt32(GlobalWarrior.DamageRate);
                critDamage = Convert.ToInt32(GlobalWarrior.CritDamage);
                critRate = Convert.ToInt32(GlobalWarrior.CritRate);
                hitRate = GlobalWarrior.HitRate;
                break;
            case 4:
                UnitImage.GetComponent<Image>().sprite = Knight;
                unit = "Knight";
                damage = Convert.ToInt32(GlobalKnight.KnightDamage);
                damageRate = Convert.ToInt32(GlobalKnight.DamageRate);
                critDamage = Convert.ToInt32(GlobalKnight.CritDamage);
                critRate = Convert.ToInt32(GlobalKnight.CritRate);
                hitRate = GlobalKnight.HitRate;
                break;
            case 5:
                UnitImage.GetComponent<Image>().sprite = Assassin;
                unit = "Assassin";
                damage = Convert.ToInt32(GlobalAssassin.AssassinDamage);
                damageRate = Convert.ToInt32(GlobalAssassin.DamageRate);
                critDamage = Convert.ToInt32(GlobalAssassin.CritDamage);
                critRate = Convert.ToInt32(GlobalAssassin.CritRate);
                hitRate = GlobalAssassin.HitRate;
                break;
        }

        FighterLabel.GetComponent<Text>().text = unit;
        Stats.GetComponent<Text>().text = "Damage: " + damage + "\n Damage Rate: " + damageRate + "%\n Crit. Damage: " + critDamage + "\n Crit. Rate: " + critRate + "%\n Hit Rate: Hits every " + hitRate + " sec.";
    }
}
