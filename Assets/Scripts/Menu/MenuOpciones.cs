using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuOpciones : MonoBehaviour
{
    [SerializeField] private AudioMixer AudioT;
    public void PantallaCompleta(bool PantallaCompleta) 
    {
        Screen.fullScreen = true;
    }

    public void SubirVolumen(float Volumen) 
    {
        AudioT.SetFloat("Volumen", Volumen);
    }

}
