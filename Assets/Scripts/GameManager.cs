using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CactusSpawner Spawner;
    public PlayerController Player;

    public void OnPlayerHit()
    {
        CactusObstacle.Speed = 0;
        Spawner.ShouldSpawn = false;
    }
}
