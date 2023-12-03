using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosicion : MonoBehaviour
{
 
    void Start()
    {
        int indexNave = PlayerPrefs.GetInt("NaveIndex");
        Instantiate(GameManager.Instance.Naves[indexNave].SelectNaves, transform.position, Quaternion.identity);
    }

}
