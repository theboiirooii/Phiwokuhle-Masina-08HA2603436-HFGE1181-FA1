using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        GameMNGR.Instance.IncrementScore(value);
        Destroy(this.gameObject);
    }
}