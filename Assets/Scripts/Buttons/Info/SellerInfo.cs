using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SellerInfo : MonoBehaviour
{
    public int pageNum;
    public string unit;
    public int sellerLevel;
    public float sellRate;
    public string special; //unused for tier I

    public GameObject UnitImage;
    public GameObject SellerLabel;
    public GameObject Stats;

    public Sprite Green;
    public Sprite Blue;
    public Sprite Red;
    public Sprite Yellow;
    public Sprite Orange;

    public Button LeftButton;
    public Button RightButton;

    public void open() {
        pageNum = 1;
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
        else if (pageNum == 5) { // 8 due to number of slimes at tier 1
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
                UnitImage.GetComponent<Image>().sprite = Green;
                break;
            case 2:
                UnitImage.GetComponent<Image>().sprite = Blue;
                break;
            case 3:
                UnitImage.GetComponent<Image>().sprite = Red;
                break;
            case 4:
                UnitImage.GetComponent<Image>().sprite = Yellow;
                break;
            case 5:
                UnitImage.GetComponent<Image>().sprite = Orange;
                break;
        }

        SellerLabel.GetComponent<Text>().text = unit;
        Stats.GetComponent<Text>().text = "Yes" ;
    }
}
