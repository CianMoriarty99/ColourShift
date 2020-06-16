using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool paused = false;
    public GameObject pauseMenu;
    public GameObject menuIcon;

    public Scene mainMenu;

    void Update()
    {
        if (FindObjectOfType<GameManager>().gameHasEnded == false) {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        menuIcon.SetActive(true);
        Time.timeScale = 1f;
        paused = false;
    }

    public void Pause() 
    {
        pauseMenu.SetActive(true);
        menuIcon.SetActive(false);
        Time.timeScale = 0f;
        paused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }





}
