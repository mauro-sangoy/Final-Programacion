using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoSeguimiento : MonoBehaviour
{
    private Transform player;
    [SerializeField] float speed = 2.5f;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        Vector3 playerPosition = player.position;
        Vector3 direction = playerPosition - transform.position;
        direction.z = 0;

        direction.Normalize();

        transform.position += direction * speed * Time.deltaTime;
        transform.up = direction;
    }

}

