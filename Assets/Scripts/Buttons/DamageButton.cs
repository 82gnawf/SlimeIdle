using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class DamageButton : MonoBehaviour {

    public GameObject SwordSwing;

	public void ButtonClick () {
     
        GlobalHp.TempHp -= GlobalSword.SwordDamage;
        SwordSwing.GetComponent<Animation>().Play("SwordAnim");

    }
}
