using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject camLinker;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
                
            }
            else
            {
                Paused();
                
            }
        }
    
    }

    /*Pause and Resume
    Resume is on public so it can be easily linked to button as well
    Paused only happens when you press Esc so it doesn't matter lmao
    
    Since the mouse is tied to the camera, CamLinker's job is to unbind the mouse to camera movement
    this should let it work in the pause menus
        

    */

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        //camLinker.GetComponent<Cinemachine>().enabled = true;
        camLinker.SetActive(true);        
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Paused()
    {
        pauseMenuUI.SetActive(true);
        //camLinker.GetComponent<MouseLook>().enabled = false;
        camLinker.SetActive(false);
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void ExitMap()
    {
        Debug.Log("Application closed");
    }

}
