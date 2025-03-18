using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This script handles checking if the OnRails player collides with an obstacle.
 */
public class NewBehaviourScript : MonoBehaviour
{
    private int countDown;
    private bool isDead;
    private void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {

        }
    }

    void GameOver()
    {

    }
}
