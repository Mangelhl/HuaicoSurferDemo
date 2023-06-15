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
    public int VelocidadGeneral = 100;
    private float ValorAnterior = 0;
    public float Tiempo = 2.5f;
    private Moverse move;
   
  

    // Start is called before the first frame update

    private void Awake()
    {
      
    }
    void Start()
    {
        move = FindObjectOfType<Moverse>();
        
    }

    // Update is called once per frame
    void Update()
    {
            tiempoPasado += Time.deltaTime;

            if (tiempoPasado > ValorAnterior)
            {
                Puntuacion = Puntuacion + 1;
                ValorAnterior = ValorAnterior + 1;
            }
            if (tiempoPasado >= cambio)
            {
                cambio = cambio + 33f;
                VelocidadGeneral = VelocidadGeneral + 30;
                move.VelocidadHorizontal = move.VelocidadHorizontal + 3;
                move.velocidadOriniginal = move.velocidadOriniginal + 3;
                Tiempo = Tiempo - 0.2f;
            }
        
    }

   

}
