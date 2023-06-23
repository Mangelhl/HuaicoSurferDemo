using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruyePrefaps : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Plano"))
        {
            Destroy(other.gameObject);

            foreach (Transform child in other.transform)
            {
                Destroy(child.gameObject);
            }
        }
        if (other.gameObject.CompareTag("Obstaculo"))
        {
            Destroy(other.gameObject);

            foreach (Transform child in other.transform)
            {
                Destroy(child.gameObject);
            }
        }
        
       /* if (other.gameObject.CompareTag("Escudo"))
        {
            Destroy(other.gameObject);

            foreach (Transform child in other.transform)
            {
                Destroy(child.gameObject);
            }
        }*/
        if (other.gameObject.CompareTag("Turbo"))
        {
            Destroy(other.gameObject);

            foreach (Transform child in other.transform)
            {
                Destroy(child.gameObject);
            }
        }
        if (other.gameObject.CompareTag("Iman"))
        {
            Destroy(other.gameObject);

            foreach (Transform child in other.transform)
            {
                Destroy(child.gameObject);
            }
        }
       /* if (other.gameObject.CompareTag("Persona"))
       {
            Destroy(other.gameObject);

            foreach (Transform child in other.transform)
            {
                Destroy(child.gameObject);
            }
        }*/
    }
}
