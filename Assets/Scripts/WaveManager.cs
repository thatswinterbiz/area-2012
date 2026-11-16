using System.Linq;
using TMPro;
using UnityEngine;

public class WaveManager : PlayerHealth
{
    public int currentWave = 1;
    public int enemyCount = 2;
    public GameObject enemyPrefab;
    public TMP_Text waveTextno;
    private int enemiesAlive = 0;
    public GameObject player;
    public Transform[] enemySpawnPoints;
    public Transform playerSpawnPoint;

    private void Start()
    {
        StartNextWave();
    }

    void StartNextWave()
    {
        Debug.Log($"Starting wave {currentWave}");
        waveTextno.text = "Wave: " + currentWave;
        int enemiesToSpawn = enemyCount * currentWave;
        enemiesAlive = enemiesToSpawn;

        Debug.Log("enemy spawned");
        foreach (int i in Enumerable.Range(1, enemiesToSpawn))
        {
            Debug.Log("Enemy spawned: " + i);
            int randomIndex = Random.Range(0, enemySpawnPoints.Length);
            Transform randomSpawnPoint = enemySpawnPoints[randomIndex];
            Instantiate(enemyPrefab, randomSpawnPoint.position, randomSpawnPoint.rotation);
        }
        currentWave++;
    }

    void RestartGame()
    {
        if(currentHealth <= 0)
        {
            Destroy(player);
            Instantiate(player, playerSpawnPoint.position, playerSpawnPoint.rotation);
            waveTextno.text = "Wave: 1";
            StartNextWave();
        }
    }

    public void EnemyDied()
    {
        enemiesAlive--;
        if (enemiesAlive <= 0)
        {
            StartNextWave();
        }
    }

    public void PlayerDied()
    {
        if(currentHealth <= 0)
        {
            RestartGame();
        }
    }
}