using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageAnim : MonoBehaviour {

    public Animator animator;
    private Text damageText;

    void OnEnable() {

        AnimatorClipInfo[] clipInfo = animator.GetCurrentAnimatorClipInfo(0);
        Debug.Log(clipInfo.Length);
        Destroy(gameObject, clipInfo[0].clip.length);
        damageText = GetComponent<Text>();

    }

    public void SetText(string text) {

        animator.GetComponent<Text>().text = "-" + text;

    }

}
