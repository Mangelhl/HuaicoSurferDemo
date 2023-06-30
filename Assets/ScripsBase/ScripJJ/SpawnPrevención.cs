using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrevención : MonoBehaviour
{
  [SerializeField]  GameObject[] PrevMuro; 
    // Start is called before the first frame update
    void Awake ()
    {

        if (PlayerPrefs.GetInt("Prev", 0) == 1)
        {
            PrevMuro[0].SetActive (true);
            PrevMuro[1].SetActive(false);
            PrevMuro[2].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Prev", 0) == 2)
        {
            PrevMuro[0].SetActive(false);
            PrevMuro[1].SetActive(true);
            PrevMuro[2].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Prev", 0) == 3)
        {
            PrevMuro[0].SetActive(false);
            PrevMuro[1].SetActive(false);
            PrevMuro[2].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
