using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class DamageButton : MonoBehaviour {

	public void ButtonClick () {
        GlobalHp.TempHp -= 5;
    }
}
