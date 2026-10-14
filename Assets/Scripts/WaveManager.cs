using UnityEngine;
using TMPro;

public class WaveManager : PlayerHealth
{
    public int currentWave = 1;
    public int enemyCount = 2;
    public GameObject enemyPrefab;
    public TMP_Text waveTextno;
    private int enemiesAlive = 0;

    private void Start()
    {
        StartNextWave();
    }

    void StartNextWave()
    {
        waveTextno.text = "Wave: " + currentWave;
        int enemiesToSpawn = enemyCount + enemyCount;
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
            StartNextWave();
        }
    }
}