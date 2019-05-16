using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerV3 : MonoBehaviour
{
    public CactusSpawnerV3 Spawner;
    public PlayerControllerV3 Player;
    public Text CurrentTime;
    public Text BestTime;

    private float bestTimeValue;
    private float time = 0;
    private bool hasGameEnded = false;

    private void Start()
    {
        bestTimeValue = PlayerPrefs.GetFloat("BestTime", 0);
        BestTime.text = bestTimeValue.ToString();
    }

    private void Update()
    {
        if (hasGameEnded)
        {
            return;
        }
        time += Time.deltaTime;
        CurrentTime.text = time.ToString();
        if (time > bestTimeValue)
        {
            bestTimeValue = time;
            BestTime.text = bestTimeValue.ToString();
        }
    }

    public void OnPlayerHit()
    {
        CactusObstacleV3.Speed = 0;
        Spawner.ShouldSpawn = false;
        hasGameEnded = true;
        if (time > PlayerPrefs.GetFloat("BestTime", 0))
        {
            PlayerPrefs.SetFloat("BestTime", time);
            BestTime.text = time.ToString();
        }
    }
}
