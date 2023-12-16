using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drops : MonoBehaviour
{
    public GameObject[] DropsGemas;
    private int ActivarGemas;

    void Start()
    {
        ActivarGemas = Random.Range(0, DropsGemas.Length);
    }

    public void DropearGegams() 
    {
        Instantiate(DropsGemas[ActivarGemas],transform.position, Quaternion.identity);
    }
}
