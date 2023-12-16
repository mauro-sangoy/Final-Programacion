using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemigo : MonoBehaviour
{
    [SerializeField] private float velocidad;
    private Transform player;
    [SerializeField] private float Daño;

    private Rigidbody2D rb;

    private void Start()
    {
        player = FindObjectOfType<VidaJugador>().transform;
        rb = GetComponent<Rigidbody2D>();

        DispararProyectil();
    }

    private void DispararProyectil()
    {
        Vector2 DireccionJugador = player.position - transform.position;
        rb.velocity = DireccionJugador * velocidad;
        StartCoroutine(DestruirProyectil());
    }

    IEnumerator DestruirProyectil() 
    {
        float TiempoVivo = 5f;
        yield return new WaitForSeconds(TiempoVivo);
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<VidaJugador>().TomarDaño(Daño);
            Destroy(gameObject);
        }
    }
}
