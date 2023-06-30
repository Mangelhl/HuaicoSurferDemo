using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X2Collide : MonoBehaviour
{
    MonedasLucas PS;


    private void Awake()
    {
        PS = FindObjectOfType<MonedasLucas>();
    }


    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "Player")
        {
            PS.Putimer();
            Destroy(this.gameObject);
        }


    }
}