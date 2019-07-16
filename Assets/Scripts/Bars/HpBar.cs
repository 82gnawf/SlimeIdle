using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour {

    Image healthBar;

	void Start () {
        healthBar = GetComponent<Image>();
	}
	
	void Update () {
        healthBar.fillAmount = (float)GlobalHp.TempHp / (float)GlobalHp.SlimeHp; 

	}
}
