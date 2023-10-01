using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;

    private float dirX;
    private float dirY;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = rb.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        dirY = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(dirX * movementSpeed, dirY * movementSpeed);

        if (dirX < 0)
        {
            sprite.flipX = true;
        }

        if (dirX > 0)
        {
            sprite.flipX = false;
        }
    }
}
