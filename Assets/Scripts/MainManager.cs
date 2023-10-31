using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public TextMeshProUGUI user_game;
    public TextMeshProUGUI textBestScore;
    public int bestScore = 0;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
       
        
    }
}
