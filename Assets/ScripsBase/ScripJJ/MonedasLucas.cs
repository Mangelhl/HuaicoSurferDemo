using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MonedasLucas : MonoBehaviour
{ 
[Header("Colocar Texto Puntaje Maximo")]
[SerializeField] public TMP_Text SM;
public int ScoreN,ScoreMax;
    private void Awake()
    {
        SM = GameObject.FindGameObjectWithTag("Lucas").GetComponent<TMP_Text>();
    }
    void Start()
{      
    SM.text = " " + PlayerPrefs.GetInt("Puntaje Maximo", 0).ToString();   
}
    private void Update()
    {
        
        Debug.Log("MaxP "+PlayerPrefs.GetInt("Puntaje Maximo", 0));
        Debug.Log("ScoreN:"+ScoreN);

        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerPrefs.SetInt("Puntaje Maximo", 0);
            SM.text = "" + 0;
        }
    
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (PlayerPrefs.GetInt("Puntaje Maximo", 0) < 75)
            {
                PlayerPrefs.SetInt("Puntaje Maximo", PlayerPrefs.GetInt("Puntaje Maximo", 0 + 75));
            }
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
    if (collision.tag == "Civil")
    {
            PlayerPrefs.SetInt("Puntaje Maximo", PlayerPrefs.GetInt("Puntaje Maximo", 0) + 1);
            Destroy(collision.gameObject);
            SM.text = (PlayerPrefs.GetInt("Puntaje Maximo", 0)).ToString();

            
        }
}
}