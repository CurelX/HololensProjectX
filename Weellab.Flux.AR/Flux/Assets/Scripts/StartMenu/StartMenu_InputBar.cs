using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu_InputBar : MonoBehaviour {

    private bool focused = true;
    private InputField inputField;
    private Text inputText;

    public delegate void SearchSubmitEventHandler(string inputText);
    public static event SearchSubmitEventHandler SearchSubmit;

    private void Start()
    {
        inputField = GetComponent<InputField>();
        inputField.ActivateInputField();
        inputText = inputField.textComponent;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            OnSearchSubmit();            
    }

    private void OnSearchSubmit()
    {
        if (SearchSubmit != null)
            SearchSubmit(inputText.text);
    }

}
