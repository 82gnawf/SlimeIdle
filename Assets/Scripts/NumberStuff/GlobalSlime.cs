using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalSlime : MonoBehaviour
{
    public GameObject SlimeDisplay;

    public static int greenSlimeCount;
    public int InternalgreenSlimeCount;

    private void Update() {
        InternalgreenSlimeCount = greenSlimeCount; 
        SlimeDisplay.GetComponent<Text>().text = "X " + InternalgreenSlimeCount; //display
    }
}
