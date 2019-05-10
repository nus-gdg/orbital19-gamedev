using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusObstacle : MonoBehaviour
{
    public static float Speed = 10f;
    private Rigidbody2D cactusRigidbody;

    private void Start()
    {
        cactusRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        cactusRigidbody.velocity = new Vector2(-1f, 0) * Speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "De-Spawner")
        {
            Destroy(gameObject);
        }
    }
}
