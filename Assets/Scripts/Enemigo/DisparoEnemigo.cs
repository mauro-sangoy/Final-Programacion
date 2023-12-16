using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEn : MonoBehaviour
{
    [SerializeField] private GameObject ProyectilPrefab;
    [SerializeField] private float TiempoDisparo;

    private void Start()
    {
        StartCoroutine(Disparo());
    }

    IEnumerator Disparo() 
    {
        while (true)
        {
            yield return new WaitForSeconds(TiempoDisparo);
            Instantiate(ProyectilPrefab,transform.position,Quaternion.identity);
        }
        

    }
}
