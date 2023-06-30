using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceController : MonoBehaviour
{
    [SerializeField] private GameObject Buttons;
    [SerializeField] private GameObject Text;
<<<<<<< Updated upstream
    [SerializeField] private GameObject[] GOJJ;
    public float idleTime = 5f;       
=======
    [SerializeField] private GameObject Tienda;
    [SerializeField] private GameObject MejoraT;
    [SerializeField] private GameObject MejorbT;
    public float idleTime = 8f;       
>>>>>>> Stashed changes
    private float timeSinceLastInput = 0f;           

    private void Start()
    {
        MejoraT.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShowInterface();
            timeSinceLastInput = 0f;
        }
        else
        {
          
            timeSinceLastInput += Time.deltaTime;

            if (timeSinceLastInput >= idleTime)
            {                
                HideInterface();
            }
        }
    }

    private void ShowInterface()
    {
<<<<<<< Updated upstream
        if (GOJJ[3].activeInHierarchy == false)
        {
            Text.SetActive(false);
            GOJJ[1].gameObject.SetActive(true);
        }
        if (GOJJ[1].activeInHierarchy == false)
        {
            Text.SetActive(false);
            GOJJ[0].SetActive(true);
            GOJJ[2].SetActive(true);
=======
        if (MejoraT.activeInHierarchy==false)
        {
            Buttons.SetActive(true);
            Tienda.SetActive(true);
            Text.SetActive(false);
        }
        if (MejoraT.activeInHierarchy == true)
        {
            Text.SetActive(false);
            MejorbT.SetActive(true);
>>>>>>> Stashed changes
        }
    }

    private void HideInterface()
    {
<<<<<<< Updated upstream
        if (GOJJ[0].activeInHierarchy == true)
        {
            Text.SetActive(true);
            GOJJ[0].SetActive(false);
            GOJJ[2].SetActive(false);
        }
        if (GOJJ[1].activeInHierarchy == true)
        {
            Text.SetActive(true);
            GOJJ[1].gameObject.SetActive(false);
=======
        if (MejoraT.activeInHierarchy == false)
        {
            Tienda.SetActive(false);
            Buttons.SetActive(false);
            Text.SetActive(true);
            
        }
        if (MejoraT.activeInHierarchy == true)
        {
            Text.SetActive(true);
            MejorbT.SetActive(false);
>>>>>>> Stashed changes
        }
    }
}

