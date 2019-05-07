using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusObstacle : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D cactusRigidbody;

    private void Start()
    {
        cactusRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        cactusRigidbody.velocity = new Vector2(-1f, 0) * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "De-Spawner")
        {
            Destroy(gameObject);
        }
    }
}
