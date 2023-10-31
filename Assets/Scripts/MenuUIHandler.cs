using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;


public class MenuUIHandler : MonoBehaviour
{
    public TMP_Text Text;
    public TMP_InputField user_inputField;

    public void Start()
    {
        Text.text = "Best Score : " + user_inputField;
    }

    public void setName()
    {
       Text.text = user_inputField.text;
       
       

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

    public static void SetBestScore(int score)
    {
        MainManager.Instance.bestScore = score;
    }

    public static void SetBestName(string name)
    {
        MainManager.Instance.textBestScore.text  = name;        
    }
        
}
