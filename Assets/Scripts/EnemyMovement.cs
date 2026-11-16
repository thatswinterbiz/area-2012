using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public PlayerMovement player;
    public int EnemyMovementSpeed;
    public float attackRange = 1.5f;

    public float nextAttackTime = 0;

    void Start()
    {
        player = FindFirstObjectByType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) return;
        Debug.Log("Player is not null");
        float distance = Vector3.Distance(transform.position, player.transform.position);

        // Move toward player if outside attack range
        if (distance > attackRange)
        {
            Debug.Log("Player is out of reach");
            Vector3 direction = (player.transform.position - transform.position).normalized;
            transform.position += direction * EnemyMovementSpeed * Time.deltaTime;
            transform.right =  direction;
        }
        else
        {
            Debug.Log("Player within reach");
            // Inside attack range - perform attack
            if (Time.time >= nextAttackTime)
            {
                Debug.Log("Attacking!!!");
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