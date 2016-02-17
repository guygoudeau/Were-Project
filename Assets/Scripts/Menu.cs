﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Canvas MainCanvas;
    public Canvas OptionsCanvas;
    public Canvas howToPlay;
    public string level;

    void Awake()
    {
        OptionsCanvas.enabled = false;
        howToPlay.enabled = false;
    }
   
    public void OptionsOn()
    {
        OptionsCanvas.enabled = true;
        MainCanvas.enabled = false;
        howToPlay.enabled = false;
    }

    public void HowtoPlay()
    {
        OptionsCanvas.enabled = false;
        MainCanvas.enabled = false;
        howToPlay.enabled = true;
    }

    public void ReturnOn()
    {
        OptionsCanvas.enabled = false;
        MainCanvas.enabled = true;
        howToPlay.enabled = false;
    }

    public void LoadOn()
    {
        SceneManager.LoadScene(level);
        GameObject.Find("InformationHolder(Clone)").GetComponent<InfoHandler>().timer = 0;
    }
}