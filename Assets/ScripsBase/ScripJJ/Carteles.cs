using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carteles : MonoBehaviour
{
  [SerializeField] private  GameObject[] CARTELES;
    // Start is called before the first frame update
    void Start()
    {
        CARTELES[Random.Range(0, CARTELES.Length)].SetActive(true);
    }


}
