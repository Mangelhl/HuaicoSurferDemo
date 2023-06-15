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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            TrueEscene();
        }
    }
}
