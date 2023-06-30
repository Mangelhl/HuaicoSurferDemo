using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class CanvasTexto : MonoBehaviour
{
    public static CanvasTexto CT;
    public TextMeshProUGUI EscenaGame;
    public TextMeshProUGUI EscenaMuerte;
    public TextMeshProUGUI Moneditas;
    public GameManager GM;
    public int PuntajeInGame;
    public int PuntajeMasAlto;
    public int PuntajeAnterior;
    
   
    // Start is called before the first frame update
    private void Awake()
    {
        if(CanvasTexto.CT == null)
        {
            CanvasTexto.CT = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if(CanvasTexto.CT != this)
        {
            Destroy(gameObject);
        }
        PuntajeMasAlto = PlayerPrefs.GetInt("PuntajeMasAlto", PuntajeAnterior);
    }
    private void Start()
    {
        
        PuntajeInGame = 0;
    }

    void Update()
    {
      

        GM = FindObjectOfType<GameManager>();
      
        EscenaGame = FindObjectOfType<TextMeshProUGUI>();
        EscenaMuerte = FindObjectOfType<TextMeshProUGUI>();
        GameObject objetoMonedas = GameObject.Find("Monedas");
      

        Scene escenaActual = SceneManager.GetActiveScene();
        if (escenaActual.buildIndex == 2)
        {
            PuntajeAnterior = PuntajeInGame;
            if (PuntajeMasAlto < PuntajeAnterior)
            {
                PuntajeMasAlto = PuntajeAnterior;
                PlayerPrefs.SetInt("PuntajeMasAlto", PuntajeMasAlto);
                PlayerPrefs.Save();
            }
            else
            {
                PuntajeMasAlto = PuntajeMasAlto;
            }
        }
        if (escenaActual.buildIndex == 1)
        {
            PuntajeInGame = GM.Puntuacion;
            EscenaGame.text = PuntajeInGame.ToString();
        }
        else if (escenaActual.buildIndex == 2 )
        {
           
            EscenaMuerte.text = PuntajeInGame.ToString();
        }
        
        /*
        Moneditas.text = monedas.ToString();*/
    }
}
