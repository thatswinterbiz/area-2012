using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public float bulletDamage = 1f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.right * bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("1");
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("2");
            Debug.Log("hit enemy");
            var eh = collision.gameObject.GetComponent<EnemyHealth>();
            eh.EnemyTakesDamage(10);
            Debug.Log("3");
            Destroy(gameObject);
        }
    }
}