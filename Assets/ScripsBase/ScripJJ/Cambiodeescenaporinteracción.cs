using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambiodeescenaporinteracción : MonoBehaviour
{
    public GameObject[] verdaderos;
    public int nverdaderos;
    public GameObject[] falsos;
    public int nfalsos ;




    public void ActivarYDesactivar()
    {
        for (int i = 0; i < nverdaderos; i++)
        {
            verdaderos[i].gameObject.SetActive(true);
        }
        for (int j = 0; j < nfalsos; j++)
        {
            falsos[j].gameObject.SetActive(false);
        }
    }



}
