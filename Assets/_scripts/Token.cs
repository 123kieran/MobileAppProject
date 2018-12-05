using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : MonoBehaviour {

    public int pointsToAdd;
    public AudioSource tokenSoundEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // only allow player pickup tokens
        if (other.GetComponent<PlayerController>() == null)
            return;

        ScoreManager.AddPoints(pointsToAdd);
        tokenSoundEffect.Play();
        // remove point object
        Destroy(gameObject);
    }
    
}
