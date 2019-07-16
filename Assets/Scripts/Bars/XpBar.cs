using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class XpBar : MonoBehaviour {

    Image xpBar;

	void Start () {
        xpBar = GetComponent<Image>();
	}
	
	void Update () {
        xpBar.fillAmount = (float)GlobalXp.XpCount / (float)Math.Pow(2, GlobalXp.LevelCount); 

	}
}
