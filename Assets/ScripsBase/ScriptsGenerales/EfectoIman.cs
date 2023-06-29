using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoIman : MonoBehaviour
{
    [Header("Iman")]
    public GameObject Jugador;
    public float Distancia;
    public float velocidadAtraccion;
    Rigidbody rb;
    [Header("Flotar")]
    public float alturaMaxima = 2f;
    public float velocidad ;
    private float tiempoPasado = 0f;
    private bool subiendo = true;
    private float inicioPosicionY;
    private float CantidadDeUnidades = 2f;
    [Header("EfectoDeEmojis")]
    public GameObject asustado;
    public GameObject PorPoco;

    Moverse move;
    // Start is called before the first frame update
    void Start()
    {
        Jugador = GameObject.Find("Colchon");
        rb = GetComponent<Rigidbody>();
        move = FindObjectOfType<Moverse>();

        inicioPosicionY = transform.position.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = Camera.main.transform.position;

        Distancia = Vector3.Distance(transform.position, Jugador.transform.position);
        asustado.transform.LookAt(cameraPosition);
        PorPoco.transform.LookAt(cameraPosition);
    }
    private void FixedUpdate()
    {
        if(Distancia < 100f && move.iman == true)
        {
            PorPoco.SetActive(true);
            asustado.SetActive(false);
            Vector3 direccion = Jugador.transform.position - transform.position;
            transform.position += direccion.normalized * velocidadAtraccion ;
        }
        else
        {
            asustado.SetActive(true);
            PorPoco.SetActive(false);
            tiempoPasado += Time.deltaTime * velocidad;

            if (subiendo)
            {
                float nuevaPosicionY = Mathf.Lerp(inicioPosicionY, alturaMaxima, tiempoPasado/ CantidadDeUnidades);
                transform.position = new Vector3(transform.position.x, inicioPosicionY + nuevaPosicionY, transform.position.z);

                if (tiempoPasado >= CantidadDeUnidades)
                {
                    tiempoPasado = 0f;
                    subiendo = false;
                }
            }
            else
            {
                float nuevaPosicionY = Mathf.Lerp(inicioPosicionY, alturaMaxima, tiempoPasado/ CantidadDeUnidades);
                transform.position = new Vector3(transform.position.x, inicioPosicionY  - nuevaPosicionY, transform.position.z);

                if (tiempoPasado >= CantidadDeUnidades)
                {
                    tiempoPasado = 0f;
                    subiendo = true;
                }
            }
        }
    }
  
}
