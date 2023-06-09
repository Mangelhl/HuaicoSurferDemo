using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DividirPlano : MonoBehaviour
{
    public int cantidadX; 
    public int cantidadZ; 
    public float espacioX = 2f;
    public float espacioZ = 2f; 
    public Vector3 origen = Vector3.zero; 
    public GameObject puntoInicioArrays;

    public float[,] arrayX; 
    public float[,] arrayZ;



    private void Awake()
    {
        Vector3 escala = transform.localScale;
        Vector3 posicion = transform.position;
        Vector3 nuevaPosicion = new Vector3(puntoInicioArrays.transform.localPosition.x * escala.x, puntoInicioArrays.transform.localPosition.y * escala.y, puntoInicioArrays.transform.localPosition.z * escala.z);

        origen = nuevaPosicion + posicion;

        espacioX = escala.x * 10 / cantidadX;
        espacioZ = escala.z * 10 / cantidadZ;

        arrayX = new float[cantidadX, cantidadZ];
        arrayZ = new float[cantidadZ, cantidadX];

        for (int i = 0; i < cantidadX; i++)
        {
            for (int j = 0; j < cantidadZ; j++)
            {
                arrayX[i, j] = Random.Range(0f, 1f);
                arrayZ[j, i] = Random.Range(0f, 1f);
            }
        }
    }

    private void Start()
    {
        
    }
    private void Update()
    {
        Vector3 escala = transform.localScale;
        Vector3 posicion = transform.position;
        Vector3 nuevaPosicion = new Vector3(puntoInicioArrays.transform.localPosition.x * escala.x, puntoInicioArrays.transform.localPosition.y * escala.y, puntoInicioArrays.transform.localPosition.z * escala.z);

        origen = nuevaPosicion + posicion;

        espacioX = escala.x * 10 / cantidadX;
        espacioZ = escala.z * 10 / cantidadZ;

        arrayX = new float[cantidadX, cantidadZ];
        arrayZ = new float[cantidadZ, cantidadX];

        for (int i = 0; i < cantidadX; i++)
        {
            for (int j = 0; j < cantidadZ; j++)
            {
                arrayX[i, j] = Random.Range(0f, 1f);
                arrayZ[j, i] = Random.Range(0f, 1f);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        for (int i = 0; i < cantidadX; i++)
        {
            for (int j = 0; j < cantidadZ; j++)
            {
                Vector3 posicion = origen + new Vector3(i * espacioX, 0f, j * espacioZ);
                Gizmos.DrawSphere(posicion, 1f);
            }
        }

        for (int i = 0; i < cantidadZ; i++)
        {
            for (int j = 0; j < cantidadX; j++)
            {
                Vector3 posicion = origen + new Vector3(j * espacioX, 0f, i * espacioZ);
                Gizmos.DrawSphere(posicion, 1f);
            }
        }
    }
}

