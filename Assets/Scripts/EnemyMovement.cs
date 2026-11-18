using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private PlayerMovement player;
    public int EnemyMovementSpeed;
    public float attackRange = 1.5f;
    float timer = 0;
    public float nextAttackTime = 0;

    void Start()
    {
        player = FindFirstObjectByType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) return;
        timer += Time.deltaTime;
        Debug.Log("Player is not null");
        float distance = Vector3.Distance(transform.position, player.transform.position);

        // Move toward player if outside attack range
        if (distance > attackRange)
        {
            Debug.Log($"Player at position {player.transform.position} is out of reach");
            Vector3 direction = (player.transform.position - transform.position).normalized;
            transform.position += EnemyMovementSpeed * Time.deltaTime * direction;
            transform.right =  direction;
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
                Attack();
            }
        }
    }

    void Attack()
    {
        Debug.Log("Enemy performs attack");
        Debug.Log("PlayerHealth found? " + (player.GetComponent<PlayerHealth>() == null));
        player.gameObject.GetComponent<PlayerHealth>().TakeDamage(3);
    }
}