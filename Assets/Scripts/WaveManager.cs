using UnityEngine;
using TMPro;

public class WaveManager : MonoBehaviour
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

    }

    public void EnemyDied()
    {

    }
}