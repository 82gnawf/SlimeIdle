using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageAnimController : MonoBehaviour {

    private static DamageAnim DamageText;
    private static GameObject canvas;
    public static GameObject SlimeImage;

    public static Vector2 createAnim;
    public static float posX;
    public static float posY;
    public static float ImageX;
    public static float ImageY;

    public static void Initialize() {

        canvas = GameObject.Find("Canvas");
        DamageText = Resources.Load<GameObject>("Prefabs/DamageTextParent").GetComponentInChildren<DamageAnim>();
        SlimeImage = GameObject.Find("SlimeImage");
    }

    public static void CreateDamageText (string text, Transform location) {
        ImageX = SlimeImage.transform.position.x;
        ImageY = SlimeImage.transform.position.y;
        posX = Random.Range(ImageX - 40.0f, ImageX + 40.0f);
        posY = Random.Range(ImageY - 12.0f, ImageY + 24.0f);
        DamageAnim instance = Instantiate(DamageText);
        createAnim = new Vector2(posX, posY);
        instance.transform.SetParent(canvas.transform, false);
        instance.transform.position = createAnim;
        instance.SetText(text);
    }
}
