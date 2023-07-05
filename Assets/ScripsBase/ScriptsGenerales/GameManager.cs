using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public float tiempoPasado = 0;
    private float cambio = 33;
    public int Puntuacion = 0;
    public int Puntciviles = 0;
    public int VelocidadGeneral = 100;
    private float ValorAnterior = 0;
    public float Tiempo = 2.5f;
    private Moverse move;
    private GenerarInstancias GI;
    public CivilSave ML;
    private ScoreManager scoreManager;



    // Start is called before the first frame update

    private void Awake()
    {
      
    }
    void Start()
    {
        ML = FindObjectOfType<CivilSave>();
        move = FindObjectOfType<Moverse>();
        scoreManager = ScoreManager.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
            tiempoPasado += Time.deltaTime;

            if (tiempoPasado > ValorAnterior && ML.NPS == true)
            {
            Puntuacion = Puntuacion + 2;
            ValorAnterior = ValorAnterior + 2;
            }

            if (tiempoPasado > ValorAnterior)

            {
                Puntuacion = Puntuacion + 1;
                ValorAnterior = ValorAnterior + 1;
            }
            if (tiempoPasado >= cambio)
            {
                cambio = cambio + 33f;
                VelocidadGeneral = VelocidadGeneral + 25;
                move.VelocidadHorizontal = move.VelocidadHorizontal + 2;
                move.velocidadOriniginal = move.velocidadOriniginal + 2;
            }

        if (scoreManager != null)
        {
            scoreManager.AddScore(1);
        }

    }

   

}
