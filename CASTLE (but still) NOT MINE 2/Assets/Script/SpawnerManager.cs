using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class SpawnerManager : MonoBehaviour
{
    public Camera Camera;
    public GameObject Player;
    public GameObject[] EnemyPrefabs;

    public float SpawnRate ;
    private float SpawnAcceleration = 1;

    public float EnemySpeed = 0.5f;

    private float _nextSpawnTime;
    
    private float yPosition;
    private float xPosition;
    private float zPosition;

    private void Start()
    {
        DetermineNexrSpawnTime();
    }

    private void Update()
    {
        if (Time.time >= _nextSpawnTime)
        {
            SpawnEnemy();
            DetermineNexrSpawnTime();
        }
    }
    
    private void DetermineNexrSpawnTime()
    {
        SpawnAcceleration++;
        _nextSpawnTime = Time.time + (SpawnRate / SpawnAcceleration * 5)  ;
    }

    private void SpawnEnemy()
    {
        var prefabIndexToSpawn = UnityEngine.Random.Range(0, EnemyPrefabs.Length);
        var prefabToSpawn = EnemyPrefabs[prefabIndexToSpawn];
        var enemy = Instantiate(prefabToSpawn, transform);
        var position = new Vector3(-4, 0.5f, 4.5f);
        enemy.transform.position = position;
        transform.Translate( Vector3.back* (Time.deltaTime + EnemySpeed * 1.50f));
    }

    
    
}
