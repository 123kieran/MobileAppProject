﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScoreMenu : MonoBehaviour
{

    
    public string menu;

 

    // Menu
    public void Menu()
    {
        // Load Menu
        SceneManager.LoadScene(menu);
    }

 

}