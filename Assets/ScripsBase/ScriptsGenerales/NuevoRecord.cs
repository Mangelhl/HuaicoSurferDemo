using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuevoRecord : MonoBehaviour
{
    CanvasTexto CT;
    // Start is called before the first frame update
    void Start()
    {
        CT = FindObjectOfType<CanvasTexto>();
    }

    // Update is called once per frame
    void Update()
    {
        if(CT.PuntajeMasAlto > CT.PuntajeAnterior)
        {
            this.gameObject.SetActive(false);
        }
        else if(CT.PuntajeMasAlto <= CT.PuntajeAnterior)
        {
            this.gameObject.SetActive(true);
        }
    }
}
