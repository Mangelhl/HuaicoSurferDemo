using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuPause : MonoBehaviour
{
    [SerializeField] private GameObject buttonMenuPause;

    private bool gamePaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
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
        gamePaused = true;
        Time.timeScale = 0f;
        Debug.Log("pausa");
        buttonMenuPause.SetActive(true);
    }
    public void Resume()
    {
        gamePaused = false;
        Time.timeScale = 1f;
        Debug.Log("reanudar");
        buttonMenuPause.SetActive(false);
    }
}

