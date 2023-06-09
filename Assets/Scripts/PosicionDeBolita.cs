using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionDeBolita : MonoBehaviour
{
    public GameObject Prefab;
    MOVescenario Mo;
    public int distanciaRecorrida;
    Rigidbody rb;
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Mo = Prefab.GetComponent<MOVescenario>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0, 0, -Mo.VelocidadEscenario);
        float posicionZ = transform.localPosition.z;
        int distancia = Mathf.CeilToInt(posicionZ);
        distanciaRecorrida = Mathf.Abs(distancia);
    }
}
