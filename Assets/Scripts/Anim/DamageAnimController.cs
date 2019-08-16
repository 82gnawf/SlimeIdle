using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageAnimController : MonoBehaviour {

    private static DamageAnim DamageText;
    private static GameObject canvas;

    public static void Initialize() {

        canvas = GameObject.Find("Canvas");
        DamageText = Resources.Load<GameObject>("Prefabs/PopupDamageParent").GetComponent<DamageAnim>();
        if (!DamageText) {
            DamageText = Resources.Load<GameObject>("Prefabs/PopupDamageParent").GetComponent<DamageAnim>();
        }
        Debug.Log(DamageText);

    }

    public static void CreateDamageText (string text, Transform location) {
        DamageAnim instance = Instantiate(DamageText);
        instance.transform.SetParent(canvas.transform, false);
        instance.SetText(text);
    }
}
