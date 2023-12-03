using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuSeleccionNave : MonoBehaviour
{
    private int index;

    [SerializeField] private Image imagen;
    [SerializeField] private TextMeshProUGUI nombre;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.Instance;

        index = PlayerPrefs.GetInt("NaveIndex");

        if (index > gameManager.Naves.Count - 1) 
        {
            index = 0;
        }

        CambiarPantalla();
    }

    private void CambiarPantalla()
    {
        PlayerPrefs.SetInt("NaveIndex", index);
        imagen.sprite = gameManager.Naves[index].imagen;
        nombre.text = gameManager.Naves[index].nombre;       
    }

    public void SiguenteNave() 
    {
        if(index == gameManager.Naves.Count - 1) 
        {
            index = 0;
        }
        else 
        {
            index += 1;
        }
        CambiarPantalla();
    }

    public void AnteriorNave()
    {
        if (index == 0)
        {
            index = gameManager.Naves.Count - 1;
        }
        else
        {
            index -= 1;
        }
        CambiarPantalla();
    }

    public void IniciarJuego() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
