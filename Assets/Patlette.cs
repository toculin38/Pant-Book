using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Patlette : MonoBehaviour {
    public static Color NowColor = Color.white;
    // Use this for initialization
    public void OnColorClick(Image image) {
        NowColor = image.color;
    }
}
