using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVescenario : MonoBehaviour
{
    public float VelocidadEscenario;
    Rigidbody rb;
    GameManager Gm;
    // Start is called before the first frame update
    void Start()
    {
        Gm = FindObjectOfType<GameManager>();
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        VelocidadEscenario = Gm.VelocidadGeneral;
        rb.velocity = new Vector3(0, 0, -VelocidadEscenario);

    }
    
    

}
