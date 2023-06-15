using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CCoin : MonoBehaviour,ICollectible
{
    public static event Action OnCoinCollected;
    Rigidbody rb;

    bool hasTarget;
    Vector3 targetPosition;
    [Header("Velocidad De Recolección")]
   [SerializeField] float moveSpeed = 5f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Collect()
    {
        Debug.Log("Coin Collected");
        Destroy(gameObject);
        OnCoinCollected?.Invoke();
    }

    private void FixedUpdate()
    {
        if (hasTarget)
        {
            Vector3 targetDirection = (targetPosition - transform.position).normalized;
            rb.velocity = new Vector3(targetDirection.x, targetDirection.y,targetDirection.z) * moveSpeed;
        }
    }

    public void SetTarget(Vector3 position)
    {
        targetPosition = position;
        hasTarget = true;
    }
}
