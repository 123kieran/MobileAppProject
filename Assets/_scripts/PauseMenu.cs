﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    
    public string selectMainMenu;
    public bool isPaused;

    // Canvas containing Pause menu UI
    public GameObject pauseMenuCanvas;



    // Update is called once per frame
    void Update()
    {
        // if pause menu selected display canvas and stop time
        if (isPaused)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;

        }

        // Reverse isPaused with escape button
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
    }
    public void Continue()
    {
        isPaused = false;
    }
 
    public void ReturnMainMenu()
    {
        SceneManager.LoadScene(selectMainMenu);

    }

}
