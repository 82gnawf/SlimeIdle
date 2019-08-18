using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSlimeProduction : MonoBehaviour {
    public bool RedHabAutoProduce = false; //bool for auto attack

    void Update() {

        if (RedHabAutoProduce == false) {
            RedHabAutoProduce = true;
            StartCoroutine(ProduceSlime()); //starts IEnumerator DamageSlime()
        }
    }
    IEnumerator ProduceSlime() {

        GlobalSlime.redSlimeCount += RedHabitat.RedHabLevel;
        yield return new WaitForSeconds(10); //waits for (x) seconds
        RedHabAutoProduce = false; //resets the bool
    }



}



