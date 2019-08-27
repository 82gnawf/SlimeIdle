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
        else if (pageNum == 5) { //num of sellers
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
                unit = "green";
                UnitImage.GetComponent<Image>().sprite = Green;
                sellerLevel = GlobalGreenSeller.SellerLevel;
                sellRate = GlobalGreenSeller.SellerRate;
                break;
            case 2:
                unit = "blue";
                UnitImage.GetComponent<Image>().sprite = Blue;
                sellerLevel = GlobalBlueSeller.SellerLevel;
                sellRate = GlobalBlueSeller.SellerRate;
                break;
            case 3:
                unit = "red";
                UnitImage.GetComponent<Image>().sprite = Red;
                sellerLevel = GlobalRedSeller.SellerLevel;
                sellRate = GlobalRedSeller.SellerRate;
                break;
            case 4:
                unit = "yellow";
                UnitImage.GetComponent<Image>().sprite = Yellow;
                sellerLevel = GlobalYellowSeller.SellerLevel;
                sellRate = GlobalYellowSeller.SellerRate;
                break;
            case 5:
                unit = "orange";
                UnitImage.GetComponent<Image>().sprite = Orange;
                sellerLevel = GlobalOrangeSeller.SellerLevel;
                sellRate = GlobalOrangeSeller.SellerRate;
                break;
        }

        SellerLabel.GetComponent<Text>().text = unit + " Seller";
        Stats.GetComponent<Text>().text = "Sell Amount: " + sellerLevel + " slime \n Sell Rate: every " + sellRate + " sec.";
    }
}
