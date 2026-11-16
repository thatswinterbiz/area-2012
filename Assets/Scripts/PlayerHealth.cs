using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    private bool playerDead = false;

    void Start()
    {
        playerDead = false;
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        // if (playerDead == true) return;
        Debug.Log("The player is dead? " + (playerDead == true));
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
    }
}