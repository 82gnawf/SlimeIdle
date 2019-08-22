using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class GlobalHp : MonoBehaviour {

    public GameObject HpDisplay;
    public GameObject SlimeImage;

    public Sprite greenSlime;
    public Sprite blueSlime;
    public Sprite redSlime;
    public Sprite yellowSlime;
    public Sprite orangeSlime;
    public Sprite purpleSlime;
    public Sprite whiteSlime;
    public Sprite blackSlime;

    public int slimeRand;  //used for random choosing of slime

    public static int slimeSpawn; //what slime will be spawned
    public static int typeHp = 10;

    public static double SlimeCritDodge;
    public static double SlimeDodge;

    public int dodgeChance = 0;
    public int critDodgeChance = 0;

    public static double SlimeHp = (typeHp * Math.Pow(1.1, GlobalXp.LevelCount - 1)); //real hp based on level
    public static double TempHp; //honestly don't know if i need this lol
    public int InternalHp;

    private void Start() {
        TempHp = SlimeHp;
    }



    private void Update() {
        InternalHp = Convert.ToInt32(TempHp); //double to string
        HpDisplay.GetComponent<Text>().text = "Hp: " + InternalHp; //display

        if (LoadGame.spriteInit == false) {
            SlimeSprite();
            LoadGame.spriteInit = true;
        }

        if (TempHp <= 0.5) {
            switch (slimeSpawn) {
                case 1:
                    GlobalSlime.greenSlimeCount += 1; //increases amount of green slime by 1
                    break;
                case 2:
                    GlobalSlime.blueSlimeCount += 1;
                    break;
                case 3:
                    GlobalSlime.redSlimeCount += 1;
                    break;
                case 4:
                    GlobalSlime.yellowSlimeCount += 1;
                    break;
                case 5:
                    GlobalSlime.orangeSlimeCount += 1;
                    break;
                case 6:
                    GlobalSlime.purpleSlimeCount += 1;
                    break;
                case 7:
                    GlobalSlime.whiteSlimeCount += 1;
                    break;
                case 8:
                    GlobalSlime.blackSlimeCount += 1;
                    break;
            }

            GlobalXp.XpCount += 1; //increase xp by 1
            if (GlobalXp.XpCount >= Math.Pow(2, GlobalXp.LevelCount)) { // this is level up stuff
                GlobalXp.LevelCount++;
                GlobalXp.XpCount -= Convert.ToInt32(Math.Pow(2, GlobalXp.LevelCount - 1)); //double to int cause :(
            }

            slimeSpawn = SlimeSpawn(GlobalXp.LevelCount);
            SlimeSprite();
            typeHp = GenerateHp(slimeSpawn);
            dodgeChance = dodgeCheck(slimeSpawn);
            critDodgeChance = critDodgeCheck(slimeSpawn);

            SlimeDodge = dodgeChance;
            SlimeCritDodge = critDodgeChance;

            SlimeHp = (typeHp * Math.Pow(1.1, GlobalXp.LevelCount - 1));
            TempHp = SlimeHp; //resets slime hp
        }
    }

    public static int dodgeCheck (int k) { //chance of slime dodging normal attack
        switch (k) {
            case 1:
                return 0;
            case 2:
                return 0;
            case 3:
                return 10;
            case 4:
                return 10;
            case 5:
                return 20;
            case 6:
                return 0;
            case 7:
                return 40;
            case 8:
                return 50;
            
        }
        return 0;
    }

    public static int critDodgeCheck(int k) { //chance of slime dodging crit attack
        switch (k) {
            case 1:
                return 0;
            case 2:
                return 0;
            case 3:
                return 0;
            case 4:
                return 0;
            case 5:
                return 0;
            case 6:
                return 0;
            case 7:
                return 10;
            case 8:
                return 10;

        }
        return 0;
    }

    //random gens slime type; 1 = green, 2 = blue, etc.
    private int SlimeSpawn(int i) {

        System.Random random = new System.Random();
        slimeRand = random.Next(1, 11); //between 1 and 10 inclusive fml 
        int n = 0;

        switch (i) {
            case 1:
                n = 1;
                break;
            case 2:
                n = 1;
                break;
            case 3:
                n = 1;
                break;
            case 4:
                if (slimeRand > 8) {
                    n = 2;
                }
                else {
                    n = 1;
                }
                break;
            case 5:
                if (slimeRand > 5) {
                n = 2;
                }
                else {
                    n = 1;
                }
                break;
            case 6:
                if (slimeRand > 9) {
                    n = 3;
                }
                else if (slimeRand > 4 && slimeRand <= 9) {
                    n = 2;
                }
                else {
                    n = 1;
                }
                break;
            case 7:
                if (slimeRand > 7) {
                    n = 3;
                }
                else if (slimeRand > 2 && slimeRand <= 7) {
                    n = 2;
                }
                else {
                    n = 1;
                }
                break;
            case 8:
                if (slimeRand > 9) {
                    n = 4;
                }
                else if (slimeRand > 6 && slimeRand <= 9) {
                    n = 3;
                }
                else if (slimeRand > 1 && slimeRand <= 6) {
                    n = 2;
                }
                else {
                    n = 1;
                }
                break;
            case 9:
                if (slimeRand > 8) {
                    n = 4;
                }
                else if (slimeRand > 5 && slimeRand <= 8) {
                    n = 3;
                }
                else if (slimeRand> 1 && slimeRand <= 6) {
                    n = 2;
                }
                else {
                    n = 1;
                }
                break;
            case 10:
                if (slimeRand > 9) {
                    n = 5;
                }
                else if (slimeRand > 6 && slimeRand <= 9) {
                    n = 4;
                }
                else if (slimeRand > 2 && slimeRand <= 6) {
                    n = 3;
                }
                else if (slimeRand == 2) {
                    n = 2;
                }
                else {
                    n = 1;
                }
                break;
            case 11:
                if (slimeRand > 8) {
                    n = 5;
                }
                else if (slimeRand > 5 && slimeRand <= 7) {
                    n = 4;
                }
                else if (slimeRand > 2 && slimeRand <= 5) {
                    n = 3;
                }
                else {
                    n = 2;
                }
                break;
            case 12:
                if (slimeRand > 9) {
                    n = 6;
                }
                else if (slimeRand > 6 && slimeRand <= 9) {
                    n = 5;
                }
                else if (slimeRand > 2 && slimeRand <= 6) {
                    n = 4;
                }
                else if (slimeRand == 2) {
                    n = 3;
                }
                else {
                    n = 2;
                }
                break;
            case 13:
                if (slimeRand > 8) {
                    n = 6;
                }
                else if (slimeRand > 5 && slimeRand <= 7) {
                    n = 5;
                }
                else if (slimeRand > 2 && slimeRand <= 5) {
                    n = 4;
                }
                else {
                    n = 3;
                }
                break;
            case 14:
                if (slimeRand > 9) {
                    n = 7;
                }
                else if (slimeRand > 6 && slimeRand <= 9) {
                    n = 6;
                }
                else if (slimeRand > 2 && slimeRand <= 6) {
                    n = 5;
                }
                else if (slimeRand == 2) {
                    n = 4;
                }
                else {
                    n = 3;
                }
                break;
            case 15:
                if (slimeRand > 8) {
                    n = 7;
                }
                else if (slimeRand > 5 && slimeRand <= 7) {
                    n = 6;
                }
                else if (slimeRand > 2 && slimeRand <= 5) {
                    n = 5;
                }
                else {
                    n = 4;
                }
                break;
            case 16:
                if (slimeRand > 9) {
                    n = 8;
                }
                else if (slimeRand > 6 && slimeRand <= 9) {
                    n = 7;
                }
                else if (slimeRand > 2 && slimeRand <= 6) {
                    n = 6;
                }
                else if (slimeRand == 2) {
                    n = 5;
                }
                else {
                    n = 4;
                }
                break;
        }
        return n;
    }

    //decides the sprite of the slime that is going to spawn
    public void SlimeSprite() {
        switch (slimeSpawn) {
            case 1:
                SlimeImage.GetComponent<Image>().sprite = greenSlime;
                break;
            case 2:
                SlimeImage.GetComponent<Image>().sprite = blueSlime;
                break;
            case 3:
                SlimeImage.GetComponent<Image>().sprite = redSlime;
                break;
            case 4:
                SlimeImage.GetComponent<Image>().sprite = yellowSlime;
                break;
            case 5:
                SlimeImage.GetComponent<Image>().sprite = orangeSlime;
                break;
            case 6:
                SlimeImage.GetComponent<Image>().sprite = purpleSlime;
                break;
            case 7:
                SlimeImage.GetComponent<Image>().sprite = whiteSlime;
                break;
            case 8:
                SlimeImage.GetComponent<Image>().sprite = blackSlime;
                break;
        }
    }

    public int GenerateHp(int j) {
        int x = 10;
        switch (slimeSpawn) {
            case 1:
                x = 10;
                break;
            case 2:
                x = 15;
                break;
            case 3:
                x = 20;
                break;
            case 4:
                x = 40;
                break;
            case 5:
                x = 80;
                break;
            case 6:
                x = 250;
                break;
            case 7:
                x = 350;
                break;
            case 8:
                x = 500;
                break;
        }
        return x;
    }
}