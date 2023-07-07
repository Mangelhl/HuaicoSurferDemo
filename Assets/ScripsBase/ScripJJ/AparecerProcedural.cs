using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AparecerProcedural : MonoBehaviour
{
    [SerializeField] private GameObject[] SPAWNPROCEDURAL;
        
    // Start is called before the first frame update
    void Start()
    {
      
        switch(PlayerPrefs.GetInt("Infra", 0))
        {
            case 0:
                SPAWNPROCEDURAL[Random.Range(0, SPAWNPROCEDURAL.Length)].SetActive(true);
                break;
                case 1:
                SPAWNPROCEDURAL[Random.Range(1, SPAWNPROCEDURAL.Length)].SetActive(true);
                break;
            case 2:
                SPAWNPROCEDURAL[Random.Range(4, SPAWNPROCEDURAL.Length)].SetActive(true);

                break;
            case 3:
                SPAWNPROCEDURAL[Random.Range(7, SPAWNPROCEDURAL.Length)].SetActive(true);
                break;
        }
    }

  
}
