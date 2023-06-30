using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    public GameObject []objetoCerro;
    public GameObject ObjetoInstanciadoPueblo;
    GameManager Gm;
    public float Tiempo;
        private  int N;

    // Start is called before the first frame update
    private void Awake()
    {
        switch (PlayerPrefs.GetInt("Ambi", 0))
        {
                case 1:
                N = 0;
                break;

                case 2:
                N = 1;
                break;

                case 3:  
                N = 2;
                break;
        }
    }
    void Start()
    {
        Debug.Log(Tiempo);
        Gm = FindObjectOfType<GameManager>();

        StartCoroutine(disparar());
    }
    IEnumerator disparar()
    {
        while (Gm.tiempoPasado < 100)
        {
            Tiempo = 95.0f / Gm.VelocidadGeneral;
            Instantiate(objetoCerro[N], transform.position, transform.rotation);
            yield return new WaitForSeconds(Tiempo);
            Tiempo = 95.0f / Gm.VelocidadGeneral;
        }
        while (Gm.tiempoPasado > 100)
        {
            Tiempo = 110.0f / Gm.VelocidadGeneral;
            Instantiate(ObjetoInstanciadoPueblo, transform.position, transform.rotation);
            yield return new WaitForSeconds(Tiempo);
            Tiempo = 110.0f / Gm.VelocidadGeneral;
        }
     
    }
    void Update()
    {
        Tiempo = 95.0f / Gm.VelocidadGeneral;
    }

    // Update is called once per frame




}
