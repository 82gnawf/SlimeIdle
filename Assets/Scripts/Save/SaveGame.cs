using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class SaveGame : MonoBehaviour {

    public bool SavingGame = false;

    void Update() {
        if (SavingGame == false) {
            SavingGame = true;
            StartCoroutine(SaveValues()); //starts IEnumerator DamageSlime()
        }
    }

    IEnumerator SaveValues() {

        Save.SavingGame(); //edit stuff to be saved in Save.cs

        yield return new WaitForSeconds(5); //waits for (x) seconds
        SavingGame = false; //resets the bool
    }

}