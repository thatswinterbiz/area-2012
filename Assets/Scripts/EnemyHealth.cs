using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyMaxHealth = 100;
    public int enemyCurrentHealth;
    WaveManager waveManager;

    void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
        waveManager = FindFirstObjectByType<WaveManager>();
    }

    public void EnemyTakesDamage(int amount)
    {
        enemyCurrentHealth -= amount;
        Debug.Log("Enemy took damage, current health: " + enemyCurrentHealth);

        if (enemyCurrentHealth <= 0)
        {
            EnemyDies();
        }
    }

    public void EnemyDies()
    {
        Debug.Log("enemy died");
        if (gameObject.CompareTag("Enemy"))
        {
            waveManager.EnemyDied();
            Destroy(gameObject);
        }
    }
}
