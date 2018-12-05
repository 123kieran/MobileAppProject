using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Kill player.
/// </summary>
public class KillPlayer : MonoBehaviour {
	public LevelManager levelManager;
    private LifeController lifeController;

    /// <summary>
    /// Start this instance.
    /// </summary>
    void Start () {
		levelManager = FindObjectOfType<LevelManager> ();
        lifeController = FindObjectOfType<LifeController>();
    }
	
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {
		
	}


	/// <summary>
	/// Raises the trigger enter2 d event.
	/// </summary>
	void OnTriggerEnter2D(Collider2D collide){
		if (collide.name == "Player") {
			levelManager.RespawnPlayer();
            lifeController.LoseLife();
            collide.GetComponent<AudioSource>().Play();
        }
	}
}

           