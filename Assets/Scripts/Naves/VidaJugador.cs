using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VidaJugador : MonoBehaviour
{
    

    [SerializeField] private float Vida;
    [SerializeField] private float VidaMax;
    [SerializeField] private BarraDeVida BarraVida;

    private void Start()
    {
        Vida = VidaMax;
        BarraVida.IniciarBarraVida(Vida);
    }

    public void TomarDaño(float Daño)
    {
        Vida -= Daño;
        BarraVida.CambiarVidaActual(Vida);

        if (Vida <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
