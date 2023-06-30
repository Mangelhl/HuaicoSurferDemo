using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    public GameObject objetoInstanciadoCerro;
    public GameObject ObjetoInstanciadoPueblo;
    GameManager Gm;
    public float Tiempo;
        

    // Start is called before the first frame update
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
            Tiempo = 80.0f / Gm.VelocidadGeneral;
            Instantiate(objetoInstanciadoCerro, transform.position, transform.rotation);
            yield return new WaitForSeconds(Tiempo);
            Tiempo = 80.0f / Gm.VelocidadGeneral;
        }
        while (Gm.tiempoPasado > 100)
        {
            Tiempo = 80.0f / Gm.VelocidadGeneral;
            Instantiate(ObjetoInstanciadoPueblo, transform.position, transform.rotation);
            yield return new WaitForSeconds(Tiempo);
            Tiempo = 80.0f / Gm.VelocidadGeneral;
        }
     
    }
    void Update()
    {
        Tiempo = 85.0f / Gm.VelocidadGeneral;
    }

    // Update is called once per frame




}
