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

    public GameObject SellSlimePanel;
    public GameObject BuyUnitPanel;
    public GameObject SwordPanel;
    public GameObject ProductionPanel;
    public GameObject PrestigePanel;

    void Update() {

        if (GlobalXp.LevelCount > 1) {
            //SellSlimeButton.GetComponent<Text>().text = "Sell";
            SellSlimeButton.interactable = true;
        }
        if (GlobalXp.LevelCount > 3) {
            // BuyUnitButton.GetComponent<Image>().sprite = BuyUnitsImage;
            BuyUnitButton.interactable = true;
        }
        if (GlobalXp.LevelCount > 4) {
            //SwordButton.GetComponent<Image>().sprite = SwordImage;
            SwordButton.interactable = true;
        }
        if (GlobalXp.LevelCount > 7) {
            //SlimeProductionButton.GetComponent<Image>().sprite = ProductionImage;
            SlimeProductionButton.interactable = true;
        }
        if (GlobalXp.LevelCount > 10) {
            //PrestigeButton.GetComponent<Image>().sprite = PrestigeImage;
            PrestigeButton.interactable = true;
        }

    }

    public void SellOpen() {
        SellSlimePanel.transform.gameObject.SetActive(true);
        BuyUnitPanel.transform.gameObject.SetActive(false);
        SwordPanel.transform.gameObject.SetActive(false);
        ProductionPanel.transform.gameObject.SetActive(false);
        PrestigePanel.transform.gameObject.SetActive(false);
    }

    public void BuyOpen() {
        SellSlimePanel.transform.gameObject.SetActive(false);
        BuyUnitPanel.transform.gameObject.SetActive(true);
        SwordPanel.transform.gameObject.SetActive(false);
        ProductionPanel.transform.gameObject.SetActive(false);
        PrestigePanel.transform.gameObject.SetActive(false);
    }

    public void SwordOpen() {
        SellSlimePanel.transform.gameObject.SetActive(false);
        BuyUnitPanel.transform.gameObject.SetActive(false);
        SwordPanel.transform.gameObject.SetActive(true);
        ProductionPanel.transform.gameObject.SetActive(false);
        PrestigePanel.transform.gameObject.SetActive(false);
    }

    public void ProductionOpen() {
        SellSlimePanel.transform.gameObject.SetActive(false);
        BuyUnitPanel.transform.gameObject.SetActive(false);
        SwordPanel.transform.gameObject.SetActive(false);
        ProductionPanel.transform.gameObject.SetActive(true);
        PrestigePanel.transform.gameObject.SetActive(false);
    }

    public void PrestigeOpen() {
        SellSlimePanel.transform.gameObject.SetActive(false);
        BuyUnitPanel.transform.gameObject.SetActive(false);
        SwordPanel.transform.gameObject.SetActive(false);
        ProductionPanel.transform.gameObject.SetActive(false);
        PrestigePanel.transform.gameObject.SetActive(true);
    }

}
