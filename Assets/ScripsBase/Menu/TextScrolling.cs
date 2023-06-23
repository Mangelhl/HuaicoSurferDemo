using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScrolling : MonoBehaviour
{
    public string[] Contenido;
    public float scrollSpeed = 1.5f;

    private Text textComponent;
    private int currentIndex = 0;

    private RectTransform canvasRectTransform;
    private float canvasWidth;

    void Start()
    {
        textComponent = GetComponent<Text>();
        textComponent.text = Contenido[currentIndex];

        canvasRectTransform = transform.parent.GetComponent<RectTransform>();
        canvasWidth = canvasRectTransform.rect.width;
    }
       

    private void Update()
    {
        float newPosition = transform.localPosition.x + scrollSpeed * Time.deltaTime;

        transform.Translate(Vector3.right * scrollSpeed * Time.deltaTime);

        if (newPosition > canvasWidth)
        {
            newPosition = -canvasWidth;
            currentIndex = (currentIndex + 1) % Contenido.Length;
            textComponent.text = Contenido[currentIndex];
        }

        transform.localPosition = new Vector3(newPosition, transform.localPosition.y, transform.localPosition.z);
        
    }
}
