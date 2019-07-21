using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LowerButtonPanelInit : MonoBehaviour
{

    public Button SellSlimeButton;
    public Button BuyUnitButton;
    public Button SwordButton;
    public Button SlimeProductionButton;
    public Button PrestigeButton;

    public Sprite SellImage;
    public Sprite BuyUnitsImage;
    public Sprite SwordImage;
    public Sprite ProductionImage;
    public Sprite PrestigeImage;

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
        if (GlobalXp.LevelCount > 4) {
            SwordButton.GetComponent<Image>().sprite = SwordImage;
            SwordButton.interactable = true;
        }
        if (GlobalXp.LevelCount > 7) {
            SlimeProductionButton.GetComponent<Image>().sprite = ProductionImage;
            SlimeProductionButton.interactable = true;
        }
        if (GlobalXp.LevelCount > 10) {
            PrestigeButton.GetComponent<Image>().sprite = PrestigeImage;
            PrestigeButton.interactable = true;
        }

    }
}
