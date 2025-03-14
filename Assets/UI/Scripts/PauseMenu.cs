using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu2 : MonoBehaviour
{
    public GameObject pauseMenuUI;  // Pause menu canvas
    public GameObject settingsMenuUI;  // Settings menu canvas (volume settings)
    private bool isPaused = false;

    void Update()
    {
        // Toggle pause on/off when the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    // Function to pause the game
    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);  // Show the pause menu
        settingsMenuUI.SetActive(false);  // Hide the settings menu
        Time.timeScale = 0f;  // Freeze the game
        isPaused = true;
    }

    // Function to resume the game
    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);  // Hide the pause menu
        settingsMenuUI.SetActive(false);  // Hide the settings menu
        Time.timeScale = 1f;  // Unfreeze the game
        isPaused = false;
    }

    // Function to quit the game
    public void QuitGame()
    {
        Time.timeScale = 1f;  // Ensure time resumes
        Application.Quit();
    }

    // Function to go to the main menu (home screen)
    public void GoToHome()
    {
        Time.timeScale = 1f;  // Ensure time resumes
        SceneManager.LoadScene("Main");  // Change this to your main menu scene name
    }

    // Function to open the settings menu (volume settings)
    public void OpenSettings()
    {
        pauseMenuUI.SetActive(false);  // Hide the pause menu
        settingsMenuUI.SetActive(true);  // Show the settings menu
    }

    // Function to go back to the pause menu from the settings menu
    public void BackToPauseMenu()
    {
        settingsMenuUI.SetActive(false);  // Hide the settings menu
        pauseMenuUI.SetActive(true);  // Show the pause menu
    }
}
