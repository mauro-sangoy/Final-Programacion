using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float velocidad;

    [SerializeField] private float Daño;

    private void Update()
    {
        transform.Translate(Vector2.up * velocidad * Time.deltaTime);
        StartCoroutine(Destruir());
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemigo")) 
        {
            other.GetComponent<VidaEnemigo>().TomarDaño(Daño);
            Destroy(gameObject);
        }
    }

    private IEnumerator Destruir()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
    }


}
