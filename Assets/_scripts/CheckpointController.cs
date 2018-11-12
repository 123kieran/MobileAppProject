using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// Checkpoint controller.

public class CheckpointController : MonoBehaviour
{
    public LevelManager levelManager;

   
    /// Start this instance.
  
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }


    // Update is called once per frame
    void Update()
    {

    }

  
    /// Raises the trigger enter2 d event.
 
    void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.name == "Player")
        {
            levelManager.currentCheckpoint = gameObject;
            Debug.Log("DEBUG : CheckPoint " + transform.position);
        }
    }
}