using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoMouse : MonoBehaviour
{
    [Header ("MovimientoCamara")]

    private Vector3 Objetivo;

    [SerializeField] private Camera Cam;
    [SerializeField] private float AnguloInicial;

    private void Update()
    {
        Objetivo = Cam.ScreenToWorldPoint(Input.mousePosition);
        float AnguloRadianes = Mathf.Atan2(Objetivo.y - transform.position.y, Objetivo.x - transform.position.x);
        float AnguloGrados = (180/Mathf.PI) * AnguloRadianes - AnguloInicial;
        transform.rotation = Quaternion.Euler(0, 0, AnguloGrados);
    }
}
