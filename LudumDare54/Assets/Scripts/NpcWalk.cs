using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcWalk : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private Bell bell;

    private Rigidbody2D rb;

    private float multiplier;
    private bool isTriggered;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        multiplier = Random.Range(1, 4);
    }

    void Update()
    {
        if (isTriggered)
        {
            if (bell.GetIsBell())
            {
                movementSpeed = 0.5f;
            }
            //TODO timer after the cooldown speed will be the initial speed
        }
        else
        {
            movementSpeed = 64;
        }
        rb.velocity = new Vector2(movementSpeed * multiplier, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RightSpawnPoint"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Bell"))
        {
            isTriggered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bell"))
        {
            isTriggered = false;
        }
    }


}
