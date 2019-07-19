using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LowerButtonPanelInit : MonoBehaviour
{

    public Button SellSlimeButton;
    public Button BuyUnitButton;


    public Sprite SellImage;
    public Sprite BuyUnitsImage;

    void Update()
    {
        if (GlobalXp.LevelCount > 1) {
            SellSlimeButton.GetComponent<Image>().sprite = SellImage;
            SellSlimeButton.interactable = true;
        }
        if (GlobalXp.LevelCount > 3) {
            BuyUnitButton.GetComponent<Image>().sprite = BuyUnitsImage;
            BuyUnitButton.interactable = true;
        }
    }
}
