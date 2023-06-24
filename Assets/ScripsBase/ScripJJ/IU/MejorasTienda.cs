using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking.Types;
using UnityEngine.UI;
public class MejorasTienda : MonoBehaviour
{
    MonedasLucas ML;
    [SerializeField, Tooltip("Cuanto costara la mejora")] int Costo1, Costo2, Costo3;
   [SerializeField] GameObject[] Botones;
    [SerializeField] float MaximoV = 3;

    private void Awake()
    {
        switch (PlayerPrefs.GetInt("Minfra", 0))
        {
            case 1:
                Botones[0].SetActive(false);
                break;
            case 2:
                Botones[0].SetActive(false);
                Botones[1].SetActive(false);
                break;
            case 3:
                Botones[0].SetActive(false);
                Botones[1].SetActive(false);
                Botones[2].SetActive(false);
                break;
        }
        switch (PlayerPrefs.GetInt("Mambi", 0))
        {
            case 1:
                Botones[6].SetActive(false);
                break;
            case 2:
                Botones[6].SetActive(false);
                Botones[7].SetActive(false);
                break;
            case 3:
                Botones[6].SetActive(false);
                Botones[7].SetActive(false);
                Botones[8].SetActive(false);
                break;
        }
        switch (PlayerPrefs.GetInt("Mprev", 0))
        {
            case 1:
                Botones[3].SetActive(false);
                break;
            case 2:
                Botones[3].SetActive(false);
                Botones[4].SetActive(false);
                break;
            case 3:
                Botones[3].SetActive(false);
                Botones[4].SetActive(false);
                Botones[5].SetActive(false);
                break;
        }

    }
    public Slider sliderInfra, sliderAmbi, sliderPrev;
    private void Start()
    {
        //mejorar el rendimiento del juego
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = -1;

        //testeo
        IniciarSlider();
        //buscarlucas
        ML=FindObjectOfType<MonedasLucas>();
    }
    void Update()
    {
        if (sliderInfra.value == 0)
        {

        }
        Debug.Log("INFRA " + PlayerPrefs.GetInt("Minfra", 0));
        Debug.Log("Ambi" + PlayerPrefs.GetInt("Mambi", 0));
        Debug.Log("Preve" + PlayerPrefs.GetInt("Mprev", 0));
    }
    public void Infraestructura1()
    {
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo1 && PlayerPrefs.GetInt("Minfra", 0) == 0)
        {
            ML.RestarLucas(Costo1);
            PlayerPrefs.SetInt("Minfra", 1);
            Botones[0].SetActive(false);
        }
    }
    public void Infraestructura2()
    { if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo2 && PlayerPrefs.GetInt("Minfra", 0) == 1)
        {
            ML.RestarLucas(Costo2); 
            PlayerPrefs.SetInt("Minfra", 2);
            Botones[1].SetActive(false);
        } }
    public void Infraestructura3() 
    { 
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo3 && PlayerPrefs.GetInt("Minfra", 0) == 2)
        {
            ML.RestarLucas(Costo3);
            PlayerPrefs.SetInt("Minfra", 3);
            Botones[2].SetActive(false);
        }
     }

    public void Ambientación1()
    {
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo1 && PlayerPrefs.GetInt("Mambi", 0) == 0)
        {
            ML.RestarLucas(Costo1);
            PlayerPrefs.SetInt("Mambi", 1);
            Botones[6].SetActive(false);
        } }
    public void Ambientación2() {
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo2 && PlayerPrefs.GetInt("Mambi", 0) == 1)
        {
            ML.RestarLucas(Costo2);
            PlayerPrefs.SetInt("Mambi", 2);
            Botones[7].SetActive(false);
        } }
    public void Ambientación3() { 
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo3 && PlayerPrefs.GetInt("Mambi", 0) == 2)
        {
            ML.RestarLucas(Costo3);
            PlayerPrefs.SetInt("Mambi", 3);
            Botones[8].SetActive(false);
        }
    }
    public void Prevención1()
    {
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo1 && PlayerPrefs.GetInt("Mprev", 0) == 0)
        {
            ML.RestarLucas(Costo1);
            PlayerPrefs.SetInt("Mprev", 1);
            Botones[3].SetActive(false);

        } }
    public void Prevención2()
    {
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo2 && PlayerPrefs.GetInt("Mprev", 0) == 1)
        {
            ML.RestarLucas(Costo2);
            PlayerPrefs.SetInt("Mprev", 2);
            Botones[4].SetActive(false);
        }
    }
    public void Prevención3() {
            
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo3 && PlayerPrefs.GetInt("Mprev", 0) == 2)
        {
            ML.RestarLucas(Costo3);
            PlayerPrefs.SetInt("Mprev", 3);
            Botones[5].SetActive(false);
        }
    }
    private void IniciarSlider()
    {
     /*   sliderInfra = GameObject.FindGameObjectWithTag("SliderInfra").GetComponent<Slider>();
        sliderPrev = GameObject.FindGameObjectWithTag("SliderAmbi").GetComponent<Slider>();
        sliderAmbi = GameObject.FindGameObjectWithTag("SliderPrev").GetComponent<Slider>();*/
        sliderInfra.maxValue = MaximoV;
        sliderAmbi.maxValue = MaximoV;
        sliderPrev.maxValue = MaximoV;
    }
}
