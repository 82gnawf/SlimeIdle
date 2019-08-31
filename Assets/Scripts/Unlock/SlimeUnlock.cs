using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeUnlock : MonoBehaviour
{

    public GameObject UOne;
    public GameObject UTwo; 
    public GameObject UThree;
    public GameObject UFour;
    public GameObject UFive;
    public GameObject USix;
    public GameObject USeven;
    public GameObject UEight;

    public GameObject POne;
    public GameObject PTwo; 
    public GameObject PThree;
    public GameObject PFour;
    public GameObject PFive;
    public GameObject PSix;
    public GameObject PSeven;
    public GameObject PEight;

    void Update() {

        if (SlimeUnlockNumber.SlimeSeen > 0) {
            UOne.SetActive(false);
            UTwo.SetActive(true);
            POne.SetActive(true);
        }
        if (SlimeUnlockNumber.SlimeSeen > 1) {
            UTwo.SetActive(false);
            UThree.SetActive(true);
            PTwo.SetActive(true);
        }
        if (SlimeUnlockNumber.SlimeSeen > 2) {
            UThree.SetActive(false);
            UFour.SetActive(true);
            PThree.SetActive(true);
        }
        if (SlimeUnlockNumber.SlimeSeen > 3) {
            UFour.SetActive(false);
            UFive.SetActive(true);
            PFour.SetActive(true);
        }
        if (SlimeUnlockNumber.SlimeSeen > 4) {
            UFive.SetActive(false);
            USix.SetActive(true);
            PFive.SetActive(true);
        }
        if (SlimeUnlockNumber.SlimeSeen > 5) {
            USix.SetActive(false);
            USeven.SetActive(true);
            PSix.SetActive(true);
        }
        if (SlimeUnlockNumber.SlimeSeen > 6) {
            USeven.SetActive(false);
            UEight.SetActive(true);
            PSeven.SetActive(true);
        }
        if (SlimeUnlockNumber.SlimeSeen > 7) {
            UEight.SetActive(false);
            PEight.SetActive(true);
        }
    }

}
