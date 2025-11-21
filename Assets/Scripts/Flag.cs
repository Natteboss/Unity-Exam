using System;
using UnityEngine;

public class Flag : MonoBehaviour
{
    [SerializeField] private GameObject winText;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            winText.SetActive(true);
        }
    }
}
