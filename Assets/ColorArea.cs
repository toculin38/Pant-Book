using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PolygonCollider2D))]
public class ColorArea : MonoBehaviour {

    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Patlette.NowColor;
    }

}
