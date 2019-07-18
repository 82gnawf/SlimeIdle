﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class GlobalXp : MonoBehaviour
{
    public GameObject XpDisplay;
    public GameObject SlimeLevelDisplay;

    public static int XpCount;
    public int InternalXpCount;

    public static int LevelCount = 1;
    public int PlayerLevel;

    public static int SlimeLevel;

    private void Update()
    {
        InternalXpCount = XpCount;
        PlayerLevel = LevelCount;
        SlimeLevel = LevelCount;

        XpDisplay.GetComponent<Text>().text = "Level: " + PlayerLevel + " Xp: " + InternalXpCount + " / " + Math.Pow(2, LevelCount); //display for xp
        SlimeLevelDisplay.GetComponent<Text>().text = "Green Slime - Level: " + SlimeLevel; //display for slime level

        SlimeLevel = LevelCount;
    }
}
