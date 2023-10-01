using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bell : MonoBehaviour
{
    private bool isTriggered;
    private bool isBell;

    private void Start()
    {
        isTriggered = false;
        isBell = false;
    }

    private void Update()
    {
        if (isTriggered)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                isBell = true;
            }
            else
            {
                isBell = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isTriggered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isTriggered = false;
            isBell = false;
        }
    }

    public bool GetIsBell()
    {
        return isBell;
    }
}
