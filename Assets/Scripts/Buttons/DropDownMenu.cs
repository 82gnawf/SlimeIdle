using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownMenu : MonoBehaviour
{

    public Dropdown BuyUnits;
    public GameObject buyUnitsFighterPanel;
    public GameObject buyUnitsSellerPanel;
    public int activePanel = 0;

    public void ChangePanelBuyUnits(){
        switch (BuyUnits.value) {
            case 0:
                DeactivatePanel(activePanel);
                buyUnitsFighterPanel.transform.gameObject.SetActive(true);
                activePanel = 0;
                break;
            case 1:
                DeactivatePanel(activePanel);
                buyUnitsSellerPanel.transform.gameObject.SetActive(true);
                activePanel = 1;
                break;
        }

    }

    public void DeactivatePanel(int i) {
        switch(i) {
            case 0:
                buyUnitsFighterPanel.transform.gameObject.SetActive(false);
                break;
            case 1:
                buyUnitsSellerPanel.transform.gameObject.SetActive(false);
                break;
        }
    }
}
