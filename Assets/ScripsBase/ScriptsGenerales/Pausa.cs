using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    private bool espausa;
    [SerializeField] private AudioSource AudioManager;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            granpausa();
            detenermusica();
            Debug.Log ("hola");
        }
    }
    private void granpausa()
    {
        espausa = !espausa;
        if (espausa)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
    private void detenermusica()
    {
        
        if (espausa)
        {
            AudioManager.Pause();
        }
        else
        {
            AudioManager.UnPause();
        }
    }
}