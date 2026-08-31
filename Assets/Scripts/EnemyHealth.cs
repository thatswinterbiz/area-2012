using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyMaxHealth = 100;
    public int enemyCurrentHealth;

    void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
    }

    public void TakeDamage(int amount)
    {
        enemyCurrentHealth -= amount;
        Debug.Log("Player took damage, current health: " + enemyCurrentHealth);

        if (enemyCurrentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("player died");
    }
}
