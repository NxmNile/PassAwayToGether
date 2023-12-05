using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn2 : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject enemyPrefab;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnNewEnemy();
    }

    void OnEnable()
    {
        EnemyManager2.OnEnemyKill += SpawnNewEnemy;
    }

    void SpawnNewEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint[0].transform.position, Quaternion.identity);
    }
}