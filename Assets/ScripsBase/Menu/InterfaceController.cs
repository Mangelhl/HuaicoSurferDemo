using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceController : MonoBehaviour
{
    [SerializeField] private GameObject Buttons;
    [SerializeField] private GameObject Text;
    [SerializeField] private GameObject Tienda;
    [SerializeField] private GameObject MejoraT;
    [SerializeField] private GameObject MejorbT;
    public float idleTime = 8f;       
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
        }
    }

    private void HideInterface()
    {
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
        }
    }
}

