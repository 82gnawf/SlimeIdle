using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalSlime : MonoBehaviour
{
    public GameObject SlimeDisplay;

    public static int SlimeCount;
    public int InternalSlimeCount;

    private void Update() {
        InternalSlimeCount = SlimeCount; 
        SlimeDisplay.GetComponent<Text>().text = "Slime: " + InternalSlimeCount; //display
    }
}
