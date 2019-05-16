using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerV2 : MonoBehaviour
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

    private void OnCollisionEnter2D(Collision2D other)
        {
        if (other.gameObject.tag == "Cactus")
        {
            Debug.Log("Ouch!");
        }
    }
}
