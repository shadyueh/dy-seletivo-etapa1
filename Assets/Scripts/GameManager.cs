﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public void LoadLevel(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void CloseApp()
    {
        Application.Quit();
    }
}
