using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoSonido : MonoBehaviour
{
    [SerializeField] private AudioClip Sound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            ControlSonidos.sonidos.EjecutarSonido(Sound);
            Destroy(gameObject);
        }
    }

}
