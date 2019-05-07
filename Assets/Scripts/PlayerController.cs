using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float JumpVelocity;
    private Rigidbody2D playerRigidbody;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetAxis("Jump") == 1 && transform.position.y < -3.7f)
        {
            playerRigidbody.velocity = new Vector2(0.0f, JumpVelocity);
        }
    }
}
