using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;         // Assign your enemy prefab in the Inspector
    public int enemyCount = 5;             // Number of enemies to spawn
    public Transform spawnAreaMin;         // Drag the SpawnAreaMin GameObject here
    public Transform spawnAreaMax;         // Drag the SpawnAreaMax GameObject here

    void Start()
    {
        SpawnEnemies();
    }

    void SpawnEnemies()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            // Generate random spawn position based on the positions of SpawnAreaMin and SpawnAreaMax
            float spawnX = Random.Range(spawnAreaMin.position.x, spawnAreaMax.position.x);
            float spawnY = Random.Range(spawnAreaMin.position.y, spawnAreaMax.position.y);
            Vector2 spawnPosition = new Vector2(spawnX, spawnY);

            // Instantiate the enemy at the random position
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
