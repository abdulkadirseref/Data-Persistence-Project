using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{

    public TextMeshProUGUI playerText;

    public TextMeshProUGUI highestScoreText;

    public string playerName;

    public string highestScoreName;

    public static MainMenu Instance;

    MainManager mainManager;


    private void Awake()
    {

        mainManager = FindObjectOfType<MainManager>();

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        highestScoreText.text = "Best Score : " + PlayerPrefs.GetString("HighestScoreName") + " : " + PlayerPrefs.GetInt("HighestScore", 0).ToString();

    }


    public void StartButton()
    {
        playerName = playerText.text;

        SceneManager.LoadScene(1);
    }
}
