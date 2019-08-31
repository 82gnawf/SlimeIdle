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

    //yellow 
    public GameObject YellowSlimeDisplay;

    public static int yellowSlimeCount;
    public int internalYellowSlimeCount;

    //orange 
    public GameObject OrangeSlimeDisplay;

    public static int orangeSlimeCount;
    public int internalOrangeSlimeCount;

    //purple 
    public GameObject PurpleSlimeDisplay;

    public static int purpleSlimeCount;
    public int internalPurpleSlimeCount;

    //white 
    public GameObject WhiteSlimeDisplay;

    public static int whiteSlimeCount;
    public int internalWhiteSlimeCount;

    //black 
    public GameObject BlackSlimeDisplay;

    public static int blackSlimeCount;
    public int internalBlackSlimeCount;


    private void Update() {
        internalGreenSlimeCount = greenSlimeCount;
        GreenSlimeDisplay.GetComponent<Text>().text = "X " + internalGreenSlimeCount;
        internalBlueSlimeCount = blueSlimeCount;
        BlueSlimeDisplay.GetComponent<Text>().text = "X " + internalBlueSlimeCount;
        internalRedSlimeCount = redSlimeCount;
        RedSlimeDisplay.GetComponent<Text>().text = "X " + internalRedSlimeCount;
        internalYellowSlimeCount = yellowSlimeCount;
        YellowSlimeDisplay.GetComponent<Text>().text = "X " + internalYellowSlimeCount;
        internalOrangeSlimeCount = orangeSlimeCount;
        OrangeSlimeDisplay.GetComponent<Text>().text = "X " + internalOrangeSlimeCount;
        internalPurpleSlimeCount = purpleSlimeCount;
        PurpleSlimeDisplay.GetComponent<Text>().text = "X " + internalPurpleSlimeCount;
        internalWhiteSlimeCount = whiteSlimeCount;
        WhiteSlimeDisplay.GetComponent<Text>().text = "X " + internalWhiteSlimeCount;
        internalBlackSlimeCount = blackSlimeCount;
        BlackSlimeDisplay.GetComponent<Text>().text = "X " + internalBlackSlimeCount;
    }




}
