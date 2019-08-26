using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatingDev : MonoBehaviour
{
    public void Money() {
        GlobalMoney.MoneyCount += 100000;
    }

    public void XP () {
        GlobalXp.LevelCount++;
    }
}
