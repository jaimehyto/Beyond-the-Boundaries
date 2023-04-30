using System.Collections;
using System.Collections.Generic;
using Uduino;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchEndToGame : MonoBehaviour
{
    void Awake()
    {
        UduinoManager.Instance.OnDataReceived += OnDataReceived; //Create the Delegate
        UduinoManager.Instance.alwaysRead = true; // This value should be On By Default
    }

    void Start()
    {

    }

    void Update()
    {

    }

    void OnDataReceived(string data, UduinoDevice deviceName)
    {
        if (data == "1")
        {
            SceneManager.LoadScene(1);
        }
    }
}
