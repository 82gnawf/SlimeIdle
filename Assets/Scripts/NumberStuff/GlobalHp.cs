using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class GlobalHp : MonoBehaviour {

    public GameObject HpDisplay;

    public static double SlimeHp = (10 * Math.Pow(1.1, GlobalXp.LevelCount - 1)); //real hp based on level
    public static double TempHp; //honestly don't know if i need this lol
    public int InternalHp; 

    private void Start() {
        TempHp = SlimeHp;
    }

    private void Update() {
        InternalHp = Convert.ToInt32(TempHp); //double to string
        HpDisplay.GetComponent<Text>().text = "Hp: " + InternalHp; //display

        if (TempHp <= 0.5) {
            GlobalSlime.SlimeCount += 1; //increases amount of slime by 1
            GlobalXp.XpCount += 1; //increase xp by 1
            SlimeHp = (10 * Math.Pow(1.1, GlobalXp.LevelCount - 1));
            TempHp = SlimeHp; //resets slime hp
        }
    }
}
