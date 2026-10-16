using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyMaxHealth = 100;
    public int enemyCurrentHealth;

    void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
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
        if(gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
