using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//kill player
public class KillPlayer : MonoBehaviour
{
    public LevelManager levelManager;


    /// Start this instance.
   
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }


    /// Update this instance.
  
    void Update()
    {

    }


  
    /// Raises the trigger enterd event.

    void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.name == "Player")
        {
            levelManager.RespawnPlayer();
        }
    }
}