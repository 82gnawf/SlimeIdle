using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlimeInfo : MonoBehaviour
{
    public int pageNum;
    public string color;
    public int hp;
    public int rate;
    public int critRate;
    public string special; //unused for tier I

    public GameObject SlimeImage;
    public GameObject SlimeLabel;
    public GameObject Stats;

    public Sprite greenSlime;
    public Sprite blueSlime;
    public Sprite redSlime;
    public Sprite yellowSlime;
    public Sprite orangeSlime;
    public Sprite purpleSlime;
    public Sprite whiteSlime;
    public Sprite blackSlime;

    public Button LeftButton;
    public Button RightButton;

    public void open() {
        pageNum = 1;
        LeftButton.interactable = false;
    }

    public void left() {
        pageNum--;
    }

    public void right() {
        pageNum++;
    }

    public void checkInteractable() {
        if (pageNum == 1) {
            LeftButton.interactable = false;
        }
        else if (pageNum == 8) {
            RightButton.interactable = false;
        }
        else {
            LeftButton.interactable = true;
            RightButton.interactable = true;
        }
    }

    public void checkPage() {
        switch(pageNum) {
            case 1:
                SlimeImage.GetComponent<Image>().sprite = greenSlime;
                color = "Green";
                hp = GlobalHp.GenerateHp(pageNum);
                rate = GlobalHp.dodgeCheck(pageNum);
                critRate = GlobalHp.critDodgeCheck(pageNum);
                break;
            case 2:
                SlimeImage.GetComponent<Image>().sprite = blueSlime;
                color = "Blue";
                hp = GlobalHp.GenerateHp(pageNum);
                rate = GlobalHp.dodgeCheck(pageNum);
                critRate = GlobalHp.critDodgeCheck(pageNum);
                break;
            case 3:
                SlimeImage.GetComponent<Image>().sprite = redSlime;
                color = "Red";
                hp = GlobalHp.GenerateHp(pageNum);
                rate = GlobalHp.dodgeCheck(pageNum);
                critRate = GlobalHp.critDodgeCheck(pageNum);
                break;
            case 4:
                SlimeImage.GetComponent<Image>().sprite = yellowSlime;
                color = "Yellow";
                hp = GlobalHp.GenerateHp(pageNum);
                rate = GlobalHp.dodgeCheck(pageNum);
                critRate = GlobalHp.critDodgeCheck(pageNum);
                break;
            case 5:
                SlimeImage.GetComponent<Image>().sprite = orangeSlime;
                color = "Orange";
                hp = GlobalHp.GenerateHp(pageNum);
                rate = GlobalHp.dodgeCheck(pageNum);
                critRate = GlobalHp.critDodgeCheck(pageNum);
                break;
            case 6:
                SlimeImage.GetComponent<Image>().sprite = purpleSlime;
                color = "Purple";
                hp = GlobalHp.GenerateHp(pageNum);
                rate = GlobalHp.dodgeCheck(pageNum);
                critRate = GlobalHp.critDodgeCheck(pageNum);
                break;
            case 7:
                SlimeImage.GetComponent<Image>().sprite = whiteSlime;
                color = "White";
                hp = GlobalHp.GenerateHp(pageNum);
                rate = GlobalHp.dodgeCheck(pageNum);
                critRate = GlobalHp.critDodgeCheck(pageNum);
                break;
            case 8:
                SlimeImage.GetComponent<Image>().sprite = blackSlime;
                color = "Black";
                hp = GlobalHp.GenerateHp(pageNum);
                rate = GlobalHp.dodgeCheck(pageNum);
                critRate = GlobalHp.critDodgeCheck(pageNum);
                break;
        }

        SlimeLabel.GetComponent<Text>().text = color + " Slime";
        Stats.GetComponent<Text>().text = "Base Health: " + hp + "\n Dodge Rate: " + rate + "%\n Crit. Dodge Rate: " + critRate + "%";
    }
}
