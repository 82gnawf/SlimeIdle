using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowSlimeProduction : MonoBehaviour {
    public bool YellowHabAutoProduce = false; //bool for auto attack

    void Update() {

        if (YellowHabAutoProduce == false) {
            YellowHabAutoProduce = true;
            StartCoroutine(ProduceSlime()); //starts IEnumerator DamageSlime()
        }
    }
    IEnumerator ProduceSlime() {

        GlobalSlime.yellowSlimeCount += YellowHabitat.YellowHabLevel;
        yield return new WaitForSeconds(10); //waits for (x) seconds
        YellowHabAutoProduce = false; //resets the bool
    }



}



