using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    private Slider slider;
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    public void CambiarVidaMaxima(float VidaMaxima)
    {
        slider.maxValue = VidaMaxima;
    }

    public void CambiarVidaActual(float CantidadVida)
    {
        slider.value = CantidadVida;
    }

    public void IniciarBarraVida(float CantidadVida)
    {
        CambiarVidaMaxima(CantidadVida);
        CambiarVidaActual(CantidadVida);
    }
}

