using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (moveInput != 0)
        {
            animator.SetBool("isWalking", true);
            if (moveInput > 0)
            {
                transform.localScale = new Vector3(1, 1, 1); // Arkada�lar burada sa� tarafa bakmas�n� sa�l�yoruz 
            }
            else if (moveInput < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1); //  burada da  Sol tarafa bakmas�n� sa�l�yoruz
            }
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
