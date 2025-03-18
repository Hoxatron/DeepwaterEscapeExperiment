using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This script handles checking if the OnRails player collides with an obstacle.
 */
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {

        }
    }
}
