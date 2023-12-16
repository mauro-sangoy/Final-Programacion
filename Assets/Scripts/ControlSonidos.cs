using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSonidos : MonoBehaviour
{
    public static ControlSonidos sonidos;

    private AudioSource audioSource;

    private void Awake()
    {
        if (sonidos == null) 
        {
            sonidos = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }

        audioSource = GetComponent<AudioSource>();
    }

    public void EjecutarSonido(AudioClip sonido) 
    {
        audioSource.PlayOneShot(sonido);
    }

}
