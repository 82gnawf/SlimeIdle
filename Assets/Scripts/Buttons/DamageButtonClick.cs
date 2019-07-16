using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class DamageButtonClick : MonoBehaviour {

    public GameObject textBox; 

	public void ButtonClick () {
        GlobalHp.TempHp -= 4;
    }
}
