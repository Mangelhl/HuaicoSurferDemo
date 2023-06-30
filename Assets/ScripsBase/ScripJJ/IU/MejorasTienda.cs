using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MejorasTienda : MonoBehaviour
{
    MonedasLucas ML;
    [SerializeField, Tooltip("Cuanto costara la mejora")] int Costo1, Costo2, Costo3;
   [SerializeField] GameObject[] Botones;
    [SerializeField]Button[] Boton;
    [SerializeField] float MaximoV = 3;
    public Slider sliderInfra, sliderAmbi, sliderPrev;
    private void Awake()
    {
        ML = FindObjectOfType<MonedasLucas>();
        switch (PlayerPrefs.GetInt("Infra", 0)) {
            case 1:
                ML.RestarLucas(0);
                Boton[0].enabled=false;
                Botones[9].SetActive(true);
                break;
            case 2:
                ML.RestarLucas(0);
                Boton[0].enabled = false;
                Botones[9].SetActive(true);
                Boton[1].enabled = false;
                Botones[10].SetActive(true);
                break;
            case 3:
                ML.RestarLucas(0);
                Boton[0].enabled = false;
                Botones[9].SetActive(true);
                Boton[1].enabled = false;
                Botones[10].SetActive(true);
                Boton[2].enabled = false;
                Botones[11].SetActive(true);
                break;
        }
        switch (PlayerPrefs.GetInt("Prev", 0))
        {
            case 1:
                ML.RestarLucas(0);
                Boton[3].enabled = false;
                Botones[12].SetActive(true);
                break;
            case 2:
                ML.RestarLucas(0);
                Boton[3].enabled = false;
                Botones[12].SetActive(true);
                Boton[4].enabled = false;
                Botones[13].SetActive(true);
                break;
            case 3:
                ML.RestarLucas(0);
                Boton[3].enabled = false;
                Botones[12].SetActive(true);
                Boton[4].enabled = false;
                Botones[13].SetActive(true);
                Boton[5].enabled = false;
                Botones[14].SetActive(true);
                break;
        }
        switch (PlayerPrefs.GetInt("Ambi", 0))
        {
            case 1:
                ML.RestarLucas(0);
                Boton[6].enabled = false;
                Botones[15].SetActive(true);
                break;
            case 2:
                ML.RestarLucas(0);
                Boton[7].enabled = false;
                Boton[6].enabled = false;
                Botones[15].SetActive(true);
                Botones[16].SetActive(true);
                break;
            case 3:
                ML.RestarLucas(0);
                Boton[7].enabled = false;
                Boton[6].enabled = false;
                Botones[15].SetActive(true);
                Botones[16].SetActive(true);
                Boton[8].enabled = false;
                Botones[17].SetActive(true);
                break;
        }

    }
    void Update()
    {
        Debug.Log("INFRA"+ PlayerPrefs.GetInt("Infra", 0));
        Debug.Log("Ambi" + PlayerPrefs.GetInt("Ambi", 0));
        Debug.Log("Preve" + PlayerPrefs.GetInt("Prev", 0));
    }
    public void Infraestructura1()
    {
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo1 && PlayerPrefs.GetInt("Infra", 0) == 0)
        {
            ML.RestarLucas(Costo1);
            PlayerPrefs.SetInt("Infra", PlayerPrefs.GetInt("Infra", 0) + 1);
            Boton[0].enabled = false; Botones[0].SetActive(true);
        }
    }
    public void Infraestructura2()
    { if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo2 && PlayerPrefs.GetInt("Infra", 0) == 1)
        {
            ML.RestarLucas(Costo2);
            PlayerPrefs.SetInt("Infra", PlayerPrefs.GetInt("Infra", 0) + 1);
            Boton[1].enabled = false; Botones[10].SetActive(true);
        } }
    public void Infraestructura3() 
    { 
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo3 && PlayerPrefs.GetInt("Infra", 0) == 2)
        {
            ML.RestarLucas(Costo3);
            PlayerPrefs.SetInt("Infra", PlayerPrefs.GetInt("Infra", 0) + 1);
            Boton[2].enabled = false; Botones[11].SetActive(true);
        }
     }

    public void Ambientación1()
    {
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo1 && PlayerPrefs.GetInt("Ambi", 0) == 0)
        {
            ML.RestarLucas(Costo1);
            PlayerPrefs.SetInt("Ambi", PlayerPrefs.GetInt("Ambi", 0) + 1);
            Boton[6].enabled = false;  Botones[15].SetActive(true);
        } }
    public void Ambientación2() {
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo2 && PlayerPrefs.GetInt("Ambi", 0) == 1)
        {
            ML.RestarLucas(Costo2);
            PlayerPrefs.SetInt("Ambi", PlayerPrefs.GetInt("Ambi", 0) + 1);
            Boton[7].enabled = false;  Botones[16].SetActive(true);
        } }
    public void Ambientación3() { 
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo3 && PlayerPrefs.GetInt("Ambi", 0) == 2)
        {
            ML.RestarLucas(Costo3);
            PlayerPrefs.SetInt("Ambi", PlayerPrefs.GetInt("Ambi", 0) + 1);
            Boton[8].enabled = false;  Botones[17].SetActive(true);
        }
    }
    public void Prevención1()
    {
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo1 && PlayerPrefs.GetInt("Prev", 0) == 0)
        {
            ML.RestarLucas(Costo1);
            PlayerPrefs.SetInt("Prev", PlayerPrefs.GetInt("Prev", 0) + 1);
            Boton[3].enabled = false; Botones[12].SetActive(true);

        } }
    public void Prevención2()
    {
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo2 && PlayerPrefs.GetInt("Prev", 0) == 1)
        {
            ML.RestarLucas(Costo2);
            PlayerPrefs.SetInt("Prev", PlayerPrefs.GetInt("Prev", 0) + 1);
            Boton[4].enabled = false; Botones[13].SetActive(true);
        }
    }
    public void Prevención3() {
            
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo3 && PlayerPrefs.GetInt("Prev", 0) == 2)
        {
            ML.RestarLucas(Costo3);

            PlayerPrefs.SetInt("Prev", PlayerPrefs.GetInt("Prev", 0) + 1);
            Boton[5].enabled = false; Botones[14].SetActive(true);
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
