using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarInstancias : MonoBehaviour
{
    public GameObject[] prefabs;
    public int cantidadInstancias;
    DividirPlano plano;
    public float Tiempo =2.5f;
    public int TiempoInicio;
    public bool paraObstaculos = true;
    public bool Aleatoriedad = false;
    public GameManager gm;
    private float cambio = 99f;
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        plano = GetComponent<DividirPlano>();
        if (paraObstaculos)
        {
            InvokeRepeating("GenerarInstanciasAleatorias", TiempoInicio, Tiempo);
        }
        else
        {
            if (Aleatoriedad)
            {
                GenerarInstanciasUnicasPorArray();
            }
            else
            {
                GenerarInstanciasAleatorias();
            }
        }
    }
    private void Update()
    {
        gm.Tiempo = Tiempo;
        if(gm.tiempoPasado > cambio)
        {
            cambio = cambio + 99f;
            Tiempo = Tiempo - 0.4f;
        }
    }

    void GenerarInstanciasAleatorias()
    {
        for (int i = 0; i < cantidadInstancias; i++)
        {
            int indiceX = Random.Range(0, plano.cantidadX);
            int indiceZ = Random.Range(0, plano.cantidadZ);

            Vector3 posicion = plano.origen + new Vector3(indiceX * plano.espacioX, 0f, indiceZ * plano.espacioZ);

            GameObject prefabAleatorio = prefabs[Random.Range(0, prefabs.Length)];
            Instantiate(prefabAleatorio, posicion, Quaternion.identity);
        }
    }

    void GenerarInstanciasUnicasPorArray()
    {
        int cantidadArrays = plano.cantidadX * plano.cantidadZ;
        int instanciasPorArray = Mathf.Min(cantidadInstancias, cantidadArrays);

        List<int> indicesArrays = new List<int>();
        for (int i = 0; i < cantidadArrays; i++)
        {
            indicesArrays.Add(i);
        }
        Shuffle(indicesArrays); // Mezcla los índices de los arrays de forma aleatoria

        for (int i = 0; i < instanciasPorArray; i++)
        {
            int indiceArray = indicesArrays[i];
            int indiceX = indiceArray % plano.cantidadX;
            int indiceZ = indiceArray / plano.cantidadX;

            Vector3 posicion = plano.origen + new Vector3(indiceX * plano.espacioX, 0f, indiceZ * plano.espacioZ);

            GameObject prefabAleatorio = prefabs[Random.Range(0, prefabs.Length)];
            Instantiate(prefabAleatorio, posicion, Quaternion.identity);
        }
    }

    void Shuffle<T>(List<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
