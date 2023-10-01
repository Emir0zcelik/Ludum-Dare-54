using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] npc;
    [SerializeField] private string endPoint;
    [SerializeField] private bool isLeft;

    private Vector3 spawnPositon;

    private float fameMultiplier;
    private float coolDown;

    private void Start()
    {
        spawnPositon = transform.position;
        fameMultiplier = 1;
        coolDown = 0;
    }

    void Update()
    {
        if (coolDown <= Random.Range(5, 10) * fameMultiplier)
        {
            coolDown += Time.deltaTime;
        }
        else
        {
            
            Instantiate(npc[Random.Range(0,2)], spawnPositon, Quaternion.identity);
            coolDown = 0;
        }
    }

    public void SetFameMultiplier(float _fameMultiplier)
    {
        fameMultiplier -= _fameMultiplier;
    }
}
