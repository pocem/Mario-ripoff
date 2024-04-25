using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseActivation : MonoBehaviour
{
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseMenu.GameIsPaused)
            {
                Debug.Log("Resuming");
                pauseMenu.GetComponent<PauseMenu>().Resume();
            }
            else
            {
                Debug.Log("Pausing");
                pauseMenu.GetComponent<PauseMenu>().Pause();
            }
        }
    }
}
