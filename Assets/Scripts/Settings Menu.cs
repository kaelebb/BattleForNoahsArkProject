using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class SettingsMenu : MonoBehaviour
{

    public GameObject SettingsPopUpUI;
    public bool isOpen;

    void Start()
    {
        isOpen = false;

    }

    void Update()
    {
 
        if (Input.GetKeyDown(KeyCode.Escape) && !isOpen)
        {
 
			Debug.Log("ESC is pressed");
            SettingsPopUpUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            isOpen = true;
 
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isOpen)
        {
            SettingsPopUpUI.SetActive(false);
            isOpen = false;
        }
    }
}


