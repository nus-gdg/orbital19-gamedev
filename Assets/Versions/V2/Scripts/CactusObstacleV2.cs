using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusObstacleV2 : MonoBehaviour
{
    public float Speed = 10f;
    private Rigidbody2D cactusRigidbody;

    private void Start()
    {
        cactusRigidbody = GetComponent<Rigidbody2D>();
        cactusRigidbody.velocity = new Vector2(-1, 0) * Speed;
    }
}
