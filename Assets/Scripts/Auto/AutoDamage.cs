using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class AutoDamage : MonoBehaviour { 

    public bool SlimeAutoDamage = false; //bool for auto attack
    public static int SlimeDamage;
    public int InternalDamage;
	
	void Update () {
        SlimeDamage = Convert.ToInt32(GlobalFighter.FighterDPS);
        InternalDamage = SlimeDamage;

        if (SlimeAutoDamage == false){
            SlimeAutoDamage = true;
            StartCoroutine(DamageSlime()); //starts IEnumerator DamageSlime()
        }
	}
    IEnumerator DamageSlime() {
        GlobalHp.TempHp -= InternalDamage; //deals the damage

        yield return new WaitForSeconds(1); //waits for (x) seconds
        SlimeAutoDamage = false; //resets the bool
    }
}
