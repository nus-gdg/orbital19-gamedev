using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusSpawner : MonoBehaviour
{
    public float WaitTime = 5f;
    public GameObject Cactus;

    private void Start()
    {
        StartCoroutine(SpawnCactusAtIntervals());
    }

    private IEnumerator SpawnCactusAtIntervals()
    {
        while (true)
        {
            yield return new WaitForSeconds(WaitTime);
            Instantiate(Cactus, transform.position, Quaternion.identity);
        }
    }
}
