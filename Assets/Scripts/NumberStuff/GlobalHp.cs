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

    public static double SlimeHp = (10 * Math.Pow(1.1, GlobalXp.LevelCount - 1)); //real hp based on level
    public static double TempHp; //honestly don't know if i need this lol
    public int InternalHp;

    public static int slimeSpawn;

    private void Start() {
        TempHp = SlimeHp;
    }



    private void Update() {
        InternalHp = Convert.ToInt32(TempHp); //double to string
        HpDisplay.GetComponent<Text>().text = "Hp: " + InternalHp; //display

        if (LoadGame.spirteInit == false) {
            SlimeSprite();
            LoadGame.spirteInit = true;
        }

        if (TempHp <= 0.5) {
            GlobalSlime.SlimeCount += 1; //increases amount of slime by 1
            GlobalXp.XpCount += 1; //increase xp by 1
            if (GlobalXp.XpCount >= Math.Pow(2, GlobalXp.LevelCount)) { // this is level up stuff
                GlobalXp.LevelCount++;
                GlobalXp.XpCount -= Convert.ToInt32(Math.Pow(2, GlobalXp.LevelCount - 1)); //double to int cause :(
            }

            slimeSpawn = SlimeSpawn(GlobalXp.LevelCount);
            SlimeSprite();

            SlimeHp = (10 * Math.Pow(1.1, GlobalXp.LevelCount - 1));
            TempHp = SlimeHp; //resets slime hp
        }
    }

    private int SlimeSpawn(int i) {

        System.Random random = new System.Random();
        int slimeRand = random.Next(1, 10);
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
                n = 2;
                break;
            case 5:
                n = 3;
                break;
        }
        return n;
    }

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
}
