using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;


public class pause_menu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseUI;
    public GameObject PauseUI2;
    public GameObject PauseUI3;
    public GameObject PauseUI4;



    void Resume()
    {
    PauseUI.SetActive(false);
    PauseUI2.SetActive(false);
    PauseUI3.SetActive(false);
    PauseUI4.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
    PauseUI.SetActive(true);
    PauseUI2.SetActive(true);
    PauseUI3.SetActive(true);
    PauseUI4.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
        private void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }
}
