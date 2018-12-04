using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifeController : MonoBehaviour {

    public int initialLives = 3;
    private int lifeCounter;
    private Text lifeText;


    // stop player
    public PlayerController player;

    public string mainMenu;
    public float delayContinue;

	// Use this for initialization
	void Start () {
        lifeText = GetComponent<Text>();
        lifeCounter = initialLives;
        player = FindObjectOfType<PlayerController>();

	}
	
	// Update is called once per frame
	void Update () {
        if (lifeCounter == 0)
        {
            SceneManager.LoadScene(mainMenu);
        }
        lifeText.text = "x " + lifeCounter;

    
        if (delayContinue < 0)
        {
            SceneManager.LoadScene(mainMenu);
        }
	}


    // Remove a life
    public void LoseLife()
    {
        lifeCounter--;
        PlayerPrefs.SetInt("CurrentPlayerLives", lifeCounter);
    }
}
