using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public Button LoginButton;
    public InputField NameInputField;

    void Start() {
        LoginButton.onClick.AddListener(delegate () { Login(); });
	}

    void Login()
    {
        string name = NameInputField.text;
        Debug.Log(name);
    }
}
