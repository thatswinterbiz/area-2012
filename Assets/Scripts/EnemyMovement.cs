using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private PlayerMovement player;
    private PlayerHealth playerHealth;
    public int EnemyMovementSpeed;
    public float attackRange = 1.5f;
    float timer = 0;
    public float nextAttackTime;
    Rigidbody2D rb;

    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        player = FindFirstObjectByType<PlayerMovement>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player == null) return;
        timer += Time.deltaTime;
        Debug.Log("Timer: " + timer);
        Debug.Log("Player is not null");
        float distance = Vector3.Distance(transform.position, player.transform.position);

        // Move toward player if outside attack range
        if (distance > attackRange)
        {
            Debug.Log($"Player at position {player.transform.position} is out of reach");
            Vector3 direction = (player.transform.position - transform.position).normalized;
            transform.right = direction;
            rb.linearVelocity = EnemyMovementSpeed * transform.right;
            Vector3 r = transform.eulerAngles;
            transform.eulerAngles = new Vector3(0, 0, r.z);
        }
        else
        {
            Debug.Log("Player within reach");
            // Inside attack range - perform attack
            if (timer >= nextAttackTime)
            {
                Debug.Log("Attacking!!!");
                timer = 0;
                Attack();
            }
        }
    }

    void Attack()
    {
        Debug.Log("Enemy performs attack");
        Debug.Log("PlayerHealth found? " + (player.GetComponent<PlayerHealth>() == null));
        playerHealth.TakeDamage(3);
    }
}