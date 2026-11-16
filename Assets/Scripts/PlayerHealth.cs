using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    WaveManager waveManager;

    public int maxHealth = 100;
    public int currentHealth;
    private bool playerDead = false;

    void Start()
    {
        waveManager = FindFirstObjectByType<WaveManager>();

        playerDead = false;
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        if (playerDead == true) return;
        currentHealth -= amount;
        Debug.Log("Player took damage, current health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("player died");
        playerDead = true;

        waveManager.RestartGame();
    }
}