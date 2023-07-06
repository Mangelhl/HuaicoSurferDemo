using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVobstaculos : MonoBehaviour
{
    Rigidbody rb;
    private float NumRandom;
    GameManager Gm;
    ManagerVariante GVM;
    bool T;
    
    void Start()
    {
        if (T == false)
        {
            Gm = FindObjectOfType<GameManager>();
            NumRandom = Random.Range(Gm.VelocidadGeneral - 25, Gm.VelocidadGeneral + 24);
            rb = GetComponent<Rigidbody>();
            rb.velocity -= new Vector3(0, 0, NumRandom);
            // Debug.Log(NumRandom);
        }
        else
        {    GVM= FindObjectOfType<ManagerVariante>();
            NumRandom = Random.Range(Gm.VelocidadGeneral - 25, Gm.VelocidadGeneral + 24);
            rb = GetComponent<Rigidbody>();
            rb.velocity -= new Vector3(0, 0, NumRandom);
        }
       
    }

    void Update()
    {
        
    }
}
