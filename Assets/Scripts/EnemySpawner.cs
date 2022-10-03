using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private static EnemySpawner instance;
    [SerializeField] GameObject enemy;
    [SerializeField] private float enemySpawnTime = 5f;
    private float timeElapsed;
    private float timeResetter = 3f;
    
    private void Update()
    {
        enemySpawnTime -= Time.deltaTime;
        if (enemySpawnTime <= 0)
        {
            Spawner();
                
            enemySpawnTime = timeResetter;
        }
    }
    public static EnemySpawner GetInstance()
    {
        return instance;
    }

    private void Spawner()
    {
        GameObject newEnemy = Instantiate(enemy);
        newEnemy.transform.position = new Vector3(Random.Range(-8f,8f), 1f, Random.Range(9f, -8f));
        

    }
}
