using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    private bool isPaused = false;

    private void Update()
    {
        // Check if the Esc key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        pauseMenu.SetActive(true); // Show the pause menu
        Time.timeScale = 0f;      // Freeze the game
        isPaused = true;          // Update pause state
    }

    public void Resume()
    {
        pauseMenu.SetActive(false); // Hide the pause menu
        Time.timeScale = 1f;        // Resume the game
        isPaused = false;           // Update pause state
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f; // Ensure the game isn't frozen
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnToMainMenu()
    {
        Time.timeScale = 1f; // Ensure the game isn't frozen
        SceneManager.LoadScene("MainMenu"); // Replace with your actual main menu scene name
    }
}