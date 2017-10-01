using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu_Canvas : MonoBehaviour {

    public static float canvasWidth;
    public static float canvasHeight;

    private void OnEnable()
    {
        canvasWidth = GetComponent<RectTransform>().rect.width;
        canvasHeight = GetComponent<RectTransform>().rect.height;
    }

    private void OnDisable()
    {
        canvasHeight = 0;
        canvasWidth = 0;
    }
}
