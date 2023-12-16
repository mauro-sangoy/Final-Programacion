using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gemas : MonoBehaviour
{
    
    [SerializeField] private float CantPuntos;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Puntaje puntaje = FindObjectOfType<Puntaje>(); // Busca el script Puntaje en la escena
            if (puntaje != null)
            {
                puntaje.puntos += CantPuntos;
            }
            Destroy(gameObject);
        }
    }
}
