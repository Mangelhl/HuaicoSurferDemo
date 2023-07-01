using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachScore : MonoBehaviour
{
    public int scoreValue = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Civil"))
        {
            ScoreManager.GetInstance().AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
}
