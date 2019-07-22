using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalSlime : MonoBehaviour
{
    //green 
    public GameObject GreenSlimeDisplay;

    public static int greenSlimeCount;
    public int internalGreenSlimeCount;

    //blue 
    public GameObject BlueSlimeDisplay;

    public static int blueSlimeCount;
    public int internalBlueSlimeCount;

    //red 
    public GameObject RedSlimeDisplay;

    public static int redSlimeCount;
    public int internalRedSlimeCount;

    private void Update() {
        internalGreenSlimeCount = greenSlimeCount;
        GreenSlimeDisplay.GetComponent<Text>().text = "X " + internalGreenSlimeCount;
        internalBlueSlimeCount = blueSlimeCount;
        BlueSlimeDisplay.GetComponent<Text>().text = "X " + internalBlueSlimeCount;
        internalRedSlimeCount = redSlimeCount;
        RedSlimeDisplay.GetComponent<Text>().text = "X " + internalRedSlimeCount;
    }




}
