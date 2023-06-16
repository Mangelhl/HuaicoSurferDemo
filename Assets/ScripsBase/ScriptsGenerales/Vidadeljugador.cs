using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidadeljugador : MonoBehaviour
{
    private float vida = 2;
    private bool invencible = false;
    private float tiempodeinvencible = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void menosvida (int cantidad)
    {
        if (!invencible && vida > 0)
        {
            vida -= cantidad;
            StartCoroutine(inmortal());
        }
            
        IEnumerator inmortal()
        {
            invencible = true;
            yield return new WaitForSeconds(tiempodeinvencible);
            invencible = false;
        }

    }

}
