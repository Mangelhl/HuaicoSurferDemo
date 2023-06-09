using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoIman : MonoBehaviour
{
    public GameObject Jugador;
    public float Distancia;
    public float velocidadAtraccion;
    Rigidbody rb;
    Moverse move;
    // Start is called before the first frame update
    void Start()
    {
        Jugador = GameObject.Find("Colchon");
        rb = GetComponent<Rigidbody>();
        move = FindObjectOfType<Moverse>();
    }

    // Update is called once per frame
    void Update()
    {
        Distancia = Vector3.Distance(transform.position, Jugador.transform.position);
    }
    private void FixedUpdate()
    {
        if(Distancia < 100f && move.iman == true)
        {
            Vector3 direccion = Jugador.transform.position - transform.position;
            transform.position += direccion.normalized * velocidadAtraccion ;
        }
    }
}
