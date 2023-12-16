using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{
    [SerializeField] GameObject[] Enemigos;

    [SerializeField] private float SpawnRate = 1f;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds wait = new WaitForSeconds(SpawnRate);

        while (true)
        {
            yield return wait;

            int rand = Random.Range(0, Enemigos.Length);

            GameObject EnemyToSpawn = Enemigos[rand];

            Instantiate(EnemyToSpawn, transform.position, Quaternion.identity);

        }

    }
}
