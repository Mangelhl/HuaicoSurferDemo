using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface ICollectible
{
    public void Collect();
}
public class Collector : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        ICollectible collectible = collision.GetComponent<ICollectible>();
        if (collectible != null)
        {
            collectible.Collect();
        }
    }
}
