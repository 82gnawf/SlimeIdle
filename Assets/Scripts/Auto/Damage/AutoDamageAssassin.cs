using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class AutoDamageAssassin : MonoBehaviour {

    public bool AssassinAutoDamage = false; //bool for auto attack
    public int InternalDamage;
    public int InternalCrit;

    public int CritRand;
    public int HitRand;

    public double CritRate;
    public double HitRate;

    void Update() {
        InternalDamage = Convert.ToInt32(GlobalAssassin.AssassinDamage);
        InternalCrit = Convert.ToInt32(GlobalAssassin.CritDamage);

        if (AssassinAutoDamage == false) {
            AssassinAutoDamage = true;
            StartCoroutine(DamageSlime()); //starts IEnumerator DamageSlime()
        }
    }
    IEnumerator DamageSlime() {

        CritRate = GlobalAssassin.CritRate * (1 - GlobalHp.SlimeCritDodge / 100);
        HitRate = GlobalAssassin.DamageRate * (1 - GlobalHp.SlimeDodge / 100);

        System.Random randomCR = new System.Random();
        System.Random randomHR = new System.Random();
        CritRand = randomCR.Next(1, 101); //between 1 and 100 
        HitRand = randomHR.Next(1, 101);

        if (HitRand <= HitRate) {
            if (CritRand <= CritRate) {
                GlobalHp.TempHp -= InternalCrit;
            }
            else {
                GlobalHp.TempHp -= InternalDamage;
            }
        }
        else { }

        yield return new WaitForSeconds(GlobalAssassin.HitRate); //waits for (x) seconds
        AssassinAutoDamage = false; //resets the bool
    }


}