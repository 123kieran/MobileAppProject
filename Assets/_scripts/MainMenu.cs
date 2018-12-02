using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public string beginLevel;
    

    // New Game
    public void NewGame()
    {
        // Load first level
        SceneManager.LoadScene(beginLevel);
    }
 
    // exit Game
    public void ExitGame()
    {
        // Quit Game
        //SceneManager.LoadScene(beginLevel);
        Application.Quit();
        Debug.Log("User has exited game");
    }

}
