using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    private float transaction;

    private float numA;
    private float numB;
    private float sum;

    private void Start()
    {
        sum = 0;
    }

    void Update()
    {
        transaction = Random.Range(1, 3);
        numA = Random.Range(1, 100);
        numB = Random.Range(1, 100);
        Debug.Log(transaction);
        if (transaction == 1)
        {
            sum = numA + numB;
        }

        if (transaction == 3)
        {
            sum = numA * numB;
        }
    }
}
