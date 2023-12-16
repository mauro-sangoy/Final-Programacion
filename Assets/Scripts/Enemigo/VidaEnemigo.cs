using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaEnemigo : MonoBehaviour
{
    [SerializeField] private float Vida;

    Drops DropsItems;

    [SerializeField] private AudioClip Muerte;

    private void Start()
    {
        DropsItems = GetComponent<Drops>();
    }
    
    public void TomarDa�o(float Da�o) 
    {
        Vida -= Da�o;
        
        if (Vida <= 0) 
        {
            ControlSonidos.sonidos.EjecutarSonido(Muerte);
            Destroy(gameObject);
            DropsItems.DropearGegams();
        }

    }
}
