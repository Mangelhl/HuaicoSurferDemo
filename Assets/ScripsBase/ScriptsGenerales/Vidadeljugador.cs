using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vidadeljugador : MonoBehaviour
{
    private float vida = 2;
    private bool invencible = false;
    private float tiempodeinvencible = 1f;
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeLife(int value)
    {
        vida += value;

        if (vida <= 0)
        {
            //clip.Play(); 
            Destroy(GetComponent<SpriteRenderer>());
            Destroy(GetComponent<Collider2D>());
            //defeat.SetActive(true);
            Destroy(gameObject, 1f);
            life1.SetActive(false);
            Time.timeScale = 0f;
        }

        else if (vida <= 1)
        {
            life2.SetActive(false);
        }

        else if (vida <= 2)
        {
            life3.SetActive(false);
        }
    }
    public void menosvida(int cantidad)
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstaculo") && invencible == false)
        {
            vida -= 1;

        }
        if (other.gameObject.CompareTag("Civil") && invencible == false)
        {
            vida += 1;
            ChangeLife(+1);

            if (vida == 2)
            {
                life2.SetActive(true);
            }
            else if (vida == 3)
            {
                life3.SetActive(true);
            }

        }

        if (other.gameObject.CompareTag("Obstaculo") && vida == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
