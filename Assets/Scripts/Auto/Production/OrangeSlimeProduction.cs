using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeSlimeProduction : MonoBehaviour {
    public bool OrangeHabAutoProduce = false; //bool for auto attack

    void Update() {

        if (OrangeHabAutoProduce == false) {
            OrangeHabAutoProduce = true;
            StartCoroutine(ProduceSlime()); //starts IEnumerator DamageSlime()
        }
    }
    IEnumerator ProduceSlime() {

        GlobalSlime.orangeSlimeCount += OrangeHabitat.OrangeHabLevel;
        yield return new WaitForSeconds(10); //waits for (x) seconds
        OrangeHabAutoProduce = false; //resets the bool
    }



}
