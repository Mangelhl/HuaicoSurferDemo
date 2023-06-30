using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambio : MonoBehaviour
{
    //variable de número escenario
    [Header("Variable Para CArgar Escena")]
    [SerializeField] private int E;
    public void TrueEscene() 
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(E);
    }
    public void RegresarMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            TrueEscene();
        }
    }
}
