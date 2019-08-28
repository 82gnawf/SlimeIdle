using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class DamageButton : MonoBehaviour {

    public GameObject SwordSwing;

    public int CritRand;
    public int HitRand;

    public double CritRate;
    public double HitRate;


    public void Start() {

        DamageAnimController.Initialize();

    }

    public void ButtonClick () {

        CritRate = GlobalSword.SwordCritRate * (1 - GlobalHp.SlimeCritDodge/100);
        HitRate = GlobalSword.SwordRate * (1 - GlobalHp.SlimeDodge/100);

        System.Random randomCR = new System.Random();
        System.Random randomHR = new System.Random();
        CritRand = randomCR.Next(1, 101); //between 1 and 100 
        HitRand = randomHR.Next(1, 101); 
        SwordSwing.GetComponent<Animation>().Play("SwordAnim");
        
        if (HitRand <= HitRate) {
            if (CritRand <= CritRate) {
                GlobalHp.TempHp -= GlobalSword.SwordCrit;
                DamageAnimController.CreateDamageText(GlobalSword.SwordCrit.ToString(), transform);
            }
            else {
                GlobalHp.TempHp -= GlobalSword.SwordDamage;
                DamageAnimController.CreateDamageText(GlobalSword.SwordDamage.ToString(), transform);
            }
        }
        else{
            DamageAnimController.CreateDamageText("Missed!", transform);
        }


    }
}
