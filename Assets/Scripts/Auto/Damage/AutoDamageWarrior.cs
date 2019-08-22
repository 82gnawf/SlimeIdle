using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class AutoDamageWarrior : MonoBehaviour {

    public bool WarriorAutoDamage = false; //bool for auto attack
    public static int SlimeDamage;
    public int InternalDamage;

    void Update() {
        SlimeDamage = Convert.ToInt32(GlobalWarrior.WarriorDamage);
        InternalDamage = SlimeDamage;

        if (WarriorAutoDamage == false) {
            WarriorAutoDamage = true;
            StartCoroutine(DamageSlime()); //starts IEnumerator DamageSlime()
        }
    }
    IEnumerator DamageSlime() {
        GlobalHp.TempHp -= InternalDamage; //deals the damage

        yield return new WaitForSeconds(GlobalWarrior.HitRate); //waits for (x) seconds
        WarriorAutoDamage = false; //resets the bool
    }
}



