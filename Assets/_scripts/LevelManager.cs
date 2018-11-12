using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// Level manager.

public class LevelManager : MonoBehaviour
{

 
    /// The current checkpoint.
  
    public GameObject currentCheckpoint;

    
    /// The player.
  
    private PlayerController player;


    /// Start this instance.
   
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
	*/
    public void RespawnPlayer()
    {
        Debug.Log("DEBUG : Player Respawn");
        player.transform.position = currentCheckpoint.transform.position;
    }

}