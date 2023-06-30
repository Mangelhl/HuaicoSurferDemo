using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MejorasTienda : MonoBehaviour
{
    MonedasLucas ML;
    static int Infra, Ambi, Prev;
    [SerializeField, Tooltip("Cuanto costara la mejora")] int Costo1, Costo2, Costo3;
   [SerializeField] GameObject[] Botones;
    [SerializeField] float MaximoV = 3;
    public Slider sliderInfra, sliderAmbi, sliderPrev;
    private void Start()
    {
        IniciarSlider();
        ML=FindObjectOfType<MonedasLucas>();
    }
    void Update()
    {
        if (sliderInfra.value == 0)
        {

        }
        Debug.Log("INFRA"+Infra);
        Debug.Log("Ambi" + Ambi);
        Debug.Log("Preve" + Prev);
    }
    public void Infraestructura1()
    {
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo1 && Infra == 0)
        {
            ML.RestarLucas(Costo1);
            Infra += 1;
            Botones[0].SetActive(false);
        }
    }
    public void Infraestructura2()
    { if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo2 && Infra == 1)
        {
            ML.RestarLucas(Costo2);
            Infra += 1;
            Botones[1].SetActive(false);
        } }
    public void Infraestructura3() 
    { 
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo3 && Infra == 2)
        {
            ML.RestarLucas(Costo3);
            Infra += 1;
            Botones[2].SetActive(false);
        }
     }

    public void Ambientación1()
    {
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo1 && Ambi == 0)
        {
            ML.RestarLucas(Costo1);
            Ambi += 1;
            Botones[6].SetActive(false);
        } }
    public void Ambientación2() {
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo2 && Ambi == 1)
        {
            ML.RestarLucas(Costo2);
            Ambi += 1;
            Botones[7].SetActive(false);
        } }
    public void Ambientación3() { 
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo3 && Ambi == 2)
        {
            ML.RestarLucas(Costo3);
            Ambi += 1;
            Botones[8].SetActive(false);
        }
    }
    public void Prevención1()
    {
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo1 && Prev == 0)
        {
            ML.RestarLucas(Costo1);
            Prev += 1;
            Botones[3].SetActive(false);

        } }
    public void Prevención2()
    {
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo2 && Prev == 1)
        {
            ML.RestarLucas(Costo2);
            Prev += 1;
            Botones[4].SetActive(false);
        }
    }
    public void Prevención3() {
            
        if (PlayerPrefs.GetInt("Puntaje Maximo", 0) > Costo3 && Prev == 2)
        {
            ML.RestarLucas(Costo3);
            Prev += 1;
            Botones[5].SetActive(false);
        }
    }
    private void IniciarSlider()
    {
     /*   sliderInfra = GameObject.FindGameObjectWithTag("SliderInfra").GetComponent<Slider>();
        sliderPrev = GameObject.FindGameObjectWithTag("SliderAmbi").GetComponent<Slider>();
        sliderAmbi = GameObject.FindGameObjectWithTag("SliderPrev").GetComponent<Slider>();*/
        sliderInfra.maxValue = MaximoV;
        sliderInfra.value = Infra;
        sliderAmbi.maxValue = MaximoV;
        sliderAmbi.value = Ambi;
        sliderPrev.maxValue = MaximoV;
        sliderPrev.value = Prev;
    }
}
