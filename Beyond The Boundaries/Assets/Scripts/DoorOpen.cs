using System.Collections;
using System.Collections.Generic;
using Uduino;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpen : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;

    private int doorsOpened = 1;

    AudioSource audioSource;

    // @misc{uduino,
    //      Author = {Marc Teyssier},
    //      Title = {{Uduino: Toolkit for Communication between Arduino and Unity .}},
    //      Year = {2018},
    //      Note = {\emph{https://marcteyssier.com/uduino/}}
    // } 

    void Awake()
    {
        //from Uduino

        UduinoManager.Instance.OnDataReceived += OnDataReceived; 
        UduinoManager.Instance.alwaysRead = true; 
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Load exist scene
    void animationEnd()
    {
        SceneManager.LoadScene(2);
    }

    //used in animation events
    void playWalkingAudio()
    {
        audioSource.Play();
    }

    //used in animation events
    void stopWalkingAudio()
    {
        audioSource.Pause();
    }

    //running different animation in sequence, triggered by data received by Arduino
    //"1" from Arduino means tilt sensor is tilted
    void OnDataReceived(string data, UduinoDevice deviceName)
    {
        if(data == "1")
        {
            switch (doorsOpened)
            {
                case 1: doorAnimator.SetTrigger("Open Door");
                    doorsOpened++;
                    break;

                case 2: doorAnimator.SetTrigger("Open Door 2");
                    doorsOpened++;
                    break;

                case 3:
                    doorAnimator.SetTrigger("Open Door 3");
                    doorsOpened++;
                    break;

                case 4:
                    doorAnimator.SetTrigger("Open Door 4");
                    doorsOpened++;
                    break;

                case 5:
                    doorAnimator.SetTrigger("Open Door 5");
                    doorsOpened++;
                    break;

                case 6:
                    doorAnimator.SetTrigger("Open Door 6");
                    doorsOpened++;
                    break;

                case 7:
                    doorAnimator.SetTrigger("Open Door 7");
                    doorsOpened++;
                    break;

                case 8:
                    doorAnimator.SetTrigger("Open Door 8");
                    doorsOpened++;
                    break;

                case 9:
                    doorAnimator.SetTrigger("Open Door 9");
                    doorsOpened++;
                    break;
            }
        }
    }
}
