using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceController : MonoBehaviour
{
    [SerializeField] private GameObject Buttons;
    [SerializeField] private GameObject Text;
    [SerializeField] private GameObject[] GOJJ;
    public float idleTime = 5f;       
    private float timeSinceLastInput = 0f;           

    private void Start()
    {
        
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
        }
    }

    private void HideInterface()
    {
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
        }
    }
}

