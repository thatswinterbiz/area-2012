using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public int EnemyMovementSpeed;
    public float attackRange = 1.5f;

    public float nextAttackTime = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) return;
        float distance = Vector3.Distance(transform.position, player.position);

        // Move toward player if outside attack range
        if(distance > attackRange)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * EnemyMovementSpeed * Time.deltaTime;
            transform.LookAt(player);
        }
        else
        {
            // Inside attack range - perform attack
            if(Time.time >= nextAttackTime)
            {
                Attack();
            }
        }
    }

    void Attack()
    {
        Debug.Log("Enemy performs attack");
        player.GetComponent<PlayerHealth>().TakeDamage(3);
    }
}