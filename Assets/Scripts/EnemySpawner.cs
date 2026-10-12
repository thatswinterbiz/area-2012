using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnPoints;
    public float startingInterval = 4f;
    public float minimumInterval = 0.75f;
    public float difficultyIncrease = 0.1f;
    public int maximumEnemies = 100;
    public float spawnTimer;
    public float currentInterval;
    public int activeEnemies;

    private void Start()
    {
        currentInterval = startingInterval;
    }

    private void Update()
    {
        spawnTimer += Time.deltaTime;
        if(spawnTimer >= currentInterval && activeEnemies < maximumEnemies)
        {
            SpawnEenemy();
            spawnTimer = 0f;
            currentInterval -= difficultyIncrease;
        }
    }
}