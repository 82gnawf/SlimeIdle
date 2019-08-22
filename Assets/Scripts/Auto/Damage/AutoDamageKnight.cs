using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class AutoDamageKnight : MonoBehaviour {

    public bool KnightAutoDamage = false; //bool for auto attack
    public static int SlimeDamage;
    public int InternalDamage;

    void Update() {
        SlimeDamage = Convert.ToInt32(GlobalKnight.KnightDamage);
        InternalDamage = SlimeDamage;

        if (KnightAutoDamage == false) {
            KnightAutoDamage = true;
            StartCoroutine(DamageSlime()); //starts IEnumerator DamageSlime()
        }
    }
    IEnumerator DamageSlime() {
        GlobalHp.TempHp -= InternalDamage; //deals the damage

        yield return new WaitForSeconds(GlobalKnight.HitRate); //waits for (x) seconds
        KnightAutoDamage = false; //resets the bool
    }
}