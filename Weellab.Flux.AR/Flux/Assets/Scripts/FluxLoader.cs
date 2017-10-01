using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FluxLoader : MonoBehaviour {

    public Text centerText;

    private void OnEnable()
    {
        StartMenu_InputBar.SearchSubmit += LoadScene;
    }

    private void OnDisable()
    {
        StartMenu_InputBar.SearchSubmit -= LoadScene;
    }

    private void LoadScene(string inputText)
    {
        Object[] objects = Resources.LoadAll(inputText);

        if (objects.Length == 0)
            centerText.text = "No results found.";
        else
            centerText.text = "";

        foreach (Object obj in objects)
        {
            GameObject go = Instantiate(obj, new Vector3(0, -2, 20), Quaternion.identity, transform) as GameObject;
            if(go != null)
                go.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
    }
}
