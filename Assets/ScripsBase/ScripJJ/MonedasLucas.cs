using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MonedasLucas : MonoBehaviour
{
    [Header("Colocar Texto Puntaje Maximo")]
    [SerializeField] public TMP_Text SM;
    public int ScoreN, ScoreMax;
    public bool NPS;
    [SerializeField] private float Timex2T;
    [SerializeField] private bool D;

    private void Awake()
    {
        if (D == false)
        {
            SM = GameObject.FindGameObjectWithTag("Lucas").GetComponent<TMP_Text>();
        }
        }
    void Start()
    {
        if (D == false)
        {
            SM.text = " " + PlayerPrefs.GetInt("Puntaje Maximo", 0).ToString();
        }
    }
    private void Update()
    {

        Debug.Log("MaxP " + PlayerPrefs.GetInt("Puntaje Maximo", 0));
        Debug.Log("ScoreN:" + ScoreN);

        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerPrefs.SetInt("Puntaje Maximo", 0);
            SM.text = "" + 0;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            
                PlayerPrefs.SetInt("Puntaje Maximo", PlayerPrefs.GetInt("Puntaje Maximo", 0) + 75);
           
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            PlayerPrefs.SetInt("Puntaje Maximo", PlayerPrefs.GetInt("Puntaje Maximo", 0) + ScoreN);
        }
    }
    public void RestarLucas(int DR)
    {
        PlayerPrefs.SetInt("Puntaje Maximo", PlayerPrefs.GetInt("Puntaje Maximo", 0) - DR);
        SM.text = (PlayerPrefs.GetInt("Puntaje Maximo", 0)).ToString();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Civil" && NPS == false)
        {
            PlayerPrefs.SetInt("Puntaje Maximo", PlayerPrefs.GetInt("Puntaje Maximo", 0) + 1);
            Destroy(collision.gameObject);
            SM.text = (PlayerPrefs.GetInt("Puntaje Maximo", 0)).ToString();


        }
        if (collision.tag == "Civil" && NPS == true)
        {
            PlayerPrefs.SetInt("Puntaje Maximo", PlayerPrefs.GetInt("Puntaje Maximo", 0) + 2);
            Destroy(collision.gameObject);
            SM.text = (PlayerPrefs.GetInt("Puntaje Maximo", 0)).ToString();


        }
    }

    public void Putimer()
    {
        StartCoroutine(PlusScore());
    }

    IEnumerator PlusScore()
    {
        NPS = true;
        yield return new WaitForSeconds(Timex2T);
        NPS = false;
    }
}