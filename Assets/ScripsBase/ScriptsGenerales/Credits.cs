using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Credits : MonoBehaviour
{
    public Transform startPos;
    public Transform endPos;
    public float speed = 0.5f;

    private RectTransform rectTransform;
    private TextMeshProUGUI textMeshPro;
    private float startTime;
    private float journeyLength;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        textMeshPro = GetComponent<TextMeshProUGUI>();
        startTime = Time.time;
        journeyLength = Vector3.Distance(startPos.position, endPos.position);
    }

    private void Update()
    {
        float distanceCovered = (Time.time - startTime) * speed;
        float fractionOfJourney = distanceCovered / journeyLength;
        rectTransform.position = Vector3.Lerp(startPos.position, endPos.position, fractionOfJourney);
    }
}
