using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellerUnlock : MonoBehaviour
{

    public GameObject UTwo; //2nd unlock
    public GameObject UThree;
    public GameObject UFour;
    public GameObject UFive;

    public GameObject PTwo; //2nd panel
    public GameObject PThree;
    public GameObject PFour;
    public GameObject PFive;

    void Update() {
        if (GlobalFighter.FighterLevel > 0) {
            UTwo.SetActive(false);
            UThree.SetActive(true);
            PTwo.SetActive(true);
        }
        if (GlobalArcher.ArcherLevel > 0) {
            UThree.SetActive(false);
            UFour.SetActive(true);
            PThree.SetActive(true);
        }
        if (GlobalWarrior.WarriorLevel > 0) {
            UFour.SetActive(false);
            UFive.SetActive(true);
            PFour.SetActive(true);
        }
        if (GlobalKnight.KnightLevel > 0) {
            UFive.SetActive(false);
            PFive.SetActive(true);
        }
    }

}
