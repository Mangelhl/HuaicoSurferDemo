using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turbulencia : MonoBehaviour
{
    public int CantidadDeGiro;
   
    // Start is called before the first frame update
    void Start()
    {
       
        float ScaleZ = transform.localPosition.z;
        int distancia = Mathf.CeilToInt(ScaleZ);
        CantidadDeGiro = Mathf.Abs(distancia);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
