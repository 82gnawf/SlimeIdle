using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeUnlockNumber : MonoBehaviour
{

    public static int SlimeSeen = 0;

    void Update() {
        if (SlimeSeen == 0 && GlobalSlime.greenSlimeCount > 0) {
            SlimeSeen++;
        }
        if (SlimeSeen == 1 && GlobalSlime.blueSlimeCount > 0) {
            SlimeSeen++;
        }
        if (SlimeSeen == 2 && GlobalSlime.redSlimeCount > 0) {
            SlimeSeen++;
        }
        if (SlimeSeen == 3 && GlobalSlime.yellowSlimeCount > 0) {
            SlimeSeen++;
        }
        if (SlimeSeen == 4 && GlobalSlime.orangeSlimeCount > 0) {
            SlimeSeen++;
        }
        if (SlimeSeen == 5 && GlobalSlime.purpleSlimeCount > 0) {
            SlimeSeen++;
        }
        if (SlimeSeen == 6 && GlobalSlime.whiteSlimeCount > 0) {
            SlimeSeen++;
        }
        if (SlimeSeen == 7 && GlobalSlime.blackSlimeCount > 0) {
            SlimeSeen++;
        }
    }
}
