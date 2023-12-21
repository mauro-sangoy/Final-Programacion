using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Puntaje : MonoBehaviour
{
    public float puntos;
    private TextMeshProUGUI TextoPuntaje;

    private void Start()
    {
        TextoPuntaje = GetComponent<TextMeshProUGUI>();   
    }

    private void Update()
    {
        TextoPuntaje.text = puntos.ToString("0");

        if (puntos >= 1000)
        {
            SceneManager.LoadScene("Victoria");
        }
    }

    public void SumarPuntos(float PuntosInicio) 
    {
        puntos += PuntosInicio;
    }
}
