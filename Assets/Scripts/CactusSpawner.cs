using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusSpawner : MonoBehaviour
{
    public float WaitTime = 2f;
    public GameObject Cactus;
    public bool ShouldSpawn = true;

    private void Start()
    {
        StartCoroutine(SpawnCactusAtIntervals());
    }

    private IEnumerator SpawnCactusAtIntervals()
    {
        while (ShouldSpawn)
        {
            Instantiate(Cactus, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(WaitTime);
        }
    }
}
