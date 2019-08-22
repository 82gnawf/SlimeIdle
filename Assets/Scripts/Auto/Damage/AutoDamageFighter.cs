using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class AutoDamageFighter : MonoBehaviour { 

    public bool FighterAutoDamage = false; //bool for auto attack
    public static int SlimeDamage;
    public int InternalDamage;
	
	void Update () {
        SlimeDamage = Convert.ToInt32(GlobalFighter.FighterDamage);
        InternalDamage = SlimeDamage;

        if (FighterAutoDamage == false){
            FighterAutoDamage = true;
            StartCoroutine(DamageSlime()); //starts IEnumerator DamageSlime()
        }
	}
    IEnumerator DamageSlime() {
        GlobalHp.TempHp -= InternalDamage; //deals the damage

        yield return new WaitForSeconds(GlobalFighter.HitRate); //waits for (x) seconds
        FighterAutoDamage = false; //resets the bool
    }
}
