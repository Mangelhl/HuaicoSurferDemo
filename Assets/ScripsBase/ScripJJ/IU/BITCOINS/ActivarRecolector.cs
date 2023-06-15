using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActivarRecolector : MonoBehaviour
{
    [SerializeField]bool CM;
    private void Start()
    {
        CM = false;
    }

    private void OnTriggerStay(Collider collision)
    {
        if (CM==true)
        {
            if (collision.gameObject.TryGetComponent<CCoin>(out CCoin coin))
            {
                coin.SetTarget(transform.parent.position);
            }
        }
    }
    public  void ActivarMagnet()
    {
        CM = true;
    }


}

