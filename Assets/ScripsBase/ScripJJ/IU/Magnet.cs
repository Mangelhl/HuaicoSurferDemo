using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    ActivarRecolector AR;
    private void Start()
    {
    AR=FindObjectOfType<ActivarRecolector>();    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AR.ActivarMagnet();
            other.gameObject.GetComponentInChildren<SphereCollider>().enabled = true;
            Destroy(this.gameObject);
        }
    }
}
