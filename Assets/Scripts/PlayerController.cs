using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public float JumpVelocity;
    public GameManager GameManagerInstance;

    private Rigidbody2D playerRigidbody;
    private Animator playerAnimator;
    private bool isDead = false;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (isDead)
        {
            return;
        }

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

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Cactus")
        {
            isDead = true;
            playerAnimator.SetBool("Dead", true);
            GameManagerInstance.OnPlayerHit();
        }
    }
}
