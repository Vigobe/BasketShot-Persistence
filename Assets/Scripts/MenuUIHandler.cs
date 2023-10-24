using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuUIHandler : MonoBehaviour
{
    public InputField inputText;
    public Text textName;

    
    public void StartNew()
    {
        //PlayerPrefs.SetString("nombre", inputText.text);
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
