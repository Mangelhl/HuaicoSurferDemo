using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moverse : MonoBehaviour
{
    GameManager Gm;
    CanvasTexto CT;

    public int VelocidadHorizontal = 80;
    public int velocidadOriniginal = 80;
   
    Rigidbody rb;
    public bool iman;
    public bool Turbo;
    public bool escudo;
    public bool invulnerable;
    public bool Rampa;
    private float EstaEnSUelo = -0.74f;
    private float MaximoEnAire = 18f;
    private float tiempoSubida = 2f;
    private float tiempoQuieto = 2f;
    private float tiempoBajada = 2f;







    public GameObject Velocidad;
    public GameObject Escudo;
    public GameObject Iman;
    private int ImanNumero = 1;



    // Start is called before the first frame update
    void Start()
    {
   
        Turbo = false;
        escudo = false;
        iman = false;
        Rampa = false;
        Gm = FindObjectOfType<GameManager>();
        CT = FindObjectOfType<CanvasTexto>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (ImanNumero == 1)
        {
            iman = false;
        }
        else if (ImanNumero == 0)
        {
            iman = true;
        }
        if (Turbo==false)
        {
            Time.timeScale = 1;
        }
        float MovimientoHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(MovimientoHorizontal * VelocidadHorizontal, 0, 0);

        if (MovimientoHorizontal != Input.GetAxis("Horizontal"))
        {
            rb.velocity = new Vector3(0, 0, 0);
        }

        if (Turbo)
        {
            Time.timeScale = 3;
            Velocidad.SetActive(true);
           
        }
        else
        {
            
            Velocidad.SetActive(false);
            
        }
        if (escudo)
        {
            Escudo.SetActive(true);
        }
        else
        {
            Escudo.SetActive(false);
        }
        if(iman)
        {
            Iman.SetActive(true);
        }
        else
        {
            Iman.SetActive(false);
        }
       

       

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstaculo") && invulnerable == false && escudo == false)
        {
            SceneManager.LoadScene(2);
        }
        if (other.gameObject.CompareTag("Obstaculo") && Turbo == false && escudo == true)
        {
            StartCoroutine(EscuDo());
        }
        if (other.gameObject.CompareTag("Escudo"))
        {
            escudo = true;
        }
        if (other.gameObject.CompareTag("Turbo") && invulnerable == false)
        {
            StartCoroutine(turBo());
        }
        if (other.gameObject.CompareTag("Iman"))
        {
            StartCoroutine(ImAn());
        }
        if (other.gameObject.CompareTag("Rampa"))
        {
            StartCoroutine(rampa());
        }
        /* if (other.gameObject.CompareTag("Persona"))
         {
             CT.monedas = CT.monedas + 1;
             Destroy(other.gameObject);

             foreach (Transform child in other.transform)
             {
                 Destroy(child.gameObject);
             }
         }
        */


    }
    IEnumerator turBo()
    {
        invulnerable = true;
        Turbo = true;
        Gm.tiempoPasado = Gm.tiempoPasado + 8;
        yield return new WaitForSeconds(3f);
        Time.timeScale = 1;
        Turbo = false;
        yield return new WaitForSeconds(1f);
        invulnerable = false;

    }
   

    IEnumerator EscuDo()
    {
        
        yield return new WaitForSeconds(0.5f);
        escudo = false;
    }
    IEnumerator ImAn()
    {
       
        ImanNumero = 0;
        yield return new WaitForSeconds(10f);
        ImanNumero = 1;
       
    }
    IEnumerator rampa()
    {
        
        float tiempoPasado = 0f;
        float inicioPosicionY = EstaEnSUelo;
        float finalPosicionY = MaximoEnAire;

        while (tiempoPasado < tiempoSubida)
        {
            tiempoPasado += Time.deltaTime;
            float nuevaPosicionY = Mathf.Lerp(inicioPosicionY, finalPosicionY, tiempoPasado / tiempoSubida);
            transform.position = new Vector3(transform.position.x, nuevaPosicionY, transform.position.z);
            yield return null;
        }
        yield return new WaitForSeconds(tiempoQuieto);
        tiempoPasado = 0f;
        inicioPosicionY = MaximoEnAire;
        finalPosicionY = EstaEnSUelo;
        while (tiempoPasado < tiempoBajada)
        {
            tiempoPasado += Time.deltaTime;
            float nuevaPosicionY = Mathf.Lerp(inicioPosicionY, finalPosicionY, tiempoPasado / tiempoBajada);
            transform.position = new Vector3(transform.position.x, nuevaPosicionY, transform.position.z);
            yield return null;
        }
        transform.position = new Vector3(transform.position.x, EstaEnSUelo, transform.position.z);
    }
}
