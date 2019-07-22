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

    public int slimeRand;  //used for random choosing of slime

    public static int slimeSpawn; //what slime will be spawned
    public static int typeHp = 10;

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
            GlobalSlime.greenSlimeCount += 1; //increases amount of slime by 1
            GlobalXp.XpCount += 1; //increase xp by 1
            if (GlobalXp.XpCount >= Math.Pow(2, GlobalXp.LevelCount)) { // this is level up stuff
                GlobalXp.LevelCount++;
                GlobalXp.XpCount -= Convert.ToInt32(Math.Pow(2, GlobalXp.LevelCount - 1)); //double to int cause :(
            }

            slimeSpawn = SlimeSpawn(GlobalXp.LevelCount);
            SlimeSprite();
            typeHp = GenerateHp(slimeSpawn);

            SlimeHp = (typeHp * Math.Pow(1.1, GlobalXp.LevelCount - 1));
            TempHp = SlimeHp; //resets slime hp
        }
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
        }
        return x;
    }
}
