using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuOpciones : MonoBehaviour
{
    [SerializeField] private AudioMixer AudioJuego;
    public void PantallaCompleta(bool PantallaCompleta) 
    {
        Screen.fullScreen = true;
    }

    public void SubirVolumen(float Volumen) 
    {
        AudioJuego.SetFloat("Volumen", Volumen);
    }

}
