using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class AutoDamageArcher : MonoBehaviour { 

    public bool ArcherAutoDamage = false; //bool for auto attack
    public static int SlimeDamage;
    public int InternalDamage;
	
	void Update () {
        SlimeDamage = Convert.ToInt32(GlobalArcher.ArcherDamage);
        InternalDamage = SlimeDamage;

        if (ArcherAutoDamage == false){
            ArcherAutoDamage = true;
            StartCoroutine(DamageSlime()); //starts IEnumerator DamageSlime()
        }
	}
    IEnumerator DamageSlime() {
        GlobalHp.TempHp -= InternalDamage; //deals the damage

        yield return new WaitForSeconds(GlobalArcher.HitRate); //waits for (x) seconds
        ArcherAutoDamage = false; //resets the bool
    }
}
