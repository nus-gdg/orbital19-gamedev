using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float JumpVelocity;
    private Rigidbody2D playerRigidbody;
    private Animator playerAnimator;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetAxis("Jump") == 1 && transform.position.y < -3.7f)
        {
            playerAnimator.SetBool("Jumping", true);
            playerRigidbody.velocity = new Vector2(0.0f, JumpVelocity);
        }

        if (playerAnimator.GetBool("Jumping") && playerRigidbody.velocity.y == 0.0f)
        {
            playerAnimator.SetBool("Jumping", false);
        }
    }
}
