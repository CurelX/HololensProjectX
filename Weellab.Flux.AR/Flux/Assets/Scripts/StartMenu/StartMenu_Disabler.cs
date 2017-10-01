using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu_Disabler : MonoBehaviour {

    public GameObject inputBar;
    public GameObject[] fadingObjects;

    private void OnEnable()
    {
        StartMenu_InputBar.SearchSubmit += DisableMenu;
    }

    private void OnDisable()
    {
        StartMenu_InputBar.SearchSubmit -= DisableMenu;
    }

    private void DisableMenu(string inputText)
    {
        iTween.MoveTo(inputBar, iTween.Hash("y", StartMenu_Canvas.canvasHeight / 3, "time", 0.5f, "easetype", iTween.EaseType.easeInOutQuad));

        for (int i = 0; i < fadingObjects.Length; i++)
        {
            iTween.FadeTo(fadingObjects[i], iTween.Hash("alpha", 0,"time", 0.5f));
        }
    }
}
