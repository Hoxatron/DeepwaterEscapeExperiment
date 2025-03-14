using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToPauseMenu : MonoBehaviour
{
    public GameObject PauseManager;      // Reference to the Pause Menu canvas
    public GameObject settingsMenuUI;   // Reference to the Settings Menu canvas

    // Function to go back to the Pause Menu from Settings Menu
    public void GoBackToPauseMenu()
    {
        settingsMenuUI.SetActive(false);   // Hide the Settings Menu
        PauseManager.SetActive(true);       // Show the Pause Menu
    }
}

