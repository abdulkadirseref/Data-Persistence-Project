using System;
using System.Collections;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public static event Action OnCurrencyUpdated;



    private void Awake()
    {
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


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            OnCurrencyUpdated?.Invoke();
        }
    }
}

