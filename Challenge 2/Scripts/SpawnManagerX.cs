using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnXLeft = -22;
    private float spawnXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    
    void Start()
    {
   
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at the top of the play area
    void SpawnRandomBall()
    {
        spawnInterval = Random.Range(3, 5);

        int index = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnXLeft, spawnXRight), spawnPosY, 0);

        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);
    }
}