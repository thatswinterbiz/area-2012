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
        waveTextno.text = "Wave: " + currentWave;
        int enemiesToSpawn = enemyCount + enemyCount;
        int randomIndex = Random.Range(0, enemySpawnPoints.Length);
        Transform randomSpawnPoint = enemySpawnPoints[randomIndex];

        Debug.Log("enemy spawned");
        foreach (int i in Enumerable.Range(1, enemiesToSpawn))
        {
            Instantiate(enemyPrefab, randomSpawnPoint.position, randomSpawnPoint.rotation);
        }
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
        if(enemiesAlive <= 0)
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