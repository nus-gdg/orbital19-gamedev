using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public CactusSpawner Spawner;
    public PlayerController Player;
    public Text CurrentTime;
    public Text BestTime;
    public HighScore HighScoreObject;

    private float time = 0;
    private bool hasGameEnded = false;

    private void Start()
    {
        BestTime.text = HighScoreObject.Time.ToString();
    }

    private void Update()
    {
        if (hasGameEnded)
        {
            return;
        }
        time += Time.deltaTime;
        CurrentTime.text = time.ToString();
    }

    public void OnPlayerHit()
    {
        CactusObstacle.Speed = 0;
        Spawner.ShouldSpawn = false;
        hasGameEnded = true;
        if (HighScoreObject.Time < time)
        {
            HighScoreObject.Time = time;
            BestTime.text = HighScoreObject.Time.ToString();
        }
    }
}
