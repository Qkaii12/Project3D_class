using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombiePrefab;
    public int spawnQuantity;
    public float spwanInterval;

    private void OnDrawGizoms()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, 0.2f);
    }
    private void Start() => StartCoroutine(SpawnZombieByTime());

    private IEnumerator SpawnZombieByTime()
    {
        while(spawnQuantity > 0)
        {
            SpawnZombie();
            yield return new WaitForSeconds(spwanInterval);
        }
    }
    private void SpawnZombie()
    {
        Instantiate(zombiePrefab, transform.position, transform.rotation);
        spawnQuantity--;
    }
}
