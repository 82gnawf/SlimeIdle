using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenSlimeProduction : MonoBehaviour
{
    public bool GreenHabAutoProduce = false; //bool for auto attack

    void Update() {

        if (GreenHabAutoProduce == false) {
            GreenHabAutoProduce = true;
            StartCoroutine(ProduceSlime()); //starts IEnumerator DamageSlime()
        }
    }
    IEnumerator ProduceSlime() {

        GlobalSlime.greenSlimeCount ++;
        yield return new WaitForSeconds(10); //waits for (x) seconds
        GreenHabAutoProduce = false; //resets the bool
    }



}
