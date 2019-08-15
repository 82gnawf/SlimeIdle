using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class AutoDamageAssassin : MonoBehaviour {

    public bool AssassinAutoDamage = false; //bool for auto attack
    public static int SlimeDamage;
    public int InternalDamage;

    void Update() {
        SlimeDamage = Convert.ToInt32(GlobalAssassin.AssassinDamage);
        InternalDamage = SlimeDamage;

        if (AssassinAutoDamage == false) {
            AssassinAutoDamage = true;
            StartCoroutine(DamageSlime()); //starts IEnumerator DamageSlime()
        }
    }
    IEnumerator DamageSlime() {
        GlobalHp.TempHp -= InternalDamage; //deals the damage

        yield return new WaitForSeconds(1); //waits for (x) seconds
        AssassinAutoDamage = false; //resets the bool
    }
}