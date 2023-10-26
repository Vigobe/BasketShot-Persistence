using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI user_name;
    public TMP_InputField user_inputField;

    public void setName()
    {
        user_name.text = "Welcome  " + user_inputField.text;

    }

      public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        #if UNITY_EDITOR
             EditorApplication.ExitPlaymode();
        #else
            Application.Quit(); // original code to quit Unity player
        #endif
    }
   
}
