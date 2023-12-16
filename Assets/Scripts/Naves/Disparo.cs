using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] private Transform Arma1;
    [SerializeField] private Transform Arma2;
    [SerializeField] private AudioClip SonidoDisparo;
    [SerializeField] private GameObject Bala;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            Disparar();
        }

    }

    private void Disparar() 
    {
        Instantiate(Bala,Arma1.position, Arma1.rotation);
        Instantiate(Bala,Arma2.position, Arma2.rotation);
        ControlSonidos.sonidos.EjecutarSonido(SonidoDisparo);
    }

}
