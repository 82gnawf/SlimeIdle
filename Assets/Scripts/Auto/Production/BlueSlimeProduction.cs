using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSlimeProduction : MonoBehaviour {
    public bool BlueHabAutoProduce = false; //bool for auto attack

    void Update() {

        if (BlueHabAutoProduce == false) {
            BlueHabAutoProduce = true;
            StartCoroutine(ProduceSlime()); //starts IEnumerator DamageSlime()
        }
    }
    IEnumerator ProduceSlime() {

        GlobalSlime.blueSlimeCount += BlueHabitat.BlueHabLevel;
        yield return new WaitForSeconds(10); //waits for (x) seconds
        BlueHabAutoProduce = false; //resets the bool
    }



}



